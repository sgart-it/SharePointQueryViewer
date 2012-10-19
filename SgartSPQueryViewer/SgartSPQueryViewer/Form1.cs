using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using SP = Microsoft.SharePoint.Client;
using SPU = Microsoft.SharePoint.Client.Utilities;
using System.Diagnostics;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Net.Security;

namespace SgartSPQueryViewer
{
  public partial class Form1 : System.Windows.Forms.Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      tpCaml.Select();

      txtCSharp.Text = "";
      txtCaml.Text = "";
      txtViewData.Text = "";
      txtCaml.Enabled = false;
      txtCSharp.Enabled = false;
      txtViewData.Enabled = false;
      //tabControl1.Enabled = false;
      btnCopy.Enabled = false;

      btnConnect.Enabled = false;
      cmbLists.Enabled = false;
      cmbViews.Enabled = false;

      ServicePointManager.ServerCertificateValidationCallback = delegate(object sender1, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
      {
        return true;
      };

      this.Text  = Application.ProductName + " - v. " + Application.ProductVersion;

      btnRandomGuid_Click(null, null);

      txtUrl.Focus();
    }


    private SP.ClientContext GetClientContext(string webUrl)
    {
      SP.ClientContext ctx = new SP.ClientContext(webUrl);
      if (txtUser.Text != "")
      {
        ctx.Credentials = new System.Net.NetworkCredential(txtUser.Text, txtPwd.Text);
      }
      return ctx;
    }

    private void button1_Click(object sender, EventArgs e)
    {
      if (btnConnect.Enabled == false)
        return;

      string webUrl = txtUrl.Text;
      if (chkTryFindWebUrl.Checked)
        webUrl = TryToFindCorrectUrl(webUrl);

      cmbLists.Items.Clear();
      cmbLists.Enabled = false;
      cmbViews.Items.Clear();
      cmbViews.Enabled = false;
      txtCSharp.Text = "";
      txtCaml.Text = "";
      txtViewData.Text = "";
      txtCSharp.Enabled = false;
      txtCSharp.Enabled = false;
      txtViewData.Enabled = false;
      //tabControl1.Enabled = false;
      lblWait.Visible = true;
      lblViewName.Text = "";
      btnCopy.Enabled = false;
      Application.DoEvents();

      try
      {

        using (SP.ClientContext ctx = GetClientContext(webUrl))
        {
          SP.Web web = ctx.Web;
          SP.ListCollection lists = web.Lists;
          ctx.Load(lists);
          ctx.ExecuteQuery();
          txtUrl.Text = webUrl;

          foreach (var list in lists)
          {
            cmbLists.Items.Add(list.Title);
          }
          if (cmbLists.Items.Count > 0)
            cmbLists.SelectedIndex = 0;
          cmbLists.Enabled = true;

        }
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message, "SgartSPQueryViewer", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
      finally
      {
        lblWait.Visible = false;
      }
    }

    private static bool customXertificateValidation(object sender, X509Certificate cert, X509Chain chain, System.Net.Security.SslPolicyErrors error)   
    {  
      return true; 
    }

    private static string TryToFindCorrectUrl(string webUrl)
    {

      Uri url = new Uri(webUrl);
      webUrl = url.GetLeftPart(UriPartial.Path);
      int p = webUrl.ToLower().IndexOf("/_layouts/");
      if (p > 0)
      {
        webUrl = webUrl.Substring(0, p);
      }
      p = webUrl.ToLower().IndexOf("/_vti_bin/");
      if (p > 0)
      {
        webUrl = webUrl.Substring(0, p);
      }



      p = webUrl.ToLower().LastIndexOf("/lists/");
      if (p > 0)
      {
        webUrl = webUrl.Substring(0, p);
      }
      else
      {
        p = webUrl.ToLower().LastIndexOf("/liste/");
        if (p > 0)
        {
          webUrl = webUrl.Substring(0, p);
        }

      }
      if (webUrl.EndsWith(".aspx", StringComparison.InvariantCultureIgnoreCase)
        || webUrl.EndsWith(".asmx", StringComparison.InvariantCultureIgnoreCase)
        || webUrl.EndsWith(".vsc", StringComparison.InvariantCultureIgnoreCase))
      {
        p = webUrl.LastIndexOf('/');
        webUrl = webUrl.Substring(0, p);
      }

      return webUrl;
    }


    private void cmbLists_SelectedIndexChanged(object sender, EventArgs e)
    {
      cmbViews.Items.Clear();
      cmbViews.Enabled = false;
      //tabControl1.Enabled = false;
      txtCaml.Text = "";
      txtCSharp.Text = "";
      lblWait.Visible = true;
      lblViewName.Text = "";
      btnCopy.Enabled = false;
      Application.DoEvents();

      try
      {
        string webUrl = txtUrl.Text;

        using (SP.ClientContext ctx = GetClientContext(webUrl))
        {
          SP.Web web = ctx.Web;
          string listTitle = (string)cmbLists.SelectedItem;
          SP.List list = web.Lists.GetByTitle(listTitle);
          SP.ViewCollection views = list.Views;
          ctx.Load(list);
          ctx.Load(list.Fields);
          ctx.Load(views);
          ctx.ExecuteQuery();

          LoadFields(list);

          foreach (var view in views)
          {
            cmbViews.Items.Add(view.Title);
          }
          if (cmbViews.Items.Count > 0)
          {
            cmbViews.SelectedIndex = 0;
          }

          cmbViews.Enabled = true;
        }
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message, "SgartSPQueryViewer", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
      finally
      {
        lblWait.Visible = false;
      }

    }


    private string allFields = "";

    private void LoadFields(SP.List list)
    {
      cmbFilterField.Enabled = false;
      cmbFilterField.Items.Clear();

      if (cmbLists.SelectedIndex >= 0)
      {
        string webUrl = txtUrl.Text;

        List<string> fields = new List<string>();
        fields.Add("");

        using (SP.ClientContext ctx = GetClientContext(webUrl))
        {
          StringBuilder sb = new StringBuilder();
          sb.Append("<Fields>");
          foreach (var item in list.Fields)
          {
           fields.Add(item.InternalName + " ( " + item.Title + " )");
            sb.Append(item.SchemaXml);
          }
          sb.Append("</Fields>");
          allFields = sb.ToString();
          txtFields.Text = FormatXml(allFields);

          fields.Sort();
          cmbFilterField.Items.AddRange(fields.ToArray());
        }
        cmbFilterField.Enabled = true;
      }

    }

    private void cmbFilterField_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (cmbFilterField.SelectedIndex > 0)
      {
        XmlDocument xDoc = new XmlDocument();
        xDoc.LoadXml(allFields);
        string internalName =(string) cmbFilterField.SelectedItem;
        int p = internalName.IndexOf('(');
        if (p > 0)
          internalName = internalName.Substring(0, p).TrimEnd();
        XmlNodeList nodes = xDoc.SelectNodes("Fields/Field[@Name='" + internalName + "']");
        StringBuilder sb = new StringBuilder();
        sb.Append("<Fields>");
        foreach (XmlNode fld in nodes)
        {
          sb.Append(fld.OuterXml);
        }
        sb.Append("</Fields>");
        txtFields.Text = FormatXml(sb.ToString());
      }
      else
      {
        txtFields.Text = FormatXml(allFields);
      }
    }


    private void cmbViews_SelectedIndexChanged(object sender, EventArgs e)
    {
      lblWait.Visible = true;
      txtCaml.Enabled = false;
      txtCSharp.Enabled = false;
      txtCaml.Text = "";
      txtCSharp.Text = "";
      //tabControl1.Enabled = false;
      lblViewName.Text = "";
      btnCopy.Enabled = false;

      txtListName.Text = "";
      txtListID.Text = "";
      txtViewID.Text = "";
      txtViewName.Text = "";

      Application.DoEvents();

      try
      {
        string webUrl = txtUrl.Text;

        using (SP.ClientContext ctx = GetClientContext(webUrl))
        {
          SP.Web web = ctx.Web;

          string listTitle = (string)cmbLists.SelectedItem;
          SP.List list = web.Lists.GetByTitle(listTitle);

          string viewTitle = (string)cmbViews.SelectedItem;
          SP.View view = list.Views.GetByTitle(viewTitle);
          //ctx.Load(view, w => w.ViewQuery, w => w.ViewFields, w => w.ViewData, w => w.Title, w => w.HtmlSchemaXml);
          ctx.Load(list);
          ctx.Load(list.RootFolder);
          ctx.Load(view);
          ctx.Load(view.ViewFields);
          ctx.ExecuteQuery();

          if (view != null)
          {
            lblViewName.Text = view.ServerRelativeUrl;

            StringBuilder sb = new StringBuilder();
            sb.Append("<View>");
            sb.Append("<Query>");
            sb.Append(view.ViewQuery);
            sb.Append("</Query>");
            sb.AppendFormat("<RowLimit>{0}</RowLimit>", view.RowLimit);
            sb.AppendFormat("<ViewFields>{0}</ViewFields>", view.ViewFields.SchemaXml);
            sb.Append("</View>");
            txtCaml.Text = FormatXml(sb.ToString());

            txtViewData.Text = FormatXml(view.HtmlSchemaXml);

            txtCSharp.Text = FormatCShart(list, view);

            LoadInfo(list, view);

            //tabControl1.Enabled = true;
            txtCaml.Enabled = true;
            txtCSharp.Enabled = true;
            txtViewData.Enabled = true;
            btnCopy.Enabled = true;
          }
        }
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message, "SgartSPQueryViewer", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
      finally
      {
        lblWait.Visible = false;
      }

    }

    private void LoadInfo(SP.List list, SP.View view)
    {
      txtListID.Text = list.Id.ToString("B");
      txtListName.Text = list.RootFolder.ServerRelativeUrl;
      txtListTitle.Text = list.Title;
      txtCreated.Text = list.Created.ToString() + " ( UTC: " + list.Created.ToString("s") + " )";

      txtViewID.Text = view.Id.ToString("B");
      txtViewName.Text = view.ServerRelativeUrl;
      chkPersonalView.Checked = view.PersonalView;
      chkHiddenView.Checked = view.Hidden;
      chkDefaultView.Checked = view.DefaultView;

    }

    private void txtUrl_TextChanged(object sender, EventArgs e)
    {
      btnConnect.Enabled = txtUrl.Text.Trim().Length > 0;
    }

    private string FormatXml(string xml)
    {
      XmlDocument xDoc = new XmlDocument();
      xDoc.LoadXml(xml);
      using (System.IO.StringWriter sw = new System.IO.StringWriter())
      {
        XmlTextWriter xw = new XmlTextWriter(sw);
        xw.Formatting = Formatting.Indented;
        xw.Indentation = 2;
        xw.IndentChar = ' ';
        xDoc.WriteTo(xw);
        return sw.ToString();
      }
    }

    private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      Process myProcess = new Process();

      try
      {
        // true is the default, but it is important not to set it to false 
        myProcess.StartInfo.UseShellExecute = true;
        myProcess.StartInfo.FileName = "http://www.sgart.it/?prg=SgartSPQueryViewer";
        myProcess.Start();
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message, "SgartSPQueryViewer", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    private string FormatCShart(SP.List list, SP.View view)
    {
      StringBuilder sb = new StringBuilder();
      string listUrl = list.RootFolder.ServerRelativeUrl.Substring(list.ParentWebUrl.Length);
      sb.AppendFormat(@"// Generated by SgartSPQueryViewer - http://www.sgart.it
//using Microsoft.SharePoint;
string url = ""{0}"";
string listUrl = ""{1}"";
using (SPSite site = new SPSite(url))
{{
    using (SPWeb web = site.OpenWeb())
    {{
        SPList list = web.GetList(web.ServerRelativeUrl.TrimEnd('/') + listUrl);
        SPFieldCollection fields = list.Fields;"
        , txtUrl.Text, listUrl);
      //field
      string firstField = "LinkTitle";
      if (view.ViewFields.Count == 0)
      {
        sb.Append(@"
        SPField fldLinkTitle = fields.GetFieldByInternalName(""LinkTitle"");");
      }
      else
      {
        foreach (var fld in view.ViewFields)
        {
          string fldName = fld.Substring(0, 1).ToUpper() + fld.Substring(1);
          if (firstField == "LinkTitle")
            firstField = fldName;
          sb.AppendFormat(@"
        SPField fld{1} = fields.GetFieldByInternalName(""{0}"");"
            , fld, fldName);
        }
      }
      sb.AppendFormat(@"
        SPQuery query = new SPQuery();
        query.Query = @""{0}"";
        query.RowLimit = 0;
        query.ViewFields = @""{1}"";
        SPListItemCollection items = list.GetItems(query);
        Console.WriteLine(""Items found: "" + items.Count);
        foreach (SPListItem item in items)
        {{
            //TODO: insert your code
            //Console.WriteLine(string.Format(""ID: {{0}} - Title: {{1}}"", item.ID, item.Title));
            Console.WriteLine(string.Format(""ID: {{0}} - Title: {{1}}""
                    , item.ID
                    , fld{2}.GetFieldValueAsText(item[fld{2}.Id])

        }}
    }}
}}
", view.ViewQuery.Replace("\"", "'"), view.ViewFields.SchemaXml.Replace("\"", "'"), firstField);

      return sb.ToString();
    }

    private void btnCopy_Click(object sender, EventArgs e)
    {
      switch (tabControl1.SelectedTab.Name)
      {
        case "tpCaml":
          txtCaml.SelectAll();
          txtCaml.Copy();
          break;
        case "tpCSharp":
          txtCSharp.SelectAll();
          txtCSharp.Copy();
          break;
        case "tpViewData":
          txtViewData.SelectAll();
          txtViewData.Copy();
          break;
        case "tpFields":
          txtFields.SelectAll();
          txtFields.Copy();
          break;
        default:
          break;
      }
    }

    private void btnRandomGuid_Click(object sender, EventArgs e)
    {
      txtRandomGuid.Text = "";
      Application.DoEvents();

      StringBuilder sb = new StringBuilder();
      for (int i = 0; i < 20; i++)
      {
        sb.AppendLine(Guid.NewGuid().ToString("B"));
      }
      txtRandomGuid.Text = sb.ToString();
    }



  }
}

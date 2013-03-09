using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using Microsoft.SharePoint.Client;
using SP = Microsoft.SharePoint.Client;
using Microsoft.SharePoint.Client.Utilities;
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
            progressBar1.Visible = false;
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 7;
            progressBar1.Value = 0;

            tpCaml.Select();

            ProxyUrl = "";

            txtCSharp.Clear();
            txtCaml.Clear();
            txtListData.Clear();
            txtViewData.Clear();

            txtCaml.Enabled = false;
            txtCSharp.Enabled = false;
            txtListData.Enabled = false;
            txtViewData.Enabled = false;
            //tabControl1.Enabled = false;
            btnCopy.Enabled = false;

            cmbFilterField.Enabled = false;
            txtFields.Clear();
            txtContentTypes.Clear();

            btnConnect.Enabled = false;
            cmbLists.Enabled = false;
            cmbViews.Enabled = false;
            cmbViews.ResetText();

            ServicePointManager.ServerCertificateValidationCallback = delegate(object sender1, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
            {
                return true;
            };

            this.Text = Application.ProductName + " - v. " + Application.ProductVersion;

            btnRandomGuid_Click(null, null);

            txtUrl.Focus();
        }

        public string ProxyUrl { get; set; }
        public string ProxyUser { get; set; }
        public string ProxyPwd { get; set; }

        private SP.ClientContext GetClientContext(string webUrl)
        {
            SP.ClientContext ctx = new SP.ClientContext(webUrl);
            if (txtUser.Text != "")
            {
                string domain = "";
                string user = "";
                if (txtUser.Text.Replace('/', '\\').Contains('\\'))
                {
                    string[] tmp = txtUser.Text.Split('\\');
                    domain = tmp[0];
                    user = tmp[1];
                }
                ctx.Credentials = new System.Net.NetworkCredential(user, txtPwd.Text, domain);
            }
            if (string.IsNullOrEmpty(ProxyUrl) == false)
            {
                ctx.ExecutingWebRequest += (sen, args) =>
                {
                    WebProxy myProxy = new WebProxy(ProxyUrl);
                    string domain = "";
                    string user = "";
                    if (ProxyUser.Replace('/', '\\').Contains('\\'))
                    {
                        string[] tmp = ProxyUser.Split('\\');
                        domain = tmp[0];
                        user = tmp[1];
                    }
                    // myProxy.Credentials = new System.Net.NetworkCredential(ProxyUser, ProxyPwd, domain);
                    myProxy.Credentials = System.Net.CredentialCache.DefaultCredentials;
                    myProxy.UseDefaultCredentials = true;
                    args.WebRequestExecutor.WebRequest.Proxy = myProxy;
                };
            }

            return ctx;
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (btnConnect.Enabled == false)
                return;

            progressBar1.Value = 1;
            progressBar1.Visible = true;

            string webUrl = txtUrl.Text;

            cmbLists.Items.Clear();
            cmbLists.Enabled = false;
            cmbViews.Items.Clear();
            cmbViews.ResetText();
            cmbViews.Enabled = false;

            txtCaml.Clear();
            txtCSharp.Clear();
            txtListData.Clear();
            txtViewData.Clear();

            txtCaml.Enabled = false;
            txtCSharp.Enabled = false;
            txtListData.Enabled = false;
            txtViewData.Enabled = false;
            //tabControl1.Enabled = false;
            lblWait.Visible = true;
            lblViewName.Text = "";
            btnCopy.Enabled = false;

            cmbFilterField.Enabled = false;
            txtFields.Clear();
            txtContentTypes.Clear();

            txtListID.Clear();
            txtListName.Clear();
            txtListTitle.Clear();
            txtCreated.Clear();
            txtItemCount.Clear();
            txtViewID.Clear();
            txtViewName.Clear();

            Application.DoEvents();

            try
            {
                if (chkTryFindWebUrl.Checked)
                    webUrl = TryToFindCorrectUrl(webUrl);

                progressBar1.Value = 1;
                using (SP.ClientContext ctx = GetClientContext(webUrl))
                {
                    SP.Web web = ctx.Web;
                    SP.ListCollection lists = web.Lists;
                    ctx.Load(lists);
                    ctx.ExecuteQuery();

                    progressBar1.Value++;

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
            catch (System.Net.WebException ex)
            {
                bool resolved = false;
                if (ex.Status == WebExceptionStatus.ProtocolError)
                {
                    HttpWebResponse response = (HttpWebResponse)ex.Response;
                    if (response.StatusCode == HttpStatusCode.ProxyAuthenticationRequired)
                    {

                        ProxyCredentialRequest frmProxy = new ProxyCredentialRequest();
                        frmProxy.ProxyUrl = response.ResponseUri.ToString();
                        if (string.IsNullOrEmpty(frmProxy.ProxyUser))
                        {
                            frmProxy.ProxyUser = txtUser.Text;
                            frmProxy.ProxyPwd = txtPwd.Text;
                        }
                        else
                        {
                            frmProxy.ProxyUser = ProxyUser;
                            frmProxy.ProxyPwd = ProxyPwd;
                        }
                        DialogResult r = frmProxy.ShowDialog();
                        if (r == System.Windows.Forms.DialogResult.OK)
                        {
                            ProxyUrl = frmProxy.ProxyUrl;
                            ProxyUser = frmProxy.ProxyUser;
                            ProxyPwd = frmProxy.ProxyPwd;
                            resolved = true;
                            btnConnect_Click(null, null);
                        }
                    }
                }
                if (resolved == false)
                {
                    ProxyUrl = "";
                    MessageBox.Show(ex.Message, "SgartSPQueryViewer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "SgartSPQueryViewer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                lblWait.Visible = false;
                progressBar1.Visible = false;
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
            progressBar1.Value = 1;
            progressBar1.Visible = true;

            cmbViews.Items.Clear();
            cmbViews.ResetText();
            cmbViews.Enabled = false;
            //tabControl1.Enabled = false;
            txtCaml.Clear();
            txtCSharp.Clear();
            txtListData.Clear();
            txtListData.Enabled = false;
            txtViewData.Clear();
            txtViewID.Clear();
            txtViewName.Clear();
            lblWait.Visible = true;
            lblViewName.Text = "";
            btnCopy.Enabled = false;
            dgResults.DataSource = null;

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
                    ctx.Load(list, x => x.SchemaXml);
                    ctx.Load(list.Fields);
                    ctx.Load(views);
                    ctx.ExecuteQuery();
                    progressBar1.Value++;

                    txtListData.Text = FormatXml(list.SchemaXml);

                    LoadFields(list);

                    LoadContentTypes(list);

                    foreach (SP.View view in views)
                    {
                        string id = view.Id.ToString("B").ToUpper();
                        string title = view.Title;
                        if (title == "")
                        {
                            title = id;
                        }
                        MyListItem itm = new MyListItem(id, title);
                        cmbViews.Items.Add(itm);
                    }
                    if (cmbViews.Items.Count > 0)
                    {
                        cmbViews.SelectedIndex = 0;
                    }
                    cmbViews.Enabled = true;
                    txtListData.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "SgartSPQueryViewer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                lblWait.Visible = false;
                progressBar1.Visible = false;
            }

        }


        private string allContentTypes = "";

        private void LoadContentTypes(SP.List list)
        {
            cmbFilterContentType.Enabled = false;
            cmbFilterContentType.Items.Clear();

            if (cmbLists.SelectedIndex >= 0)
            {
                string webUrl = txtUrl.Text;

                List<string> contentTypes = new List<string>();
                contentTypes.Add("");

                using (SP.ClientContext ctx = GetClientContext(webUrl))
                {
                    Web oWebsite = ctx.Web;
                    SP.List list1 = oWebsite.Lists.GetById(list.Id);
                    ctx.Load(list1);
                    SP.ContentTypeCollection coll = list1.ContentTypes;
                    ctx.Load(coll, cts => cts.Include(
                             ct => ct.Name
                             , ct => ct.Description
                             , ct => ct.SchemaXml
                            ));
                    ctx.ExecuteQuery();
                    progressBar1.Value++;

                    StringBuilder sb = new StringBuilder();
                    sb.Append("<ContentTypes>");
                    foreach (var item in coll)
                    {
                        contentTypes.Add(item.Name + " ( " + item.Description + " )");
                        sb.Append(item.SchemaXml);
                    }
                    sb.Append("</ContentTypes>");
                    allContentTypes = sb.ToString();
                    txtContentTypes.Text = FormatXml(allContentTypes);

                    contentTypes.Sort();
                    cmbFilterContentType.Items.AddRange(contentTypes.ToArray());
                }
                cmbFilterContentType.Enabled = true;
            }
        }
        private void cmbFilterContentType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFilterContentType.SelectedIndex > 0)
            {
                XmlDocument xDoc = new XmlDocument();
                xDoc.LoadXml(allContentTypes);
                string internalName = (string)cmbFilterContentType.SelectedItem;
                int p = internalName.IndexOf('(');
                if (p > 0)
                    internalName = internalName.Substring(0, p).TrimEnd();
                XmlNodeList nodes = xDoc.SelectNodes("ContentTypes/ContentType[@Name='" + internalName + "']");
                StringBuilder sb = new StringBuilder();
                sb.Append("<ContentTypes>");
                foreach (XmlNode fld in nodes)
                {
                    sb.Append(fld.OuterXml);
                }
                sb.Append("</ContentTypes>");
                txtContentTypes.Text = FormatXml(sb.ToString());
            }
            else
            {
                txtContentTypes.Text = FormatXml(allContentTypes);
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
                    progressBar1.Value++;

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
                string internalName = (string)cmbFilterField.SelectedItem;
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
            progressBar1.Value = 1;
            progressBar1.Visible = true;
            LoadDetailView(false);
            progressBar1.Visible = false;
        }

        private void btnResultsRefresh_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 1;
            progressBar1.Visible = true;
            progressBar1.Value = 1;
            LoadDetailView(true);
            progressBar1.Visible = false;
        }

        private void LoadDetailView(bool loadData)
        {
            dgResults.DataSource = null;

            Guid viewId = new Guid(((MyListItem)cmbViews.SelectedItem).Key);

            lblWait.Visible = true;
            txtCaml.Enabled = false;
            txtCSharp.Enabled = false;
            txtCaml.Clear();
            txtCSharp.Clear();
            //tabControl1.Enabled = false;
            lblViewName.Text = "";
            btnCopy.Enabled = false;

            txtListID.Clear();
            txtListName.Clear();
            txtListTitle.Clear();
            txtCreated.Clear();
            txtItemCount.Clear();
            txtViewID.Clear();
            txtViewName.Clear();
            btnResultsRefresh.Enabled = false;

            Application.DoEvents();

            try
            {
                string webUrl = txtUrl.Text;

                using (SP.ClientContext ctx = GetClientContext(webUrl))
                {
                    SP.Web web = ctx.Web;

                    string listTitle = (string)cmbLists.SelectedItem;
                    SP.List list = web.Lists.GetByTitle(listTitle);
                    SP.View view = list.Views.GetById(viewId);
                    //ctx.Load(view, w => w.ViewQuery, w => w.ViewFields, w => w.ViewData, w => w.Title, w => w.HtmlSchemaXml);
                    ctx.Load(list);
                    ctx.Load(list.RootFolder);
                    ctx.Load(view);
                    ctx.Load(view.ViewFields);

                    ctx.ExecuteQuery();
                    progressBar1.Value++;

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
                        if (loadData == false)
                        {
                            txtResultsNumber.Text = view.RowLimit.ToString();
                        }

                        txtViewData.Text = FormatXml(view.HtmlSchemaXml);

                        txtCSharp.Text = FormatCSharp(list, view);

                        LoadInfo(list, view);

                        if (loadData == true)
                        {
                            LoadItems(ctx, list, view);
                        }

                        //tabControl1.Enabled = true;
                        txtCaml.Enabled = true;
                        txtCSharp.Enabled = true;
                        txtViewData.Enabled = true;
                        btnCopy.Enabled = true;
                        btnResultsRefresh.Enabled = true;

                        cmbFilterField.Enabled = true;

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

        private void LoadItems(SP.ClientContext ctx, SP.List list, SP.View view)
        {
            SP.CamlQuery query = new SP.CamlQuery();
            query.ViewXml = "<View>" + view.ViewQuery + "<RowLimit>" + txtResultsNumber.Text + "</RowLimit></View>";
            var items = list.GetItems(query);
            ctx.Load(items, itms => itms.ListItemCollectionPosition
                , itms => itms.Include(
                    itm => itm.FieldValuesAsText
                    , itm => itm.ContentType
                    )
                );
            ctx.ExecuteQuery();
            progressBar1.Value++;

            DataTable tbl = new DataTable();
            DataColumnCollection columns = tbl.Columns;
            DataRowCollection rows = tbl.Rows;

            if (items != null && items.Count > 0)
            {
                columns.Add("N.", typeof(System.String));
                columns.Add("ContentType", typeof(System.String));
                foreach (var fld in items[0].FieldValuesAsText.FieldValues)
                {
                    columns.Add(fld.Key, typeof(System.String));
                }
                int i = 1;
                foreach (var item in items)
                {
                    DataRow row = tbl.NewRow();
                    row["N."] = i;
                    row["ContentType"] = item.ContentType.Name;
                    foreach (var fld in item.FieldValuesAsText.FieldValues)
                    {
                        if (fld.Value != null)
                        {
                            row[fld.Key] = item.FieldValuesAsText[fld.Key];
                        }
                    }
                    rows.Add(row);
                    i++;
                }
            }
            dgResults.AutoGenerateColumns = true;
            dgResults.AutoSize = true;
            dgResults.DataSource = tbl;
        }

        private void LoadInfo(SP.List list, SP.View view)
        {
            txtListID.Text = list.Id.ToString("B");
            txtListName.Text = list.RootFolder.ServerRelativeUrl;
            txtListTitle.Text = list.Title;
            txtCreated.Text = list.Created.ToString() + " ( UTC: " + list.Created.ToString("s") + " )";
            txtItemCount.Text = list.ItemCount.ToString();

            txtViewID.Text = view.Id.ToString("B");
            txtViewName.Text = view.ServerRelativeUrl;
            chkPersonalView.Checked = view.PersonalView;
            chkHiddenView.Checked = view.Hidden;
            chkDefaultView.Checked = view.DefaultView;
            progressBar1.Value++;

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

        private string FormatCSharp(SP.List list, SP.View view)
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
        query.ViewFieldsOnly = true;
        query.ViewAttributes = ""Scope='{3}'"";     //Default, FilesOnly, Recursive, RecursiveAll
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
", view.ViewQuery.Replace("\"", "'"), view.ViewFields.SchemaXml.Replace("\"", "'"), firstField, view.Scope);

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
                case "tpListData":
                    txtListData.SelectAll();
                    txtListData.Copy();
                    break;
                case "tpViewData":
                    txtViewData.SelectAll();
                    txtViewData.Copy();
                    break;
                case "tpFields":
                    txtFields.SelectAll();
                    txtFields.Copy();
                    break;
                case "tpContentTypes":
                    txtContentTypes.SelectAll();
                    txtContentTypes.Copy();
                    break;
                default:
                    break;
            }
        }

        private void btnRandomGuid_Click(object sender, EventArgs e)
        {
            txtRandomGuid.Clear();
            Application.DoEvents();

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < 20; i++)
            {
                sb.AppendLine(Guid.NewGuid().ToString("B"));
            }
            txtRandomGuid.Text = sb.ToString();
        }

        private void txtResultsNumber_Leave(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            int v = 30;
            if (Int32.TryParse(txt.Text, out v) == true)
            {
                if (v < -1)
                {
                    txt.Text = "-1";
                }
            }
            else
            {
                txt.Text = v.ToString();
            }

        }

    }
}

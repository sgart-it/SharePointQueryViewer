namespace SgartSPQueryViewer
{
  partial class Form1
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpCaml = new System.Windows.Forms.TabPage();
            this.lblViewName = new System.Windows.Forms.Label();
            this.txtCaml = new System.Windows.Forms.TextBox();
            this.tpCSharp = new System.Windows.Forms.TabPage();
            this.txtCSharp = new System.Windows.Forms.TextBox();
            this.tpListData = new System.Windows.Forms.TabPage();
            this.txtListData = new System.Windows.Forms.TextBox();
            this.tpViewData = new System.Windows.Forms.TabPage();
            this.txtViewData = new System.Windows.Forms.TextBox();
            this.tpFields = new System.Windows.Forms.TabPage();
            this.cmbFilterField = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtFields = new System.Windows.Forms.TextBox();
            this.tpContentTypes = new System.Windows.Forms.TabPage();
            this.cmbFilterContentType = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtContentTypes = new System.Windows.Forms.TextBox();
            this.tpInfo = new System.Windows.Forms.TabPage();
            this.txtItemCount = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.chkDefaultView = new System.Windows.Forms.CheckBox();
            this.chkHiddenView = new System.Windows.Forms.CheckBox();
            this.chkPersonalView = new System.Windows.Forms.CheckBox();
            this.txtCreated = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtListTitle = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtViewName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtViewID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtListName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtListID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tpResults = new System.Windows.Forms.TabPage();
            this.dgResults = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnResultsRefresh = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.txtResultsNumber = new System.Windows.Forms.TextBox();
            this.tpRandomGuid = new System.Windows.Forms.TabPage();
            this.txtRandomGuid = new System.Windows.Forms.TextBox();
            this.btnRandomGuid = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbLists = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbViews = new System.Windows.Forms.ComboBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblWait = new System.Windows.Forms.Label();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.btnCopy = new System.Windows.Forms.Button();
            this.chkTryFindWebUrl = new System.Windows.Forms.CheckBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.chkLoginOnline = new System.Windows.Forms.CheckBox();
            this.tabControl1.SuspendLayout();
            this.tpCaml.SuspendLayout();
            this.tpCSharp.SuspendLayout();
            this.tpListData.SuspendLayout();
            this.tpViewData.SuspendLayout();
            this.tpFields.SuspendLayout();
            this.tpContentTypes.SuspendLayout();
            this.tpInfo.SuspendLayout();
            this.tpResults.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgResults)).BeginInit();
            this.panel1.SuspendLayout();
            this.tpRandomGuid.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 200;
            this.label1.Text = "Web url:";
            // 
            // txtUrl
            // 
            this.txtUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUrl.Location = new System.Drawing.Point(57, 6);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(418, 20);
            this.txtUrl.TabIndex = 0;
            this.txtUrl.Text = "http://";
            this.toolTip1.SetToolTip(this.txtUrl, "insert the web site url");
            this.txtUrl.TextChanged += new System.EventHandler(this.txtUrl_TextChanged);
            // 
            // btnConnect
            // 
            this.btnConnect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConnect.Location = new System.Drawing.Point(507, 2);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(96, 26);
            this.btnConnect.TabIndex = 5;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tpCaml);
            this.tabControl1.Controls.Add(this.tpCSharp);
            this.tabControl1.Controls.Add(this.tpListData);
            this.tabControl1.Controls.Add(this.tpViewData);
            this.tabControl1.Controls.Add(this.tpFields);
            this.tabControl1.Controls.Add(this.tpContentTypes);
            this.tabControl1.Controls.Add(this.tpInfo);
            this.tabControl1.Controls.Add(this.tpResults);
            this.tabControl1.Controls.Add(this.tpRandomGuid);
            this.tabControl1.Location = new System.Drawing.Point(0, 80);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(607, 276);
            this.tabControl1.TabIndex = 20;
            // 
            // tpCaml
            // 
            this.tpCaml.Controls.Add(this.lblViewName);
            this.tpCaml.Controls.Add(this.txtCaml);
            this.tpCaml.Location = new System.Drawing.Point(4, 22);
            this.tpCaml.Name = "tpCaml";
            this.tpCaml.Padding = new System.Windows.Forms.Padding(3);
            this.tpCaml.Size = new System.Drawing.Size(599, 250);
            this.tpCaml.TabIndex = 0;
            this.tpCaml.Text = "CAML";
            this.toolTip1.SetToolTip(this.tpCaml, "Query CAML");
            this.tpCaml.UseVisualStyleBackColor = true;
            // 
            // lblViewName
            // 
            this.lblViewName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblViewName.Location = new System.Drawing.Point(3, 3);
            this.lblViewName.Name = "lblViewName";
            this.lblViewName.Size = new System.Drawing.Size(593, 13);
            this.lblViewName.TabIndex = 22;
            this.lblViewName.Text = "-";
            // 
            // txtCaml
            // 
            this.txtCaml.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCaml.Font = new System.Drawing.Font("Courier New", 8.25F);
            this.txtCaml.Location = new System.Drawing.Point(3, 19);
            this.txtCaml.Multiline = true;
            this.txtCaml.Name = "txtCaml";
            this.txtCaml.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtCaml.Size = new System.Drawing.Size(596, 228);
            this.txtCaml.TabIndex = 22;
            // 
            // tpCSharp
            // 
            this.tpCSharp.Controls.Add(this.txtCSharp);
            this.tpCSharp.Location = new System.Drawing.Point(4, 22);
            this.tpCSharp.Name = "tpCSharp";
            this.tpCSharp.Padding = new System.Windows.Forms.Padding(3);
            this.tpCSharp.Size = new System.Drawing.Size(599, 250);
            this.tpCSharp.TabIndex = 1;
            this.tpCSharp.Text = "C#";
            this.tpCSharp.ToolTipText = "Generate code to query list with view query";
            this.tpCSharp.UseVisualStyleBackColor = true;
            // 
            // txtCSharp
            // 
            this.txtCSharp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCSharp.Font = new System.Drawing.Font("Courier New", 8.25F);
            this.txtCSharp.Location = new System.Drawing.Point(3, 3);
            this.txtCSharp.Multiline = true;
            this.txtCSharp.Name = "txtCSharp";
            this.txtCSharp.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtCSharp.Size = new System.Drawing.Size(593, 244);
            this.txtCSharp.TabIndex = 23;
            // 
            // tpListData
            // 
            this.tpListData.Controls.Add(this.txtListData);
            this.tpListData.Location = new System.Drawing.Point(4, 22);
            this.tpListData.Name = "tpListData";
            this.tpListData.Padding = new System.Windows.Forms.Padding(3);
            this.tpListData.Size = new System.Drawing.Size(599, 250);
            this.tpListData.TabIndex = 8;
            this.tpListData.Text = "List Schema";
            this.tpListData.ToolTipText = "Schema XML of selected list";
            this.tpListData.UseVisualStyleBackColor = true;
            // 
            // txtListData
            // 
            this.txtListData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtListData.Location = new System.Drawing.Point(3, 3);
            this.txtListData.Multiline = true;
            this.txtListData.Name = "txtListData";
            this.txtListData.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtListData.Size = new System.Drawing.Size(593, 244);
            this.txtListData.TabIndex = 0;
            // 
            // tpViewData
            // 
            this.tpViewData.Controls.Add(this.txtViewData);
            this.tpViewData.Location = new System.Drawing.Point(4, 22);
            this.tpViewData.Name = "tpViewData";
            this.tpViewData.Padding = new System.Windows.Forms.Padding(3);
            this.tpViewData.Size = new System.Drawing.Size(599, 250);
            this.tpViewData.TabIndex = 2;
            this.tpViewData.Text = "View Schema";
            this.tpViewData.ToolTipText = "Schema XML of selected view";
            this.tpViewData.UseVisualStyleBackColor = true;
            // 
            // txtViewData
            // 
            this.txtViewData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtViewData.Font = new System.Drawing.Font("Courier New", 8.25F);
            this.txtViewData.Location = new System.Drawing.Point(3, 3);
            this.txtViewData.Multiline = true;
            this.txtViewData.Name = "txtViewData";
            this.txtViewData.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtViewData.Size = new System.Drawing.Size(593, 244);
            this.txtViewData.TabIndex = 24;
            // 
            // tpFields
            // 
            this.tpFields.Controls.Add(this.cmbFilterField);
            this.tpFields.Controls.Add(this.label12);
            this.tpFields.Controls.Add(this.txtFields);
            this.tpFields.Location = new System.Drawing.Point(4, 22);
            this.tpFields.Name = "tpFields";
            this.tpFields.Size = new System.Drawing.Size(599, 250);
            this.tpFields.TabIndex = 3;
            this.tpFields.Text = "List Fields";
            this.tpFields.ToolTipText = "All felds in the list";
            this.tpFields.UseVisualStyleBackColor = true;
            // 
            // cmbFilterField
            // 
            this.cmbFilterField.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbFilterField.FormattingEnabled = true;
            this.cmbFilterField.Location = new System.Drawing.Point(77, 4);
            this.cmbFilterField.Name = "cmbFilterField";
            this.cmbFilterField.Size = new System.Drawing.Size(261, 21);
            this.cmbFilterField.TabIndex = 26;
            this.cmbFilterField.SelectedIndexChanged += new System.EventHandler(this.cmbFilterField_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 7);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "Filter field:";
            // 
            // txtFields
            // 
            this.txtFields.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFields.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFields.Location = new System.Drawing.Point(0, 31);
            this.txtFields.Multiline = true;
            this.txtFields.Name = "txtFields";
            this.txtFields.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtFields.Size = new System.Drawing.Size(599, 219);
            this.txtFields.TabIndex = 27;
            // 
            // tpContentTypes
            // 
            this.tpContentTypes.Controls.Add(this.cmbFilterContentType);
            this.tpContentTypes.Controls.Add(this.label14);
            this.tpContentTypes.Controls.Add(this.txtContentTypes);
            this.tpContentTypes.Location = new System.Drawing.Point(4, 22);
            this.tpContentTypes.Name = "tpContentTypes";
            this.tpContentTypes.Padding = new System.Windows.Forms.Padding(3);
            this.tpContentTypes.Size = new System.Drawing.Size(599, 250);
            this.tpContentTypes.TabIndex = 7;
            this.tpContentTypes.Text = "Content Types";
            this.tpContentTypes.ToolTipText = "All content types in the list";
            this.tpContentTypes.UseVisualStyleBackColor = true;
            // 
            // cmbFilterContentType
            // 
            this.cmbFilterContentType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbFilterContentType.FormattingEnabled = true;
            this.cmbFilterContentType.Location = new System.Drawing.Point(77, 4);
            this.cmbFilterContentType.Name = "cmbFilterContentType";
            this.cmbFilterContentType.Size = new System.Drawing.Size(261, 21);
            this.cmbFilterContentType.TabIndex = 30;
            this.cmbFilterContentType.SelectedIndexChanged += new System.EventHandler(this.cmbFilterContentType_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(8, 7);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(70, 13);
            this.label14.TabIndex = 29;
            this.label14.Text = "Content type:";
            // 
            // txtContentTypes
            // 
            this.txtContentTypes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtContentTypes.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContentTypes.Location = new System.Drawing.Point(0, 31);
            this.txtContentTypes.Multiline = true;
            this.txtContentTypes.Name = "txtContentTypes";
            this.txtContentTypes.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtContentTypes.Size = new System.Drawing.Size(599, 219);
            this.txtContentTypes.TabIndex = 28;
            // 
            // tpInfo
            // 
            this.tpInfo.Controls.Add(this.txtItemCount);
            this.tpInfo.Controls.Add(this.label15);
            this.tpInfo.Controls.Add(this.chkDefaultView);
            this.tpInfo.Controls.Add(this.chkHiddenView);
            this.tpInfo.Controls.Add(this.chkPersonalView);
            this.tpInfo.Controls.Add(this.txtCreated);
            this.tpInfo.Controls.Add(this.label11);
            this.tpInfo.Controls.Add(this.txtListTitle);
            this.tpInfo.Controls.Add(this.label10);
            this.tpInfo.Controls.Add(this.txtViewName);
            this.tpInfo.Controls.Add(this.label9);
            this.tpInfo.Controls.Add(this.txtViewID);
            this.tpInfo.Controls.Add(this.label8);
            this.tpInfo.Controls.Add(this.txtListName);
            this.tpInfo.Controls.Add(this.label7);
            this.tpInfo.Controls.Add(this.txtListID);
            this.tpInfo.Controls.Add(this.label6);
            this.tpInfo.Location = new System.Drawing.Point(4, 22);
            this.tpInfo.Name = "tpInfo";
            this.tpInfo.Size = new System.Drawing.Size(599, 250);
            this.tpInfo.TabIndex = 4;
            this.tpInfo.Text = "Info";
            this.tpInfo.UseVisualStyleBackColor = true;
            // 
            // txtItemCount
            // 
            this.txtItemCount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtItemCount.Location = new System.Drawing.Point(70, 113);
            this.txtItemCount.Name = "txtItemCount";
            this.txtItemCount.ReadOnly = true;
            this.txtItemCount.Size = new System.Drawing.Size(520, 20);
            this.txtItemCount.TabIndex = 44;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(3, 116);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(60, 13);
            this.label15.TabIndex = 43;
            this.label15.Text = "Item count:";
            // 
            // chkDefaultView
            // 
            this.chkDefaultView.AutoSize = true;
            this.chkDefaultView.Enabled = false;
            this.chkDefaultView.Location = new System.Drawing.Point(70, 192);
            this.chkDefaultView.Name = "chkDefaultView";
            this.chkDefaultView.Size = new System.Drawing.Size(85, 17);
            this.chkDefaultView.TabIndex = 40;
            this.chkDefaultView.Text = "Default view";
            this.chkDefaultView.UseVisualStyleBackColor = true;
            // 
            // chkHiddenView
            // 
            this.chkHiddenView.AutoSize = true;
            this.chkHiddenView.Enabled = false;
            this.chkHiddenView.Location = new System.Drawing.Point(161, 192);
            this.chkHiddenView.Name = "chkHiddenView";
            this.chkHiddenView.Size = new System.Drawing.Size(85, 17);
            this.chkHiddenView.TabIndex = 41;
            this.chkHiddenView.Text = "Hidden view";
            this.chkHiddenView.UseVisualStyleBackColor = true;
            // 
            // chkPersonalView
            // 
            this.chkPersonalView.AutoSize = true;
            this.chkPersonalView.Enabled = false;
            this.chkPersonalView.Location = new System.Drawing.Point(252, 192);
            this.chkPersonalView.Name = "chkPersonalView";
            this.chkPersonalView.Size = new System.Drawing.Size(92, 17);
            this.chkPersonalView.TabIndex = 42;
            this.chkPersonalView.Text = "Personal view";
            this.chkPersonalView.UseVisualStyleBackColor = true;
            // 
            // txtCreated
            // 
            this.txtCreated.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCreated.Location = new System.Drawing.Point(70, 87);
            this.txtCreated.Name = "txtCreated";
            this.txtCreated.ReadOnly = true;
            this.txtCreated.Size = new System.Drawing.Size(520, 20);
            this.txtCreated.TabIndex = 35;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 90);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 13);
            this.label11.TabIndex = 34;
            this.label11.Text = "Created:";
            // 
            // txtListTitle
            // 
            this.txtListTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtListTitle.Location = new System.Drawing.Point(70, 61);
            this.txtListTitle.Name = "txtListTitle";
            this.txtListTitle.ReadOnly = true;
            this.txtListTitle.Size = new System.Drawing.Size(520, 20);
            this.txtListTitle.TabIndex = 33;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 64);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 13);
            this.label10.TabIndex = 32;
            this.label10.Text = "List Title:";
            // 
            // txtViewName
            // 
            this.txtViewName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtViewName.Location = new System.Drawing.Point(70, 165);
            this.txtViewName.Name = "txtViewName";
            this.txtViewName.ReadOnly = true;
            this.txtViewName.Size = new System.Drawing.Size(520, 20);
            this.txtViewName.TabIndex = 39;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 168);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 13);
            this.label9.TabIndex = 38;
            this.label9.Text = "View Name:";
            // 
            // txtViewID
            // 
            this.txtViewID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtViewID.Location = new System.Drawing.Point(70, 139);
            this.txtViewID.Name = "txtViewID";
            this.txtViewID.ReadOnly = true;
            this.txtViewID.Size = new System.Drawing.Size(520, 20);
            this.txtViewID.TabIndex = 37;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 142);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 36;
            this.label8.Text = "View ID:";
            // 
            // txtListName
            // 
            this.txtListName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtListName.Location = new System.Drawing.Point(70, 35);
            this.txtListName.Name = "txtListName";
            this.txtListName.ReadOnly = true;
            this.txtListName.Size = new System.Drawing.Size(520, 20);
            this.txtListName.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "List Name:";
            // 
            // txtListID
            // 
            this.txtListID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtListID.Location = new System.Drawing.Point(70, 9);
            this.txtListID.Name = "txtListID";
            this.txtListID.ReadOnly = true;
            this.txtListID.Size = new System.Drawing.Size(520, 20);
            this.txtListID.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "List ID:";
            // 
            // tpResults
            // 
            this.tpResults.Controls.Add(this.dgResults);
            this.tpResults.Controls.Add(this.panel1);
            this.tpResults.Location = new System.Drawing.Point(4, 22);
            this.tpResults.Name = "tpResults";
            this.tpResults.Padding = new System.Windows.Forms.Padding(3);
            this.tpResults.Size = new System.Drawing.Size(599, 250);
            this.tpResults.TabIndex = 6;
            this.tpResults.Text = "Results";
            this.tpResults.UseVisualStyleBackColor = true;
            // 
            // dgResults
            // 
            this.dgResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgResults.Location = new System.Drawing.Point(3, 37);
            this.dgResults.Name = "dgResults";
            this.dgResults.ReadOnly = true;
            this.dgResults.Size = new System.Drawing.Size(593, 210);
            this.dgResults.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.btnResultsRefresh);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.txtResultsNumber);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(593, 27);
            this.panel1.TabIndex = 2;
            // 
            // btnResultsRefresh
            // 
            this.btnResultsRefresh.Location = new System.Drawing.Point(155, 1);
            this.btnResultsRefresh.Name = "btnResultsRefresh";
            this.btnResultsRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnResultsRefresh.TabIndex = 2;
            this.btnResultsRefresh.Text = "Refresh";
            this.btnResultsRefresh.UseVisualStyleBackColor = true;
            this.btnResultsRefresh.Click += new System.EventHandler(this.btnResultsRefresh_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(8, 6);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(63, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "Max results:";
            // 
            // txtResultsNumber
            // 
            this.txtResultsNumber.Location = new System.Drawing.Point(77, 3);
            this.txtResultsNumber.Name = "txtResultsNumber";
            this.txtResultsNumber.Size = new System.Drawing.Size(72, 20);
            this.txtResultsNumber.TabIndex = 1;
            this.txtResultsNumber.Text = "30";
            this.txtResultsNumber.Leave += new System.EventHandler(this.txtResultsNumber_Leave);
            // 
            // tpRandomGuid
            // 
            this.tpRandomGuid.Controls.Add(this.txtRandomGuid);
            this.tpRandomGuid.Controls.Add(this.btnRandomGuid);
            this.tpRandomGuid.Location = new System.Drawing.Point(4, 22);
            this.tpRandomGuid.Name = "tpRandomGuid";
            this.tpRandomGuid.Size = new System.Drawing.Size(599, 250);
            this.tpRandomGuid.TabIndex = 5;
            this.tpRandomGuid.Text = "Random Guid";
            this.tpRandomGuid.UseVisualStyleBackColor = true;
            // 
            // txtRandomGuid
            // 
            this.txtRandomGuid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRandomGuid.Location = new System.Drawing.Point(6, 3);
            this.txtRandomGuid.Multiline = true;
            this.txtRandomGuid.Name = "txtRandomGuid";
            this.txtRandomGuid.ReadOnly = true;
            this.txtRandomGuid.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtRandomGuid.Size = new System.Drawing.Size(465, 244);
            this.txtRandomGuid.TabIndex = 43;
            // 
            // btnRandomGuid
            // 
            this.btnRandomGuid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRandomGuid.Location = new System.Drawing.Point(515, 3);
            this.btnRandomGuid.Name = "btnRandomGuid";
            this.btnRandomGuid.Size = new System.Drawing.Size(75, 23);
            this.btnRandomGuid.TabIndex = 44;
            this.btnRandomGuid.Text = "Refresh";
            this.btnRandomGuid.UseVisualStyleBackColor = true;
            this.btnRandomGuid.Click += new System.EventHandler(this.btnRandomGuid_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 203;
            this.label2.Text = "List:";
            // 
            // cmbLists
            // 
            this.cmbLists.FormattingEnabled = true;
            this.cmbLists.Location = new System.Drawing.Point(57, 53);
            this.cmbLists.Name = "cmbLists";
            this.cmbLists.Size = new System.Drawing.Size(200, 21);
            this.cmbLists.TabIndex = 6;
            this.toolTip1.SetToolTip(this.cmbLists, "choose list");
            this.cmbLists.SelectedIndexChanged += new System.EventHandler(this.cmbLists_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(264, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 204;
            this.label3.Text = "View:";
            // 
            // cmbViews
            // 
            this.cmbViews.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbViews.FormattingEnabled = true;
            this.cmbViews.Location = new System.Drawing.Point(303, 53);
            this.cmbViews.Name = "cmbViews";
            this.cmbViews.Size = new System.Drawing.Size(172, 21);
            this.cmbViews.TabIndex = 7;
            this.toolTip1.SetToolTip(this.cmbViews, "choose view");
            this.cmbViews.SelectedIndexChanged += new System.EventHandler(this.cmbViews_SelectedIndexChanged);
            // 
            // linkLabel1
            // 
            this.linkLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(507, 36);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(96, 13);
            this.linkLabel1.TabIndex = 9;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "http://www.sgart.it";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 201;
            this.label4.Text = "User:";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(58, 29);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(154, 20);
            this.txtUser.TabIndex = 2;
            this.toolTip1.SetToolTip(this.txtUser, "insert username");
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(218, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 201;
            this.label5.Text = "Password:";
            // 
            // lblWait
            // 
            this.lblWait.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWait.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblWait.Location = new System.Drawing.Point(481, 53);
            this.lblWait.Name = "lblWait";
            this.lblWait.Size = new System.Drawing.Size(119, 21);
            this.lblWait.TabIndex = 100;
            this.lblWait.Text = "Wait...";
            this.lblWait.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblWait.Visible = false;
            // 
            // txtPwd
            // 
            this.txtPwd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPwd.Location = new System.Drawing.Point(280, 29);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.PasswordChar = '*';
            this.txtPwd.Size = new System.Drawing.Size(126, 20);
            this.txtPwd.TabIndex = 3;
            this.toolTip1.SetToolTip(this.txtPwd, "insert password");
            // 
            // btnCopy
            // 
            this.btnCopy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCopy.FlatAppearance.BorderSize = 0;
            this.btnCopy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCopy.Image = ((System.Drawing.Image)(resources.GetObject("btnCopy.Image")));
            this.btnCopy.Location = new System.Drawing.Point(582, 77);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(21, 21);
            this.btnCopy.TabIndex = 21;
            this.toolTip1.SetToolTip(this.btnCopy, "Copy text");
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // chkTryFindWebUrl
            // 
            this.chkTryFindWebUrl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkTryFindWebUrl.AutoSize = true;
            this.chkTryFindWebUrl.Checked = true;
            this.chkTryFindWebUrl.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkTryFindWebUrl.Location = new System.Drawing.Point(481, 9);
            this.chkTryFindWebUrl.Name = "chkTryFindWebUrl";
            this.chkTryFindWebUrl.Size = new System.Drawing.Size(15, 14);
            this.chkTryFindWebUrl.TabIndex = 1;
            this.toolTip1.SetToolTip(this.chkTryFindWebUrl, "Try to find correct web url");
            this.chkTryFindWebUrl.UseVisualStyleBackColor = true;
            // 
            // linkLabel2
            // 
            this.linkLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabel2.Image = ((System.Drawing.Image)(resources.GetObject("linkLabel2.Image")));
            this.linkLabel2.Location = new System.Drawing.Point(480, 32);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(21, 21);
            this.linkLabel2.TabIndex = 17;
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(481, 71);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(119, 10);
            this.progressBar1.TabIndex = 205;
            // 
            // chkLoginOnline
            // 
            this.chkLoginOnline.AutoSize = true;
            this.chkLoginOnline.Location = new System.Drawing.Point(416, 31);
            this.chkLoginOnline.Name = "chkLoginOnline";
            this.chkLoginOnline.Size = new System.Drawing.Size(56, 17);
            this.chkLoginOnline.TabIndex = 4;
            this.chkLoginOnline.Text = "Online";
            this.toolTip1.SetToolTip(this.chkLoginOnline, "Use login to SharePoint Online");
            this.chkLoginOnline.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnConnect;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 356);
            this.Controls.Add(this.chkLoginOnline);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.lblWait);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.chkTryFindWebUrl);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.txtPwd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.cmbViews);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbLists);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.txtUrl);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(500, 300);
            this.Name = "Form1";
            this.Text = "SgartSPQueryViewer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tpCaml.ResumeLayout(false);
            this.tpCaml.PerformLayout();
            this.tpCSharp.ResumeLayout(false);
            this.tpCSharp.PerformLayout();
            this.tpListData.ResumeLayout(false);
            this.tpListData.PerformLayout();
            this.tpViewData.ResumeLayout(false);
            this.tpViewData.PerformLayout();
            this.tpFields.ResumeLayout(false);
            this.tpFields.PerformLayout();
            this.tpContentTypes.ResumeLayout(false);
            this.tpContentTypes.PerformLayout();
            this.tpInfo.ResumeLayout(false);
            this.tpInfo.PerformLayout();
            this.tpResults.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgResults)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tpRandomGuid.ResumeLayout(false);
            this.tpRandomGuid.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox txtUrl;
    private System.Windows.Forms.Button btnConnect;
    private System.Windows.Forms.TabControl tabControl1;
    private System.Windows.Forms.TabPage tpCaml;
    private System.Windows.Forms.TabPage tpCSharp;
    private System.Windows.Forms.TextBox txtCSharp;
    private System.Windows.Forms.TextBox txtCaml;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.ComboBox cmbLists;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.ComboBox cmbViews;
    private System.Windows.Forms.LinkLabel linkLabel1;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TextBox txtUser;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.TabPage tpViewData;
    private System.Windows.Forms.TextBox txtViewData;
    private System.Windows.Forms.Label lblWait;
    private System.Windows.Forms.TextBox txtPwd;
    private System.Windows.Forms.Label lblViewName;
    private System.Windows.Forms.TabPage tpFields;
    private System.Windows.Forms.TextBox txtFields;
    private System.Windows.Forms.Button btnCopy;
    private System.Windows.Forms.CheckBox chkTryFindWebUrl;
    private System.Windows.Forms.ToolTip toolTip1;
    private System.Windows.Forms.LinkLabel linkLabel2;
    private System.Windows.Forms.TabPage tpInfo;
    private System.Windows.Forms.TextBox txtListName;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.TextBox txtListID;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.TextBox txtViewName;
    private System.Windows.Forms.Label label9;
    private System.Windows.Forms.TextBox txtViewID;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.TextBox txtCreated;
    private System.Windows.Forms.Label label11;
    private System.Windows.Forms.TextBox txtListTitle;
    private System.Windows.Forms.Label label10;
    private System.Windows.Forms.CheckBox chkHiddenView;
    private System.Windows.Forms.CheckBox chkPersonalView;
    private System.Windows.Forms.CheckBox chkDefaultView;
    private System.Windows.Forms.ComboBox cmbFilterField;
    private System.Windows.Forms.Label label12;
    private System.Windows.Forms.TabPage tpRandomGuid;
    private System.Windows.Forms.TextBox txtRandomGuid;
    private System.Windows.Forms.Button btnRandomGuid;
    private System.Windows.Forms.TabPage tpResults;
    private System.Windows.Forms.DataGridView dgResults;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Label label13;
    private System.Windows.Forms.TextBox txtResultsNumber;
    private System.Windows.Forms.Button btnResultsRefresh;
    private System.Windows.Forms.TabPage tpContentTypes;
    private System.Windows.Forms.TextBox txtContentTypes;
    private System.Windows.Forms.ComboBox cmbFilterContentType;
    private System.Windows.Forms.Label label14;
    private System.Windows.Forms.ProgressBar progressBar1;
    private System.Windows.Forms.TabPage tpListData;
    private System.Windows.Forms.TextBox txtListData;
    private System.Windows.Forms.TextBox txtItemCount;
    private System.Windows.Forms.Label label15;
    private System.Windows.Forms.CheckBox chkLoginOnline;
  }
}


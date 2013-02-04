using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SgartSPQueryViewer
{
    public partial class ProxyCredentialRequest : Form
    {

        public ProxyCredentialRequest()
        {
            InitializeComponent();
        }

        public string ProxyUrl { get; set; }
        public string ProxyUser { get; set; }
        public string ProxyPwd { get; set; }

        private void ProxyCredential_Load(object sender, EventArgs e)
        {
            txtUrl.Text = this.ProxyUrl;
            txtUser.Text = this.ProxyUser;
            txtPwd.Text = this.ProxyPwd;

            btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }


        private void btnOk_Click(object sender, EventArgs e)
        {
            this.ProxyUser = txtUser.Text;
            this.ProxyPwd = txtPwd.Text;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}

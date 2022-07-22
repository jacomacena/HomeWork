using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeWork
{
    public partial class findEndpoint : UserControl
    {
        public findEndpoint()
        {
            InitializeComponent();
            lblFoundedSN.Text = String.Empty;
            lblfoundedMMI.Text = String.Empty;
            lblfoundedMN.Text = String.Empty;
            lblfoundedMFV.Text = String.Empty;
            lblfoundedSS.Text = String.Empty;

            labelSN.Visible = false;
            labelMMI.Visible = false;
            labelMN.Visible = false;
            labelMFV.Visible = false;
            labelSS.Visible = false;
            lblFoundedSN.Visible = false;
            lblfoundedMMI.Visible = false;
            lblfoundedMN.Visible = false;
            lblfoundedMFV.Visible = false;
            lblfoundedSS.Visible = false;

        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            findDataFromTheFrom();
        }
    }
}

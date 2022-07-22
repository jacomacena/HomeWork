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
    public partial class deleteEndpoint : UserControl
    {
        public deleteEndpoint()
        {
            InitializeComponent();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            deleteDataFromTheForm();
        }
    }
}

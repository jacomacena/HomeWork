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
    public partial class listEndpoint : UserControl
    {
        public listEndpoint()
        {
            InitializeComponent();
        }

        
        private void listEndpoint_Load(object sender, EventArgs e)
        {
            ListAll();
        }
    }
}

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
    public partial class modelListEndpoint : UserControl
    {
        public modelListEndpoint()
        {
            InitializeComponent();
        }

        private string itemSN;
        private string itemMMI;
        private string itemMN;
        private string itemMFV;
        private string itemSS;

        [Category("Custom Props")]
        public string ItemSN { get { return itemSN; } set { itemSN = value; lstSN.Text = value; } }
        
        [Category("Custom Props")]
        public string ItemMMI { get { return itemMMI; } set {itemMFV = value; lstMMI.Text = value; } }
        
        [Category("Custom Props")]
        public string ItemMN { get { return itemMN; } set { itemMN = value; lstMN.Text = value; } }
        
        [Category("Custom Props")]
        public string ItemMFV { get { return itemMFV; } set { itemMFV = value; lstMFV.Text = value; } }
        
        [Category("Custom Props")]
        public string ItemSS { get { return itemSS; } set { itemSS = value; lstSS.Text = value; } }
    }
}


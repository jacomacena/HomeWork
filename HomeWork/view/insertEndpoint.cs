﻿namespace HomeWork
{
    public partial class insertEndpoint : UserControl
    {
        public insertEndpoint()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                insertDataFromTheForm();
            }
            catch (IOException x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            insertDataFromTheForm();
            inputSN.Text = String.Empty;
            inputMMI.Text = String.Empty;
            inputMN.Text = String.Empty;
            inputMFV.Text = String.Empty;
            inputSS.Text = String.Empty;
        }
    }
}

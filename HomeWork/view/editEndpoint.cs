namespace HomeWork
{
    public partial class editEndpoint : UserControl
    {
        public editEndpoint()
        {
            InitializeComponent();
            lblEditSN.Visible = false;
            lblEditMMI.Visible = false;
            lblEditMN.Visible = false;
            lblEditMFV.Visible = false;
            txtSS.Visible = false;
            lblFoundSN.Visible = false;
            lblFoundMMI.Visible = false;
            lblFoundMN.Visible = false;
            lblFoundMFV.Visible = false;
            lblFoundSS.Visible = false;
            btnEdit.Visible = false;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            searchEdit();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            editDataFromTheForm();
        }
    }
}

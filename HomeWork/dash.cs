namespace HomeWork{

    public partial class dash : Form{

        insertEndpoint insertEndpoint = new insertEndpoint();
        editEndpoint editEndpoint = new editEndpoint();
        deleteEndpoint deleteEndpoint = new deleteEndpoint();
        findEndpoint findEndpoint = new findEndpoint();
        listEndpoint listEndpoint = new listEndpoint();
        
        public dash(){
            InitializeComponent();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e){

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e){

        }

        private void insertButton_Click(object sender, EventArgs e){
            splitContainer1.Panel2.Controls.Add(insertEndpoint);
            splitContainer1.Panel2.Controls.Remove(editEndpoint);
            splitContainer1.Panel2.Controls.Remove(deleteEndpoint);
            splitContainer1.Panel2.Controls.Remove(findEndpoint);
            splitContainer1.Panel2.Controls.Remove(listEndpoint);
            
        }

        private void editButton_Click(object sender, EventArgs e){
            splitContainer1.Panel2.Controls.Remove(insertEndpoint);
            splitContainer1.Panel2.Controls.Add(editEndpoint);
            splitContainer1.Panel2.Controls.Remove(deleteEndpoint);
            splitContainer1.Panel2.Controls.Remove(findEndpoint);
            splitContainer1.Panel2.Controls.Remove(listEndpoint);
            
        }

        private void deletButton_Click(object sender, EventArgs e){
            splitContainer1.Panel2.Controls.Remove(insertEndpoint);
            splitContainer1.Panel2.Controls.Remove(editEndpoint);
            splitContainer1.Panel2.Controls.Add(deleteEndpoint);
            splitContainer1.Panel2.Controls.Remove(findEndpoint);
            splitContainer1.Panel2.Controls.Remove(listEndpoint);
            
        }

        private void listButton_Click(object sender, EventArgs e){
            splitContainer1.Panel2.Controls.Remove(insertEndpoint);
            splitContainer1.Panel2.Controls.Remove(editEndpoint);
            splitContainer1.Panel2.Controls.Remove(deleteEndpoint);
            splitContainer1.Panel2.Controls.Remove(findEndpoint);
            splitContainer1.Panel2.Controls.Add(listEndpoint);
        }

        private void findButton_Click(object sender, EventArgs e){
            splitContainer1.Panel2.Controls.Remove(insertEndpoint);
            splitContainer1.Panel2.Controls.Remove(editEndpoint);
            splitContainer1.Panel2.Controls.Remove(deleteEndpoint);
            splitContainer1.Panel2.Controls.Add(findEndpoint);
            splitContainer1.Panel2.Controls.Remove(listEndpoint);

        }

        private void exitButton_Click(object sender, EventArgs e){
            if (MessageBox.Show("Is sure?", "EXIT", MessageBoxButtons.YesNo) == DialogResult.Yes)
                this.Close();
        }
    }
}
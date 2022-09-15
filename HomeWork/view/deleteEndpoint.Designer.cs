namespace HomeWork
{
    partial class deleteEndpoint
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        FEndpoint fendpoint = new FEndpoint();
        
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

        private void deleteDataFromTheForm() {
            // get input
            string delSN = txtDelSN.Text;

            if (String.IsNullOrEmpty(delSN)) {
                MessageBox.Show("Serial Number cannot be empty", "ALERT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else {
                
                bool deleteSucefully = fendpoint.validDelete(delSN);

                if (!deleteSucefully)
                {
                    MessageBox.Show("Serial Number was not found", "ALERT", MessageBoxButtons.OK);
                }
                else
                {
                    if (MessageBox.Show("Delete Endpoint: " + delSN + "?", "DELETE", MessageBoxButtons.YesNoCancel) == DialogResult.Yes)
                    {
                        fendpoint.Delete(delSN);
                        MessageBox.Show("Endpoint deleted");
                    }
                }
            }

            



        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblDelete = new System.Windows.Forms.Label();
            this.txtDelSN = new System.Windows.Forms.TextBox();
            this.btnDel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDelete
            // 
            this.lblDelete.AutoSize = true;
            this.lblDelete.Location = new System.Drawing.Point(30, 34);
            this.lblDelete.Name = "lblDelete";
            this.lblDelete.Size = new System.Drawing.Size(242, 15);
            this.lblDelete.TabIndex = 0;
            this.lblDelete.Text = "Which Serial Number do you want to delete?";
            // 
            // txtDelSN
            // 
            this.txtDelSN.Location = new System.Drawing.Point(30, 66);
            this.txtDelSN.Name = "txtDelSN";
            this.txtDelSN.Size = new System.Drawing.Size(193, 23);
            this.txtDelSN.TabIndex = 1;
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(244, 66);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 23);
            this.btnDel.TabIndex = 2;
            this.btnDel.Text = "Delete";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // deleteEndpoint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.txtDelSN);
            this.Controls.Add(this.lblDelete);
            this.Name = "deleteEndpoint";
            this.Size = new System.Drawing.Size(365, 239);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblDelete;
        private TextBox txtDelSN;
        private Button btnDel;
    }
}

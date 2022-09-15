namespace HomeWork
{
    partial class editEndpoint
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        FEndpoint fendpoint = new FEndpoint();
        Endpoint tempEndpoint = new Endpoint();

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

        private void viewTxtLabel(int a)
        {
            if (a == 0)
            {
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
            else {
                lblEditSN.Visible = true;
                lblEditMMI.Visible = true;
                lblEditMN.Visible = true;
                lblEditMFV.Visible = true;
                txtSS.Visible = true;
                lblFoundSN.Visible = true;
                lblFoundMMI.Visible = true;
                lblFoundMN.Visible = true;
                lblFoundMFV.Visible = true;
                lblFoundSS.Visible = true;
                btnEdit.Visible = true;
            }
        }

        private void searchEdit()
        {
            // get input
            string searchEdit = txtSN.Text;


            if (String.IsNullOrEmpty(searchEdit))
            {
                MessageBox.Show("Serial Number cannot be empty", "ALERT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                tempEndpoint = fendpoint.Find(searchEdit);
                if (tempEndpoint == null)
                {
                    MessageBox.Show("Serial Number was not found!", "ALERT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else {
                    lblEditSN.Text = tempEndpoint.SerialNumber;
                    lblEditMMI.Text = Convert.ToString(tempEndpoint.MeterModelID);
                    lblEditMN.Text = Convert.ToString(tempEndpoint.MeterNumber);
                    lblEditMFV.Text = tempEndpoint.MeterFirmwareVersion;

                    this.Controls.Add(lblEditSN);
                    this.Controls.Add(lblEditMMI);
                    this.Controls.Add(lblEditMN);
                    this.Controls.Add(lblEditMFV);

                    viewTxtLabel(1);
                }
            }            
        }

        private void editDataFromTheForm() {
            
            //get input
            string inputSS = txtSS.Text;
            int ss = Convert.ToInt32(inputSS);

            if (String.IsNullOrEmpty(inputSS)) {
                MessageBox.Show("Switch State cannot be empty", "ALERT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (ss == 0 || ss == 1 || ss == 2)
            {
                tempEndpoint.SwitchState = ss;
                fendpoint.Edit(tempEndpoint);
                MessageBox.Show("Endpoint updated!", "SUCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSN.Text = String.Empty;
                txtSS.Text = String.Empty;
                viewTxtLabel(0);
            }
            else {
                MessageBox.Show(
                            "Invalid Switch State. Avaliable options:\n" +
                            "0 - For Disconnected\n" +
                            "1 - For Connected\n" +
                            "2 - For Armed\n",
                            "ALERT",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        
        }
        #region Component Designer generated code

        private void setTextLabelSerialFounded(String serialNumber) {
            lblFoundSN.Text = serialNumber;
        }
        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblQ = new System.Windows.Forms.Label();
            this.lblFoundSS = new System.Windows.Forms.Label();
            this.lblFoundMFV = new System.Windows.Forms.Label();
            this.lblFoundMN = new System.Windows.Forms.Label();
            this.lblFoundMMI = new System.Windows.Forms.Label();
            this.lblFoundSN = new System.Windows.Forms.Label();
            this.lblEditSN = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblEditMMI = new System.Windows.Forms.Label();
            this.lblEditMN = new System.Windows.Forms.Label();
            this.lblEditMFV = new System.Windows.Forms.Label();
            this.txtSS = new System.Windows.Forms.TextBox();
            this.txtSN = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblQ
            // 
            this.lblQ.AutoSize = true;
            this.lblQ.Location = new System.Drawing.Point(22, 32);
            this.lblQ.Name = "lblQ";
            this.lblQ.Size = new System.Drawing.Size(204, 15);
            this.lblQ.TabIndex = 0;
            this.lblQ.Text = "Enter Serial Number you want to edit:";
            // 
            // lblFoundSS
            // 
            this.lblFoundSS.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblFoundSS.AutoSize = true;
            this.lblFoundSS.Location = new System.Drawing.Point(22, 293);
            this.lblFoundSS.Margin = new System.Windows.Forms.Padding(0);
            this.lblFoundSS.Name = "lblFoundSS";
            this.lblFoundSS.Size = new System.Drawing.Size(74, 15);
            this.lblFoundSS.TabIndex = 19;
            this.lblFoundSS.Text = "Switch State:";
            this.lblFoundSS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFoundMFV
            // 
            this.lblFoundMFV.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblFoundMFV.AutoSize = true;
            this.lblFoundMFV.Location = new System.Drawing.Point(22, 253);
            this.lblFoundMFV.Margin = new System.Windows.Forms.Padding(0);
            this.lblFoundMFV.Name = "lblFoundMFV";
            this.lblFoundMFV.Size = new System.Drawing.Size(134, 15);
            this.lblFoundMFV.TabIndex = 17;
            this.lblFoundMFV.Text = "Meter Firmware Version:";
            this.lblFoundMFV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFoundMN
            // 
            this.lblFoundMN.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblFoundMN.AutoSize = true;
            this.lblFoundMN.Location = new System.Drawing.Point(22, 211);
            this.lblFoundMN.Margin = new System.Windows.Forms.Padding(0);
            this.lblFoundMN.Name = "lblFoundMN";
            this.lblFoundMN.Size = new System.Drawing.Size(88, 15);
            this.lblFoundMN.TabIndex = 15;
            this.lblFoundMN.Text = "Meter Number:";
            this.lblFoundMN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFoundMMI
            // 
            this.lblFoundMMI.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblFoundMMI.AutoSize = true;
            this.lblFoundMMI.Location = new System.Drawing.Point(22, 171);
            this.lblFoundMMI.Margin = new System.Windows.Forms.Padding(0);
            this.lblFoundMMI.Name = "lblFoundMMI";
            this.lblFoundMMI.Size = new System.Drawing.Size(91, 15);
            this.lblFoundMMI.TabIndex = 13;
            this.lblFoundMMI.Text = "Meter Model Id:";
            this.lblFoundMMI.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFoundSN
            // 
            this.lblFoundSN.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblFoundSN.AutoSize = true;
            this.lblFoundSN.Location = new System.Drawing.Point(22, 132);
            this.lblFoundSN.Margin = new System.Windows.Forms.Padding(0);
            this.lblFoundSN.Name = "lblFoundSN";
            this.lblFoundSN.Size = new System.Drawing.Size(85, 15);
            this.lblFoundSN.TabIndex = 11;
            this.lblFoundSN.Text = "Serial Number:";
            this.lblFoundSN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblEditSN
            // 
            this.lblEditSN.AutoSize = true;
            this.lblEditSN.Location = new System.Drawing.Point(178, 132);
            this.lblEditSN.Name = "lblEditSN";
            this.lblEditSN.Size = new System.Drawing.Size(67, 15);
            this.lblEditSN.TabIndex = 21;
            this.lblEditSN.Text = "foundedSN";
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(119, 337);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(91, 26);
            this.btnEdit.TabIndex = 22;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(352, 63);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(62, 33);
            this.btnSearch.TabIndex = 23;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblEditMMI
            // 
            this.lblEditMMI.AutoSize = true;
            this.lblEditMMI.Location = new System.Drawing.Point(178, 171);
            this.lblEditMMI.Name = "lblEditMMI";
            this.lblEditMMI.Size = new System.Drawing.Size(77, 15);
            this.lblEditMMI.TabIndex = 24;
            this.lblEditMMI.Text = "foundedMMI";
            // 
            // lblEditMN
            // 
            this.lblEditMN.AutoSize = true;
            this.lblEditMN.Location = new System.Drawing.Point(178, 211);
            this.lblEditMN.Name = "lblEditMN";
            this.lblEditMN.Size = new System.Drawing.Size(72, 15);
            this.lblEditMN.TabIndex = 25;
            this.lblEditMN.Text = "foundedMN";
            // 
            // lblEditMFV
            // 
            this.lblEditMFV.AutoSize = true;
            this.lblEditMFV.Location = new System.Drawing.Point(178, 253);
            this.lblEditMFV.Name = "lblEditMFV";
            this.lblEditMFV.Size = new System.Drawing.Size(76, 15);
            this.lblEditMFV.TabIndex = 26;
            this.lblEditMFV.Text = "foundedMFV";
            // 
            // txtSS
            // 
            this.txtSS.Location = new System.Drawing.Point(178, 285);
            this.txtSS.Name = "txtSS";
            this.txtSS.Size = new System.Drawing.Size(100, 23);
            this.txtSS.TabIndex = 27;
            // 
            // txtSN
            // 
            this.txtSN.Location = new System.Drawing.Point(22, 69);
            this.txtSN.Name = "txtSN";
            this.txtSN.Size = new System.Drawing.Size(304, 23);
            this.txtSN.TabIndex = 28;
            // 
            // editEndpoint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtSN);
            this.Controls.Add(this.txtSS);
            this.Controls.Add(this.lblEditMFV);
            this.Controls.Add(this.lblEditMN);
            this.Controls.Add(this.lblEditMMI);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.lblEditSN);
            this.Controls.Add(this.lblFoundSS);
            this.Controls.Add(this.lblFoundMFV);
            this.Controls.Add(this.lblFoundMN);
            this.Controls.Add(this.lblFoundMMI);
            this.Controls.Add(this.lblFoundSN);
            this.Controls.Add(this.lblQ);
            this.Name = "editEndpoint";
            this.Size = new System.Drawing.Size(575, 427);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblQ;
        private Label lblFoundSS;
        private Label lblFoundMFV;
        private Label lblFoundMN;
        private Label lblFoundMMI;
        private Label lblFoundSN;
        private Label lblEditSN;

        private Button btnEdit;
        private Button btnSearch;

        private Label lblEditMMI;
        private Label lblEditMN;
        private Label lblEditMFV;
        private TextBox txtSS;
        private TextBox txtSN;
    }
}

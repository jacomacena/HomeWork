namespace HomeWork
{
    partial class findEndpoint
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

        private void findDataFromTheFrom() {
            // get Label
            string inputSerial = txtFindSN.Text;

            if (String.IsNullOrEmpty(inputSerial))
            {
                MessageBox.Show("Serial Number cannot be empty", "ALERT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
               
                if(fendpoint.theListIsEmpty())
                {
                    MessageBox.Show("List empty", "ALERT", MessageBoxButtons.OK);
                   return;
                }

                Endpoint tempEndpoint = fendpoint.Find(inputSerial);
                
                
                if (tempEndpoint == null)
                {
                    MessageBox.Show("Endpoint was not found", "ALERT", MessageBoxButtons.OK);
                    return;
                }
                else
                {
                    lblFoundedSN.Text = tempEndpoint.SerialNumber;
                    lblfoundedMMI.Text = Convert.ToString(tempEndpoint.MeterModelID);
                    lblfoundedMN.Text = Convert.ToString(tempEndpoint.MeterNumber);
                    lblfoundedMFV.Text = tempEndpoint.MeterFirmwareVersion;
                    lblfoundedSS.Text = Convert.ToString(tempEndpoint.SwitchState);

                    this.Controls.Add(lblFoundedSN);
                    this.Controls.Add(lblfoundedMMI);
                    this.Controls.Add(lblfoundedMN);
                    this.Controls.Add(lblfoundedMFV);
                    this.Controls.Add(lblfoundedSS);

                    labelSN.Visible = true;
                    labelMMI.Visible = true;
                    labelMN.Visible = true;
                    labelMFV.Visible = true;
                    labelSS.Visible = true;
                    lblFoundedSN.Visible = true;
                    lblfoundedMMI.Visible = true;
                    lblfoundedMN.Visible = true;
                    lblfoundedMFV.Visible = true;
                    lblfoundedSS.Visible = true;
                    txtFindSN.Text = String.Empty;

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
            this.lblFoundedSN = new System.Windows.Forms.Label();
            this.labelSS = new System.Windows.Forms.Label();
            this.labelMFV = new System.Windows.Forms.Label();
            this.labelMN = new System.Windows.Forms.Label();
            this.labelMMI = new System.Windows.Forms.Label();
            this.labelSN = new System.Windows.Forms.Label();
            this.txtFindSN = new System.Windows.Forms.TextBox();
            this.txtQ = new System.Windows.Forms.Label();
            this.lblfoundedMFV = new System.Windows.Forms.Label();
            this.lblfoundedMMI = new System.Windows.Forms.Label();
            this.lblfoundedMN = new System.Windows.Forms.Label();
            this.lblfoundedSS = new System.Windows.Forms.Label();
            this.btnFind = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblFoundedSN
            // 
            this.lblFoundedSN.AutoSize = true;
            this.lblFoundedSN.Location = new System.Drawing.Point(165, 124);
            this.lblFoundedSN.Name = "lblFoundedSN";
            this.lblFoundedSN.Size = new System.Drawing.Size(67, 15);
            this.lblFoundedSN.TabIndex = 33;
            this.lblFoundedSN.Text = "foundedSN";
            // 
            // labelSS
            // 
            this.labelSS.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelSS.AutoSize = true;
            this.labelSS.Location = new System.Drawing.Point(21, 285);
            this.labelSS.Margin = new System.Windows.Forms.Padding(0);
            this.labelSS.Name = "labelSS";
            this.labelSS.Size = new System.Drawing.Size(74, 15);
            this.labelSS.TabIndex = 31;
            this.labelSS.Text = "Switch State:";
            this.labelSS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelMFV
            // 
            this.labelMFV.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelMFV.AutoSize = true;
            this.labelMFV.Location = new System.Drawing.Point(21, 245);
            this.labelMFV.Margin = new System.Windows.Forms.Padding(0);
            this.labelMFV.Name = "labelMFV";
            this.labelMFV.Size = new System.Drawing.Size(134, 15);
            this.labelMFV.TabIndex = 29;
            this.labelMFV.Text = "Meter Firmware Version:";
            this.labelMFV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelMN
            // 
            this.labelMN.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelMN.AutoSize = true;
            this.labelMN.Location = new System.Drawing.Point(21, 203);
            this.labelMN.Margin = new System.Windows.Forms.Padding(0);
            this.labelMN.Name = "labelMN";
            this.labelMN.Size = new System.Drawing.Size(88, 15);
            this.labelMN.TabIndex = 27;
            this.labelMN.Text = "Meter Number:";
            this.labelMN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelMMI
            // 
            this.labelMMI.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelMMI.AutoSize = true;
            this.labelMMI.Location = new System.Drawing.Point(21, 163);
            this.labelMMI.Margin = new System.Windows.Forms.Padding(0);
            this.labelMMI.Name = "labelMMI";
            this.labelMMI.Size = new System.Drawing.Size(91, 15);
            this.labelMMI.TabIndex = 25;
            this.labelMMI.Text = "Meter Model Id:";
            this.labelMMI.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelSN
            // 
            this.labelSN.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelSN.AutoSize = true;
            this.labelSN.Location = new System.Drawing.Point(21, 124);
            this.labelSN.Margin = new System.Windows.Forms.Padding(0);
            this.labelSN.Name = "labelSN";
            this.labelSN.Size = new System.Drawing.Size(85, 15);
            this.labelSN.TabIndex = 24;
            this.labelSN.Text = "Serial Number:";
            this.labelSN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtFindSN
            // 
            this.txtFindSN.Location = new System.Drawing.Point(20, 61);
            this.txtFindSN.Name = "txtFindSN";
            this.txtFindSN.Size = new System.Drawing.Size(319, 23);
            this.txtFindSN.TabIndex = 23;
            // 
            // txtQ
            // 
            this.txtQ.AutoSize = true;
            this.txtQ.Location = new System.Drawing.Point(21, 24);
            this.txtQ.Name = "txtQ";
            this.txtQ.Size = new System.Drawing.Size(218, 15);
            this.txtQ.TabIndex = 22;
            this.txtQ.Text = "Enter Serial Number you want to search:";
            // 
            // lblfoundedMFV
            // 
            this.lblfoundedMFV.AutoSize = true;
            this.lblfoundedMFV.Location = new System.Drawing.Point(165, 245);
            this.lblfoundedMFV.Name = "lblfoundedMFV";
            this.lblfoundedMFV.Size = new System.Drawing.Size(76, 15);
            this.lblfoundedMFV.TabIndex = 34;
            this.lblfoundedMFV.Text = "foundedMFV";
            // 
            // lblfoundedMMI
            // 
            this.lblfoundedMMI.AutoSize = true;
            this.lblfoundedMMI.Location = new System.Drawing.Point(165, 163);
            this.lblfoundedMMI.Name = "lblfoundedMMI";
            this.lblfoundedMMI.Size = new System.Drawing.Size(77, 15);
            this.lblfoundedMMI.TabIndex = 35;
            this.lblfoundedMMI.Text = "foundedMMI";
            // 
            // lblfoundedMN
            // 
            this.lblfoundedMN.AutoSize = true;
            this.lblfoundedMN.Location = new System.Drawing.Point(165, 203);
            this.lblfoundedMN.Name = "lblfoundedMN";
            this.lblfoundedMN.Size = new System.Drawing.Size(72, 15);
            this.lblfoundedMN.TabIndex = 36;
            this.lblfoundedMN.Text = "foundedMN";
            // 
            // lblfoundedSS
            // 
            this.lblfoundedSS.AutoSize = true;
            this.lblfoundedSS.Location = new System.Drawing.Point(165, 285);
            this.lblfoundedSS.Name = "lblfoundedSS";
            this.lblfoundedSS.Size = new System.Drawing.Size(64, 15);
            this.lblfoundedSS.TabIndex = 37;
            this.lblfoundedSS.Text = "foundedSS";
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(345, 60);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 23);
            this.btnFind.TabIndex = 38;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // findEndpoint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.lblfoundedSS);
            this.Controls.Add(this.lblfoundedMN);
            this.Controls.Add(this.lblfoundedMMI);
            this.Controls.Add(this.lblfoundedMFV);
            this.Controls.Add(this.lblFoundedSN);
            this.Controls.Add(this.labelSS);
            this.Controls.Add(this.labelMFV);
            this.Controls.Add(this.labelMN);
            this.Controls.Add(this.labelMMI);
            this.Controls.Add(this.labelSN);
            this.Controls.Add(this.txtFindSN);
            this.Controls.Add(this.txtQ);
            this.Name = "findEndpoint";
            this.Size = new System.Drawing.Size(522, 507);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblFoundedSN;
        private Label labelSS;
        private Label labelMFV;
        private Label labelMN;
        private Label labelMMI;
        private Label labelSN;
        private TextBox txtFindSN;
        private Label txtQ;
        private Label lblfoundedMFV;
        private Label lblfoundedMMI;
        private Label lblfoundedMN;
        private Label lblfoundedSS;
        private Button btnFind;
    }
}

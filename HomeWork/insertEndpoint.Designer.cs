using Homework;

namespace HomeWork
{
    partial class insertEndpoint
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

        #region Component Designer generated code


        private void insertDataFromTheForm() {
            

            // get input
            string serial = inputSN.Text;
            string meterModelID = inputMMI.Text;
            string meterNumber = inputMN.Text;
            string mfv = inputMFV.Text;
            string ss = inputSS.Text;
            int intMeterModelID = fendpoint.setMMID(meterModelID);


            // validation Serial Number
            if (String.IsNullOrEmpty(serial))
            {
                MessageBox.Show("Serial Number cannot be empty", "ALERT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }           

            // validation Meter Model ID
            if (meterModelID == null || (!String.Equals(meterModelID, "NSX1P2W")
                && !String.Equals(meterModelID, "NSX1P3W")
                && !String.Equals(meterModelID, "NSX2P3W")
                && !String.Equals(meterModelID, "NSX3P4W"))) {
                MessageBox.Show(
                            "Invalid Model ID. Avaliable options:\n" +
                            "NSX1P2W\n" +
                            "NSX1P3W\n" +
                            "NSX2P3W\n" +
                            "NSX3P4W",
                            "ALERT",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // validation Meter Number
            int intmeterNumber;
            bool test = int.TryParse(meterNumber, out intmeterNumber);
            if (meterNumber == null) {
                MessageBox.Show("Invalid Meter Number", "ALERT", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (test == false) {
                MessageBox.Show("Invalid Integer", "ALERT", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // validation Meter Firmware Version
            if (mfv == null)
            {
                MessageBox.Show("Meter Firmware cannot be empty", "ALERT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int tstSS;
            // validation Switch State
            if (ss == null)
            {
                MessageBox.Show("Switch State cannot be empty", "ALERT", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else {
                tstSS = Convert.ToInt32(ss);

                if (tstSS != 0 && tstSS != 1 && tstSS != 2)
                {
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

            // insert ALL
            tempEndpoint.SerialNumber = serial;
            tempEndpoint.MeterModelID = intMeterModelID;
            tempEndpoint.MeterNumber = intmeterNumber;
            tempEndpoint.MeterFirmwareVersion = mfv;
            tempEndpoint.SwitchState = tstSS;

            bool insertionSucefully = fendpoint.Insert(tempEndpoint);

            if (insertionSucefully)
            {
                MessageBox.Show("Endpoint created!", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else {
                MessageBox.Show("Serial number already exists", "ALERT", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        
        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.q1 = new System.Windows.Forms.Label();
            this.lblSN = new System.Windows.Forms.Label();
            this.inputSN = new System.Windows.Forms.TextBox();
            this.inputMMI = new System.Windows.Forms.TextBox();
            this.lblMMI = new System.Windows.Forms.Label();
            this.inputMN = new System.Windows.Forms.TextBox();
            this.lblMN = new System.Windows.Forms.Label();
            this.inputMFV = new System.Windows.Forms.TextBox();
            this.lblMFV = new System.Windows.Forms.Label();
            this.inputSS = new System.Windows.Forms.TextBox();
            this.lblSS = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // q1
            // 
            this.q1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.q1.AutoSize = true;
            this.q1.Location = new System.Drawing.Point(19, 27);
            this.q1.Margin = new System.Windows.Forms.Padding(0);
            this.q1.Name = "q1";
            this.q1.Size = new System.Drawing.Size(111, 15);
            this.q1.TabIndex = 0;
            this.q1.Text = "Create an Endpoint:";
            this.q1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSN
            // 
            this.lblSN.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblSN.AutoSize = true;
            this.lblSN.Location = new System.Drawing.Point(22, 65);
            this.lblSN.Margin = new System.Windows.Forms.Padding(0);
            this.lblSN.Name = "lblSN";
            this.lblSN.Size = new System.Drawing.Size(85, 15);
            this.lblSN.TabIndex = 1;
            this.lblSN.Text = "Serial Number:";
            this.lblSN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // inputSN
            // 
            this.inputSN.Location = new System.Drawing.Point(178, 57);
            this.inputSN.Name = "inputSN";
            this.inputSN.Size = new System.Drawing.Size(162, 23);
            this.inputSN.TabIndex = 2;
            // 
            // inputMMI
            // 
            this.inputMMI.Location = new System.Drawing.Point(178, 96);
            this.inputMMI.Name = "inputMMI";
            this.inputMMI.Size = new System.Drawing.Size(162, 23);
            this.inputMMI.TabIndex = 4;
            // 
            // lblMMI
            // 
            this.lblMMI.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblMMI.AutoSize = true;
            this.lblMMI.Location = new System.Drawing.Point(22, 104);
            this.lblMMI.Margin = new System.Windows.Forms.Padding(0);
            this.lblMMI.Name = "lblMMI";
            this.lblMMI.Size = new System.Drawing.Size(91, 15);
            this.lblMMI.TabIndex = 3;
            this.lblMMI.Text = "Meter Model Id:";
            this.lblMMI.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // inputMN
            // 
            this.inputMN.Location = new System.Drawing.Point(178, 136);
            this.inputMN.Name = "inputMN";
            this.inputMN.Size = new System.Drawing.Size(162, 23);
            this.inputMN.TabIndex = 6;
            // 
            // lblMN
            // 
            this.lblMN.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblMN.AutoSize = true;
            this.lblMN.Location = new System.Drawing.Point(22, 144);
            this.lblMN.Margin = new System.Windows.Forms.Padding(0);
            this.lblMN.Name = "lblMN";
            this.lblMN.Size = new System.Drawing.Size(88, 15);
            this.lblMN.TabIndex = 5;
            this.lblMN.Text = "Meter Number:";
            this.lblMN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // inputMFV
            // 
            this.inputMFV.Location = new System.Drawing.Point(178, 178);
            this.inputMFV.Name = "inputMFV";
            this.inputMFV.Size = new System.Drawing.Size(162, 23);
            this.inputMFV.TabIndex = 8;
            // 
            // lblMFV
            // 
            this.lblMFV.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblMFV.AutoSize = true;
            this.lblMFV.Location = new System.Drawing.Point(22, 186);
            this.lblMFV.Margin = new System.Windows.Forms.Padding(0);
            this.lblMFV.Name = "lblMFV";
            this.lblMFV.Size = new System.Drawing.Size(134, 15);
            this.lblMFV.TabIndex = 7;
            this.lblMFV.Text = "Meter Firmware Version:";
            this.lblMFV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // inputSS
            // 
            this.inputSS.Location = new System.Drawing.Point(178, 218);
            this.inputSS.Name = "inputSS";
            this.inputSS.Size = new System.Drawing.Size(162, 23);
            this.inputSS.TabIndex = 10;
            // 
            // lblSS
            // 
            this.lblSS.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblSS.AutoSize = true;
            this.lblSS.Location = new System.Drawing.Point(22, 226);
            this.lblSS.Margin = new System.Windows.Forms.Padding(0);
            this.lblSS.Name = "lblSS";
            this.lblSS.Size = new System.Drawing.Size(74, 15);
            this.lblSS.TabIndex = 9;
            this.lblSS.Text = "Switch State:";
            this.lblSS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(143, 275);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 11;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // insertEndpoint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.inputSS);
            this.Controls.Add(this.lblSS);
            this.Controls.Add(this.inputMFV);
            this.Controls.Add(this.lblMFV);
            this.Controls.Add(this.inputMN);
            this.Controls.Add(this.lblMN);
            this.Controls.Add(this.inputMMI);
            this.Controls.Add(this.lblMMI);
            this.Controls.Add(this.inputSN);
            this.Controls.Add(this.lblSN);
            this.Controls.Add(this.q1);
            this.Name = "insertEndpoint";
            this.Size = new System.Drawing.Size(405, 461);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label q1;
        private Label lblSN;
        private Label lblMMI;
        private Label lblMN;
        private Label lblMFV;
        private Label lblSS;

        private TextBox inputSN;
        private TextBox inputMMI;
        private TextBox inputMN;
        private TextBox inputMFV;
        private TextBox inputSS;
        private Button btnCreate;
    }
}

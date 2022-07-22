namespace HomeWork
{
    partial class listEndpoint
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

        private void ListAll()
        {
            List<Endpoint> endpoints = fendpoint.ListAll();
            modelListEndpoint[] listItems = new modelListEndpoint[endpoints.Count];



            foreach (Endpoint e in endpoints)
            {
                string serial = e.SerialNumber;
                string mmi = Convert.ToString(e.MeterModelID);
                string mn = Convert.ToString(e.MeterNumber);
                string mfv = e.MeterFirmwareVersion;
                string ss = Convert.ToString(e.SwitchState);

                for (int i = 0; i < listItems.Length; i++)
                {

                    //    if (flowLayoutPanel1.Controls.Count > 0)
                    //{
                    //    flowLayoutPanel1.Controls.Clear();
                    //}
                    flowLayoutPanel1.Controls.Add(listItems[i]);

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
            this.components = new System.ComponentModel.Container();
            this.endpointBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.endpointBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // endpointBindingSource
            // 
            this.endpointBindingSource.DataSource = typeof(HomeWork.Endpoint);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(676, 585);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // listEndpoint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 585);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "listEndpoint";
            this.Load += new System.EventHandler(this.listEndpoint_Load);
            ((System.ComponentModel.ISupportInitialize)(this.endpointBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private BindingSource endpointBindingSource;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}

namespace HomeWork
{
    partial class dash
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private SplitContainer splitContainer1;
        private Label welcome;
        private Label oque;

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.exitButton = new System.Windows.Forms.Button();
            this.findButton = new System.Windows.Forms.Button();
            this.listButton = new System.Windows.Forms.Button();
            this.deletButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.insertButton = new System.Windows.Forms.Button();
            this.oque = new System.Windows.Forms.Label();
            this.welcome = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.exitButton);
            this.splitContainer1.Panel1.Controls.Add(this.findButton);
            this.splitContainer1.Panel1.Controls.Add(this.listButton);
            this.splitContainer1.Panel1.Controls.Add(this.deletButton);
            this.splitContainer1.Panel1.Controls.Add(this.editButton);
            this.splitContainer1.Panel1.Controls.Add(this.insertButton);
            this.splitContainer1.Panel1.Controls.Add(this.oque);
            this.splitContainer1.Panel1.Controls.Add(this.welcome);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(1047, 637);
            this.splitContainer1.SplitterDistance = 349;
            this.splitContainer1.TabIndex = 0;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(18, 267);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(177, 23);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // findButton
            // 
            this.findButton.Location = new System.Drawing.Point(18, 238);
            this.findButton.Name = "findButton";
            this.findButton.Size = new System.Drawing.Size(177, 23);
            this.findButton.TabIndex = 6;
            this.findButton.Text = "Find an Endpoint by SN";
            this.findButton.UseVisualStyleBackColor = true;
            this.findButton.Click += new System.EventHandler(this.findButton_Click);
            // 
            // listButton
            // 
            this.listButton.Location = new System.Drawing.Point(18, 209);
            this.listButton.Name = "listButton";
            this.listButton.Size = new System.Drawing.Size(177, 23);
            this.listButton.TabIndex = 5;
            this.listButton.Text = "List all Endpoint";
            this.listButton.UseVisualStyleBackColor = true;
            this.listButton.Click += new System.EventHandler(this.listButton_Click);
            // 
            // deletButton
            // 
            this.deletButton.Location = new System.Drawing.Point(18, 180);
            this.deletButton.Name = "deletButton";
            this.deletButton.Size = new System.Drawing.Size(177, 23);
            this.deletButton.TabIndex = 4;
            this.deletButton.Text = "Delete an Endpoint";
            this.deletButton.UseVisualStyleBackColor = true;
            this.deletButton.Click += new System.EventHandler(this.deletButton_Click);
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(18, 151);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(177, 23);
            this.editButton.TabIndex = 3;
            this.editButton.Text = "Edit an Endpoint";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // insertButton
            // 
            this.insertButton.Location = new System.Drawing.Point(18, 122);
            this.insertButton.Name = "insertButton";
            this.insertButton.Size = new System.Drawing.Size(177, 23);
            this.insertButton.TabIndex = 2;
            this.insertButton.Text = "Insert an Endpoint";
            this.insertButton.UseVisualStyleBackColor = true;
            this.insertButton.Click += new System.EventHandler(this.insertButton_Click);
            // 
            // oque
            // 
            this.oque.AutoSize = true;
            this.oque.Location = new System.Drawing.Point(18, 89);
            this.oque.Name = "oque";
            this.oque.Size = new System.Drawing.Size(140, 15);
            this.oque.TabIndex = 1;
            this.oque.Text = "What do you want to do?";
            // 
            // welcome
            // 
            this.welcome.AutoSize = true;
            this.welcome.Location = new System.Drawing.Point(18, 28);
            this.welcome.Name = "welcome";
            this.welcome.Size = new System.Drawing.Size(206, 15);
            this.welcome.TabIndex = 0;
            this.welcome.Text = "Welcome to HomeWork - Landis+Gyr";
            // 
            // dash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 637);
            this.Controls.Add(this.splitContainer1);
            this.Name = "dash";
            this.Text = "HomeWork";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Button deletButton;
        private Button editButton;
        private Button insertButton;
        private Button findButton;
        private Button listButton;
        private Button exitButton;
    }
}
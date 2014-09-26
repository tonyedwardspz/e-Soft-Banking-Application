namespace e_SoftBankingApplication
{
    partial class frmBank
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBank));
            this.grpSeachCust = new System.Windows.Forms.GroupBox();
            this.btnSearchCustomer = new System.Windows.Forms.Button();
            this.txtSearchBox = new System.Windows.Forms.TextBox();
            this.lstSearchCustResults = new System.Windows.Forms.ListBox();
            this.btnViewCustomer = new System.Windows.Forms.Button();
            this.btnNewCustomer = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.grpSeachCust.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpSeachCust
            // 
            this.grpSeachCust.Controls.Add(this.btnSearchCustomer);
            this.grpSeachCust.Controls.Add(this.txtSearchBox);
            this.grpSeachCust.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSeachCust.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.grpSeachCust.Location = new System.Drawing.Point(72, 213);
            this.grpSeachCust.Name = "grpSeachCust";
            this.grpSeachCust.Size = new System.Drawing.Size(1050, 116);
            this.grpSeachCust.TabIndex = 0;
            this.grpSeachCust.TabStop = false;
            this.grpSeachCust.Text = "Search For Customer";
            // 
            // btnSearchCustomer
            // 
            this.btnSearchCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchCustomer.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnSearchCustomer.Location = new System.Drawing.Point(702, 41);
            this.btnSearchCustomer.Name = "btnSearchCustomer";
            this.btnSearchCustomer.Size = new System.Drawing.Size(162, 46);
            this.btnSearchCustomer.TabIndex = 1;
            this.btnSearchCustomer.Text = "Search";
            this.btnSearchCustomer.UseVisualStyleBackColor = true;
            this.btnSearchCustomer.Click += new System.EventHandler(this.btnSearchCustomer_Click);
            // 
            // txtSearchBox
            // 
            this.txtSearchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchBox.Location = new System.Drawing.Point(154, 51);
            this.txtSearchBox.Name = "txtSearchBox";
            this.txtSearchBox.Size = new System.Drawing.Size(513, 29);
            this.txtSearchBox.TabIndex = 0;
            // 
            // lstSearchCustResults
            // 
            this.lstSearchCustResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstSearchCustResults.FormattingEnabled = true;
            this.lstSearchCustResults.ItemHeight = 16;
            this.lstSearchCustResults.Location = new System.Drawing.Point(72, 357);
            this.lstSearchCustResults.Name = "lstSearchCustResults";
            this.lstSearchCustResults.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstSearchCustResults.Size = new System.Drawing.Size(1050, 324);
            this.lstSearchCustResults.TabIndex = 1;
            // 
            // btnViewCustomer
            // 
            this.btnViewCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewCustomer.Location = new System.Drawing.Point(986, 715);
            this.btnViewCustomer.Name = "btnViewCustomer";
            this.btnViewCustomer.Size = new System.Drawing.Size(136, 40);
            this.btnViewCustomer.TabIndex = 2;
            this.btnViewCustomer.Text = "View Customer";
            this.btnViewCustomer.UseVisualStyleBackColor = true;
            this.btnViewCustomer.Click += new System.EventHandler(this.btnViewCustomer_Click);
            // 
            // btnNewCustomer
            // 
            this.btnNewCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewCustomer.Location = new System.Drawing.Point(758, 715);
            this.btnNewCustomer.Name = "btnNewCustomer";
            this.btnNewCustomer.Size = new System.Drawing.Size(136, 40);
            this.btnNewCustomer.TabIndex = 3;
            this.btnNewCustomer.Text = "New Customer";
            this.btnNewCustomer.UseVisualStyleBackColor = true;
            this.btnNewCustomer.Click += new System.EventHandler(this.btnNewCustomer_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(72, 715);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(136, 40);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmBank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1201, 782);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnNewCustomer);
            this.Controls.Add(this.btnViewCustomer);
            this.Controls.Add(this.lstSearchCustResults);
            this.Controls.Add(this.grpSeachCust);
            this.Name = "frmBank";
            this.Text = "e-SOFT Banking";
            this.Load += new System.EventHandler(this.frmBank_Load);
            this.grpSeachCust.ResumeLayout(false);
            this.grpSeachCust.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpSeachCust;
        private System.Windows.Forms.Button btnSearchCustomer;
        private System.Windows.Forms.TextBox txtSearchBox;
        private System.Windows.Forms.ListBox lstSearchCustResults;
        private System.Windows.Forms.Button btnViewCustomer;
        private System.Windows.Forms.Button btnNewCustomer;
        private System.Windows.Forms.Button btnExit;
    }
}


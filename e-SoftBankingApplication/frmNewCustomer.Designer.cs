namespace e_SoftBankingApplication
{
    partial class frmNewCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNewCustomer));
            this.grpNewCustomer = new System.Windows.Forms.GroupBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtPostcode = new System.Windows.Forms.TextBox();
            this.txtCityOrTown = new System.Windows.Forms.TextBox();
            this.txtStreetName = new System.Windows.Forms.TextBox();
            this.txtCustID = new System.Windows.Forms.TextBox();
            this.txtHouseNameNumber = new System.Windows.Forms.TextBox();
            this.lblCustId = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblHouseNumber = new System.Windows.Forms.Label();
            this.lblStreetName = new System.Windows.Forms.Label();
            this.lblCityOrTown = new System.Windows.Forms.Label();
            this.lblPostcode = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.btnSaveNewCust = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.grpAddress = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grpNewCustomer.SuspendLayout();
            this.grpAddress.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpNewCustomer
            // 
            this.grpNewCustomer.Controls.Add(this.groupBox1);
            this.grpNewCustomer.Controls.Add(this.grpAddress);
            this.grpNewCustomer.Controls.Add(this.lblCustId);
            this.grpNewCustomer.Controls.Add(this.txtLastName);
            this.grpNewCustomer.Controls.Add(this.txtFirstName);
            this.grpNewCustomer.Controls.Add(this.txtCustID);
            this.grpNewCustomer.Controls.Add(this.lblFirstName);
            this.grpNewCustomer.Controls.Add(this.lblLastName);
            this.grpNewCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpNewCustomer.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.grpNewCustomer.Location = new System.Drawing.Point(52, 203);
            this.grpNewCustomer.Name = "grpNewCustomer";
            this.grpNewCustomer.Size = new System.Drawing.Size(1082, 356);
            this.grpNewCustomer.TabIndex = 0;
            this.grpNewCustomer.TabStop = false;
            this.grpNewCustomer.Text = "New Customer";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(144, 36);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(177, 29);
            this.txtPassword.TabIndex = 7;
            // 
            // txtPostcode
            // 
            this.txtPostcode.Location = new System.Drawing.Point(264, 210);
            this.txtPostcode.Name = "txtPostcode";
            this.txtPostcode.Size = new System.Drawing.Size(130, 29);
            this.txtPostcode.TabIndex = 6;
            // 
            // txtCityOrTown
            // 
            this.txtCityOrTown.Location = new System.Drawing.Point(264, 162);
            this.txtCityOrTown.Name = "txtCityOrTown";
            this.txtCityOrTown.Size = new System.Drawing.Size(231, 29);
            this.txtCityOrTown.TabIndex = 5;
            // 
            // txtStreetName
            // 
            this.txtStreetName.Location = new System.Drawing.Point(264, 116);
            this.txtStreetName.Name = "txtStreetName";
            this.txtStreetName.Size = new System.Drawing.Size(231, 29);
            this.txtStreetName.TabIndex = 4;
            // 
            // txtCustID
            // 
            this.txtCustID.Location = new System.Drawing.Point(182, 64);
            this.txtCustID.Name = "txtCustID";
            this.txtCustID.ReadOnly = true;
            this.txtCustID.Size = new System.Drawing.Size(108, 29);
            this.txtCustID.TabIndex = 8;
            // 
            // txtHouseNameNumber
            // 
            this.txtHouseNameNumber.Location = new System.Drawing.Point(264, 68);
            this.txtHouseNameNumber.Name = "txtHouseNameNumber";
            this.txtHouseNameNumber.Size = new System.Drawing.Size(115, 29);
            this.txtHouseNameNumber.TabIndex = 3;
            // 
            // lblCustId
            // 
            this.lblCustId.AutoSize = true;
            this.lblCustId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustId.Location = new System.Drawing.Point(36, 64);
            this.lblCustId.Name = "lblCustId";
            this.lblCustId.Size = new System.Drawing.Size(113, 24);
            this.lblCustId.TabIndex = 0;
            this.lblCustId.Text = "Customer ID";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(183, 158);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(185, 29);
            this.txtLastName.TabIndex = 2;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(183, 113);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(185, 29);
            this.txtFirstName.TabIndex = 1;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(48, 116);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(101, 24);
            this.lblFirstName.TabIndex = 7;
            this.lblFirstName.Text = "First Name";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(48, 161);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(99, 24);
            this.lblLastName.TabIndex = 6;
            this.lblLastName.Text = "Last Name";
            // 
            // lblHouseNumber
            // 
            this.lblHouseNumber.AutoSize = true;
            this.lblHouseNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHouseNumber.Location = new System.Drawing.Point(27, 71);
            this.lblHouseNumber.Name = "lblHouseNumber";
            this.lblHouseNumber.Size = new System.Drawing.Size(206, 24);
            this.lblHouseNumber.TabIndex = 5;
            this.lblHouseNumber.Text = "House Name / Number";
            // 
            // lblStreetName
            // 
            this.lblStreetName.AutoSize = true;
            this.lblStreetName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStreetName.Location = new System.Drawing.Point(116, 119);
            this.lblStreetName.Name = "lblStreetName";
            this.lblStreetName.Size = new System.Drawing.Size(114, 24);
            this.lblStreetName.TabIndex = 4;
            this.lblStreetName.Text = "Street Name";
            // 
            // lblCityOrTown
            // 
            this.lblCityOrTown.AutoSize = true;
            this.lblCityOrTown.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCityOrTown.Location = new System.Drawing.Point(130, 165);
            this.lblCityOrTown.Name = "lblCityOrTown";
            this.lblCityOrTown.Size = new System.Drawing.Size(103, 24);
            this.lblCityOrTown.TabIndex = 3;
            this.lblCityOrTown.Text = "City / Town";
            // 
            // lblPostcode
            // 
            this.lblPostcode.AutoSize = true;
            this.lblPostcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPostcode.Location = new System.Drawing.Point(139, 213);
            this.lblPostcode.Name = "lblPostcode";
            this.lblPostcode.Size = new System.Drawing.Size(89, 24);
            this.lblPostcode.TabIndex = 2;
            this.lblPostcode.Text = "Postcode";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(17, 39);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(92, 24);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Password";
            // 
            // btnSaveNewCust
            // 
            this.btnSaveNewCust.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveNewCust.Location = new System.Drawing.Point(985, 577);
            this.btnSaveNewCust.Name = "btnSaveNewCust";
            this.btnSaveNewCust.Size = new System.Drawing.Size(149, 50);
            this.btnSaveNewCust.TabIndex = 1;
            this.btnSaveNewCust.Text = "Save";
            this.btnSaveNewCust.UseVisualStyleBackColor = true;
            this.btnSaveNewCust.Click += new System.EventHandler(this.btnSaveNewCust_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(52, 577);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(149, 50);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(234, 577);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(149, 50);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // grpAddress
            // 
            this.grpAddress.Controls.Add(this.txtPostcode);
            this.grpAddress.Controls.Add(this.txtCityOrTown);
            this.grpAddress.Controls.Add(this.txtStreetName);
            this.grpAddress.Controls.Add(this.txtHouseNameNumber);
            this.grpAddress.Controls.Add(this.lblHouseNumber);
            this.grpAddress.Controls.Add(this.lblStreetName);
            this.grpAddress.Controls.Add(this.lblCityOrTown);
            this.grpAddress.Controls.Add(this.lblPostcode);
            this.grpAddress.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.grpAddress.Location = new System.Drawing.Point(501, 42);
            this.grpAddress.Name = "grpAddress";
            this.grpAddress.Size = new System.Drawing.Size(541, 283);
            this.grpAddress.TabIndex = 15;
            this.grpAddress.TabStop = false;
            this.grpAddress.Text = "Address";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.lblPassword);
            this.groupBox1.Location = new System.Drawing.Point(40, 234);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(353, 91);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // frmNewCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1198, 650);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSaveNewCust);
            this.Controls.Add(this.grpNewCustomer);
            this.Name = "frmNewCustomer";
            this.Text = "e-SOFT - New Customer";
            this.Load += new System.EventHandler(this.frmNewCustomer_Load);
            this.grpNewCustomer.ResumeLayout(false);
            this.grpNewCustomer.PerformLayout();
            this.grpAddress.ResumeLayout(false);
            this.grpAddress.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpNewCustomer;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblHouseNumber;
        private System.Windows.Forms.Label lblStreetName;
        private System.Windows.Forms.Label lblCityOrTown;
        private System.Windows.Forms.Label lblPostcode;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblCustId;
        private System.Windows.Forms.Button btnSaveNewCust;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtCustID;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtPostcode;
        private System.Windows.Forms.TextBox txtCityOrTown;
        private System.Windows.Forms.TextBox txtStreetName;
        private System.Windows.Forms.TextBox txtHouseNameNumber;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.GroupBox grpAddress;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
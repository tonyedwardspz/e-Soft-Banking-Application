namespace e_SoftBankingApplication
{
    partial class frmAddNewAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddNewAccount));
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSaveNewAccount = new System.Windows.Forms.Button();
            this.grpNewAccount = new System.Windows.Forms.GroupBox();
            this.grpEditables = new System.Windows.Forms.GroupBox();
            this.txtOpeningBalance = new System.Windows.Forms.TextBox();
            this.txtOverdraftLimit = new System.Windows.Forms.TextBox();
            this.txtAccountNickName = new System.Windows.Forms.TextBox();
            this.lblAccountNickname = new System.Windows.Forms.Label();
            this.lblOverdraftLimit = new System.Windows.Forms.Label();
            this.lblOpeningBalance = new System.Windows.Forms.Label();
            this.txtAccountCreationDate = new System.Windows.Forms.TextBox();
            this.txtAccountNumber = new System.Windows.Forms.TextBox();
            this.txtAccountSortcode = new System.Windows.Forms.TextBox();
            this.lblAccSortCode = new System.Windows.Forms.Label();
            this.lblAccountNumber = new System.Windows.Forms.Label();
            this.lblAccountCreationDate = new System.Windows.Forms.Label();
            this.lblCustName = new System.Windows.Forms.Label();
            this.lblCustId = new System.Windows.Forms.Label();
            this.grpNewAccount.SuspendLayout();
            this.grpEditables.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(209, 680);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(149, 50);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(24, 680);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(149, 50);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSaveNewAccount
            // 
            this.btnSaveNewAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveNewAccount.Location = new System.Drawing.Point(960, 680);
            this.btnSaveNewAccount.Name = "btnSaveNewAccount";
            this.btnSaveNewAccount.Size = new System.Drawing.Size(149, 50);
            this.btnSaveNewAccount.TabIndex = 5;
            this.btnSaveNewAccount.Text = "Save";
            this.btnSaveNewAccount.UseVisualStyleBackColor = true;
            this.btnSaveNewAccount.Click += new System.EventHandler(this.btnSaveNewAccount_Click);
            // 
            // grpNewAccount
            // 
            this.grpNewAccount.Controls.Add(this.grpEditables);
            this.grpNewAccount.Controls.Add(this.txtAccountCreationDate);
            this.grpNewAccount.Controls.Add(this.txtAccountNumber);
            this.grpNewAccount.Controls.Add(this.txtAccountSortcode);
            this.grpNewAccount.Controls.Add(this.lblAccSortCode);
            this.grpNewAccount.Controls.Add(this.lblAccountNumber);
            this.grpNewAccount.Controls.Add(this.lblAccountCreationDate);
            this.grpNewAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpNewAccount.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.grpNewAccount.Location = new System.Drawing.Point(24, 253);
            this.grpNewAccount.Name = "grpNewAccount";
            this.grpNewAccount.Size = new System.Drawing.Size(1085, 399);
            this.grpNewAccount.TabIndex = 4;
            this.grpNewAccount.TabStop = false;
            this.grpNewAccount.Text = "Add new account";
            // 
            // grpEditables
            // 
            this.grpEditables.Controls.Add(this.txtOpeningBalance);
            this.grpEditables.Controls.Add(this.txtOverdraftLimit);
            this.grpEditables.Controls.Add(this.txtAccountNickName);
            this.grpEditables.Controls.Add(this.lblAccountNickname);
            this.grpEditables.Controls.Add(this.lblOverdraftLimit);
            this.grpEditables.Controls.Add(this.lblOpeningBalance);
            this.grpEditables.Location = new System.Drawing.Point(153, 158);
            this.grpEditables.Name = "grpEditables";
            this.grpEditables.Size = new System.Drawing.Size(750, 193);
            this.grpEditables.TabIndex = 15;
            this.grpEditables.TabStop = false;
            // 
            // txtOpeningBalance
            // 
            this.txtOpeningBalance.Location = new System.Drawing.Point(324, 149);
            this.txtOpeningBalance.Name = "txtOpeningBalance";
            this.txtOpeningBalance.Size = new System.Drawing.Size(130, 29);
            this.txtOpeningBalance.TabIndex = 3;
            // 
            // txtOverdraftLimit
            // 
            this.txtOverdraftLimit.Location = new System.Drawing.Point(324, 94);
            this.txtOverdraftLimit.Name = "txtOverdraftLimit";
            this.txtOverdraftLimit.Size = new System.Drawing.Size(134, 29);
            this.txtOverdraftLimit.TabIndex = 2;
            // 
            // txtAccountNickName
            // 
            this.txtAccountNickName.Location = new System.Drawing.Point(324, 41);
            this.txtAccountNickName.Name = "txtAccountNickName";
            this.txtAccountNickName.Size = new System.Drawing.Size(303, 29);
            this.txtAccountNickName.TabIndex = 1;
            // 
            // lblAccountNickname
            // 
            this.lblAccountNickname.AutoSize = true;
            this.lblAccountNickname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountNickname.Location = new System.Drawing.Point(119, 44);
            this.lblAccountNickname.Name = "lblAccountNickname";
            this.lblAccountNickname.Size = new System.Drawing.Size(170, 24);
            this.lblAccountNickname.TabIndex = 7;
            this.lblAccountNickname.Text = "Account Nickname";
            // 
            // lblOverdraftLimit
            // 
            this.lblOverdraftLimit.AutoSize = true;
            this.lblOverdraftLimit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOverdraftLimit.Location = new System.Drawing.Point(160, 97);
            this.lblOverdraftLimit.Name = "lblOverdraftLimit";
            this.lblOverdraftLimit.Size = new System.Drawing.Size(129, 24);
            this.lblOverdraftLimit.TabIndex = 3;
            this.lblOverdraftLimit.Text = "Overdraft Limit";
            // 
            // lblOpeningBalance
            // 
            this.lblOpeningBalance.AutoSize = true;
            this.lblOpeningBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpeningBalance.Location = new System.Drawing.Point(132, 152);
            this.lblOpeningBalance.Name = "lblOpeningBalance";
            this.lblOpeningBalance.Size = new System.Drawing.Size(157, 24);
            this.lblOpeningBalance.TabIndex = 2;
            this.lblOpeningBalance.Text = "Opening Balance";
            // 
            // txtAccountCreationDate
            // 
            this.txtAccountCreationDate.Location = new System.Drawing.Point(274, 50);
            this.txtAccountCreationDate.Name = "txtAccountCreationDate";
            this.txtAccountCreationDate.ReadOnly = true;
            this.txtAccountCreationDate.Size = new System.Drawing.Size(178, 29);
            this.txtAccountCreationDate.TabIndex = 12;
            // 
            // txtAccountNumber
            // 
            this.txtAccountNumber.Location = new System.Drawing.Point(843, 106);
            this.txtAccountNumber.Name = "txtAccountNumber";
            this.txtAccountNumber.ReadOnly = true;
            this.txtAccountNumber.Size = new System.Drawing.Size(178, 29);
            this.txtAccountNumber.TabIndex = 11;
            // 
            // txtAccountSortcode
            // 
            this.txtAccountSortcode.Location = new System.Drawing.Point(845, 47);
            this.txtAccountSortcode.Name = "txtAccountSortcode";
            this.txtAccountSortcode.ReadOnly = true;
            this.txtAccountSortcode.Size = new System.Drawing.Size(176, 29);
            this.txtAccountSortcode.TabIndex = 10;
            // 
            // lblAccSortCode
            // 
            this.lblAccSortCode.AutoSize = true;
            this.lblAccSortCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccSortCode.Location = new System.Drawing.Point(641, 50);
            this.lblAccSortCode.Name = "lblAccSortCode";
            this.lblAccSortCode.Size = new System.Drawing.Size(161, 24);
            this.lblAccSortCode.TabIndex = 6;
            this.lblAccSortCode.Text = "Account Sortcode";
            // 
            // lblAccountNumber
            // 
            this.lblAccountNumber.AutoSize = true;
            this.lblAccountNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountNumber.Location = new System.Drawing.Point(648, 109);
            this.lblAccountNumber.Name = "lblAccountNumber";
            this.lblAccountNumber.Size = new System.Drawing.Size(154, 24);
            this.lblAccountNumber.TabIndex = 5;
            this.lblAccountNumber.Text = "Account Number";
            // 
            // lblAccountCreationDate
            // 
            this.lblAccountCreationDate.AutoSize = true;
            this.lblAccountCreationDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountCreationDate.Location = new System.Drawing.Point(35, 53);
            this.lblAccountCreationDate.Name = "lblAccountCreationDate";
            this.lblAccountCreationDate.Size = new System.Drawing.Size(198, 24);
            this.lblAccountCreationDate.TabIndex = 4;
            this.lblAccountCreationDate.Text = "Account Creation Date";
            // 
            // lblCustName
            // 
            this.lblCustName.AutoSize = true;
            this.lblCustName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustName.Location = new System.Drawing.Point(492, 195);
            this.lblCustName.Name = "lblCustName";
            this.lblCustName.Size = new System.Drawing.Size(157, 24);
            this.lblCustName.TabIndex = 13;
            this.lblCustName.Text = "Customer Name: ";
            // 
            // lblCustId
            // 
            this.lblCustId.AutoSize = true;
            this.lblCustId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustId.Location = new System.Drawing.Point(130, 194);
            this.lblCustId.Name = "lblCustId";
            this.lblCustId.Size = new System.Drawing.Size(118, 24);
            this.lblCustId.TabIndex = 11;
            this.lblCustId.Text = "Customer ID:";
            // 
            // frmAddNewAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1137, 753);
            this.Controls.Add(this.lblCustName);
            this.Controls.Add(this.lblCustId);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSaveNewAccount);
            this.Controls.Add(this.grpNewAccount);
            this.Name = "frmAddNewAccount";
            this.Text = "eSOFT - New Account";
            this.Load += new System.EventHandler(this.frmAddNewAccount_Load);
            this.grpNewAccount.ResumeLayout(false);
            this.grpNewAccount.PerformLayout();
            this.grpEditables.ResumeLayout(false);
            this.grpEditables.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSaveNewAccount;
        private System.Windows.Forms.GroupBox grpNewAccount;
        private System.Windows.Forms.TextBox txtOpeningBalance;
        private System.Windows.Forms.TextBox txtOverdraftLimit;
        private System.Windows.Forms.TextBox txtAccountCreationDate;
        private System.Windows.Forms.TextBox txtAccountNumber;
        private System.Windows.Forms.TextBox txtAccountSortcode;
        private System.Windows.Forms.TextBox txtAccountNickName;
        private System.Windows.Forms.Label lblAccountNickname;
        private System.Windows.Forms.Label lblAccSortCode;
        private System.Windows.Forms.Label lblAccountNumber;
        private System.Windows.Forms.Label lblAccountCreationDate;
        private System.Windows.Forms.Label lblOverdraftLimit;
        private System.Windows.Forms.Label lblOpeningBalance;
        private System.Windows.Forms.Label lblCustName;
        private System.Windows.Forms.Label lblCustId;
        private System.Windows.Forms.GroupBox grpEditables;
    }
}
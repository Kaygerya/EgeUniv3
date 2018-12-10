namespace BankaIslemleri
{
    partial class ChooseAccountForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.ddlUsers = new System.Windows.Forms.ComboBox();
            this.lblAccountName = new System.Windows.Forms.Label();
            this.ddlAccounts = new System.Windows.Forms.ComboBox();
            this.btnChoose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı :";
            // 
            // ddlUsers
            // 
            this.ddlUsers.DisplayMember = "Text";
            this.ddlUsers.FormattingEnabled = true;
            this.ddlUsers.Location = new System.Drawing.Point(92, 39);
            this.ddlUsers.Name = "ddlUsers";
            this.ddlUsers.Size = new System.Drawing.Size(228, 21);
            this.ddlUsers.TabIndex = 1;
            this.ddlUsers.ValueMember = "Value";
            this.ddlUsers.SelectedIndexChanged += new System.EventHandler(this.ddlUsers_SelectedIndexChanged);
            // 
            // lblAccountName
            // 
            this.lblAccountName.AutoSize = true;
            this.lblAccountName.Location = new System.Drawing.Point(13, 75);
            this.lblAccountName.Name = "lblAccountName";
            this.lblAccountName.Size = new System.Drawing.Size(44, 13);
            this.lblAccountName.TabIndex = 2;
            this.lblAccountName.Text = "Hesap :";
            // 
            // ddlAccounts
            // 
            this.ddlAccounts.DisplayMember = "Text";
            this.ddlAccounts.FormattingEnabled = true;
            this.ddlAccounts.Location = new System.Drawing.Point(92, 72);
            this.ddlAccounts.Name = "ddlAccounts";
            this.ddlAccounts.Size = new System.Drawing.Size(228, 21);
            this.ddlAccounts.TabIndex = 3;
            this.ddlAccounts.ValueMember = "Value";
            // 
            // btnChoose
            // 
            this.btnChoose.Location = new System.Drawing.Point(306, 116);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Size = new System.Drawing.Size(75, 23);
            this.btnChoose.TabIndex = 4;
            this.btnChoose.Text = "Seçin";
            this.btnChoose.UseVisualStyleBackColor = true;
            this.btnChoose.Click += new System.EventHandler(this.btnChoose_Click);
            // 
            // ChooseAccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 151);
            this.Controls.Add(this.btnChoose);
            this.Controls.Add(this.ddlAccounts);
            this.Controls.Add(this.lblAccountName);
            this.Controls.Add(this.ddlUsers);
            this.Controls.Add(this.label1);
            this.Name = "ChooseAccountForm";
            this.Text = "ChooseAccountForm";
            this.Load += new System.EventHandler(this.ChooseAccountForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ddlUsers;
        private System.Windows.Forms.Label lblAccountName;
        private System.Windows.Forms.ComboBox ddlAccounts;
        private System.Windows.Forms.Button btnChoose;
    }
}
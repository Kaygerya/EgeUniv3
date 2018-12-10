namespace BankaIslemleri
{
    partial class Form1
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
            this.lblAmount = new System.Windows.Forms.Label();
            this.txtDebit = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDebit = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtwithDraw = new System.Windows.Forms.TextBox();
            this.btnWithDraw = new System.Windows.Forms.Button();
            this.lblAccountInfo = new System.Windows.Forms.Label();
            this.btnChooseAccount = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(232, 16);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(0, 13);
            this.lblAmount.TabIndex = 0;
            // 
            // txtDebit
            // 
            this.txtDebit.Location = new System.Drawing.Point(118, 55);
            this.txtDebit.Name = "txtDebit";
            this.txtDebit.Size = new System.Drawing.Size(100, 20);
            this.txtDebit.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Yatırılacak Tutar:";
            // 
            // btnDebit
            // 
            this.btnDebit.Location = new System.Drawing.Point(226, 53);
            this.btnDebit.Name = "btnDebit";
            this.btnDebit.Size = new System.Drawing.Size(75, 23);
            this.btnDebit.TabIndex = 3;
            this.btnDebit.Text = "Yatır";
            this.btnDebit.UseVisualStyleBackColor = true;
            this.btnDebit.Click += new System.EventHandler(this.btnDebit_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(16, 133);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 13);
            this.lblError.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Cekilecek tutar";
            // 
            // txtwithDraw
            // 
            this.txtwithDraw.Location = new System.Drawing.Point(118, 106);
            this.txtwithDraw.Name = "txtwithDraw";
            this.txtwithDraw.Size = new System.Drawing.Size(100, 20);
            this.txtwithDraw.TabIndex = 7;
            // 
            // btnWithDraw
            // 
            this.btnWithDraw.Location = new System.Drawing.Point(226, 104);
            this.btnWithDraw.Name = "btnWithDraw";
            this.btnWithDraw.Size = new System.Drawing.Size(75, 23);
            this.btnWithDraw.TabIndex = 8;
            this.btnWithDraw.Text = "Çek";
            this.btnWithDraw.UseVisualStyleBackColor = true;
            this.btnWithDraw.Click += new System.EventHandler(this.btnWithDraw_Click);
            // 
            // lblAccountInfo
            // 
            this.lblAccountInfo.AutoSize = true;
            this.lblAccountInfo.Location = new System.Drawing.Point(13, 166);
            this.lblAccountInfo.Name = "lblAccountInfo";
            this.lblAccountInfo.Size = new System.Drawing.Size(0, 13);
            this.lblAccountInfo.TabIndex = 9;
            // 
            // btnChooseAccount
            // 
            this.btnChooseAccount.Location = new System.Drawing.Point(211, 166);
            this.btnChooseAccount.Name = "btnChooseAccount";
            this.btnChooseAccount.Size = new System.Drawing.Size(99, 23);
            this.btnChooseAccount.TabIndex = 10;
            this.btnChooseAccount.Text = "Hesap Seçin";
            this.btnChooseAccount.UseVisualStyleBackColor = true;
            this.btnChooseAccount.Click += new System.EventHandler(this.btnChooseAccount_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 191);
            this.Controls.Add(this.btnChooseAccount);
            this.Controls.Add(this.lblAccountInfo);
            this.Controls.Add(this.btnWithDraw);
            this.Controls.Add(this.txtwithDraw);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnDebit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDebit);
            this.Controls.Add(this.lblAmount);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.TextBox txtDebit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDebit;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtwithDraw;
        private System.Windows.Forms.Button btnWithDraw;
        private System.Windows.Forms.Label lblAccountInfo;
        private System.Windows.Forms.Button btnChooseAccount;
    }
}


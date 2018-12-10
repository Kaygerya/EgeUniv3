using BankaIslemleri.Data.Entities;
using BankaIslemleri.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankaIslemleri
{
    public partial class Form1 : Form
    {
        public int Amount { get; set; }
        public string UserFullName { get; set; }
        public string UserId { get; set; }
        public string BankAccountNumber { get; set; }
        public Form1()
        {
            Amount = 0;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PrintAmount();
        }

        private void btnDebit_Click(object sender, EventArgs e)
        {
            int result = 0;
            if (int.TryParse(txtDebit.Text, out result))
            {
                BaseEntity notifications = new BaseEntity();
                int totalAmount = BankAccountService.Debit (UserId, BankAccountNumber, result, Amount, notifications);
                if (notifications.IsSuccess)
                {
                    Amount = totalAmount;
                    lblAmount.Text = Amount + " TL";
                }
                else
                {
                    lblError.Text = notifications.Errors[0];
                }
            }
            else
            {
                lblError.Text = "Rakamsall bir değer girin!";
            }
            txtDebit.Text = string.Empty;
        }

        public void PrintAmount()
        {
            lblError.Text = "";
            Amount = Amount;
            lblAmount.Text = Amount + " TL";
            lblAccountInfo.Text = UserFullName + " - " + BankAccountNumber;
        }

        private void btnWithDraw_Click(object sender, EventArgs e)
        {
            int result = 0;
            if (int.TryParse(txtwithDraw.Text, out result))
            {
                BaseEntity notifications = new BaseEntity();
                int totalAmount = BankAccountService.WithDraw(result, Amount, notifications);
                if (notifications.IsSuccess)
                {
                    Amount = totalAmount;
                    lblAmount.Text = Amount + " TL";
                }
                else
                {
                    lblError.Text = notifications.Errors[0];
                }
            }
            else
            {
                lblError.Text = "Rakamsal bir değer girin!";
            }
            txtwithDraw.Text = string.Empty;
        }

        private void btnChooseAccount_Click(object sender, EventArgs e)
        {
            ChooseAccountForm frm = new ChooseAccountForm(this);
            frm.Show();
        }
    }
}

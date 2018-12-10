using BankaIslemleri.Data.FormItems;
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
    public partial class ChooseAccountForm : Form
    {
        Form1 opener;

        public ChooseAccountForm(Form1 form1)
        {
            InitializeComponent();
            opener = form1;
        }

        private void ChooseAccountForm_Load(object sender, EventArgs e)
        {
            // get users from Db
            var users = UserService.GetAllUsers();
            ddlUsers.Items.Clear();
            //add all users
            foreach (var user in users )
            {
                ddlUsers.Items.Add(new ComboItem(user.FullName, user.Id));
            }
            //insert please select
            ddlUsers.Items.Insert(0, new ComboItem("Please Select", ""));

        }

        private void ddlUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            ddlAccounts.Items.Clear();
            var selectedUserId = ((ComboItem)ddlUsers.SelectedItem).Value;
            if (selectedUserId != "")
            {
                var user = UserService.GetUserById(selectedUserId.ToString());
                if(user.BankAccounts != null)
                {
                    foreach(var bankAccount in user.BankAccounts)
                    {
                        ddlAccounts.Items.Add(new ComboItem ( bankAccount.AccountNumber, bankAccount.AccountNumber));
                    }
                   
                }
                ddlAccounts.Items.Insert(0, new ComboItem("Please Select", ""));
            }
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            if (((ComboItem)ddlUsers.SelectedItem).Value != "" && ((ComboItem)ddlAccounts.SelectedItem).Value != "")
            {
                var selectedUserId = ((ComboItem)ddlUsers.SelectedItem).Value;
                var selectedAccount = ((ComboItem)ddlAccounts.SelectedItem).Value;
                var user = UserService.GetUserById(selectedUserId);
                var bankAccount = user.BankAccounts.Where(k => k.AccountNumber == selectedAccount).FirstOrDefault();

                opener.Amount = bankAccount.Amount;
                opener.UserFullName = user.FullName;
                opener.BankAccountNumber = bankAccount.AccountNumber;
                opener.UserId = user.Id;
                opener.PrintAmount();
                this.Close();
            }
        }
    }
}

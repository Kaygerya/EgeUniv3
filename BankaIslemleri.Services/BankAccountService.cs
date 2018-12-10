using BankaIslemleri.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaIslemleri.Services
{
    public static class BankAccountService
    {
        public static int WithDraw(int withdrawAmount, int bankAccountamount, BaseEntity notifications)
        {
            if (bankAccountamount < withdrawAmount)
            {
                notifications.Errors.Add("Hesabınızda yeterli bakiye yok");
                return 0;
            }
            if (withdrawAmount < 0)
            {
                notifications.Errors.Add("Cekmek istediğiniz tutar 0 dan büyük olmalıdır.");
                return 0;
            }
            int result = bankAccountamount - withdrawAmount;
            return result;
        }

        public static int Debit(int debitAmount, int bankAccountAmount, BaseEntity notifications)
        {
            if (debitAmount < 0)
            {
                notifications.Errors.Add("Yatırmak istediğiniz tutar 0'dan buyuk olmalıdır");
                return 0;
            }

            int result = bankAccountAmount + debitAmount;
            return result;
        }

        public static void WithDraw(int withDrawamount, BankAccount bankAccount, BaseEntity notifications)
        {
            int result = WithDraw(withDrawamount, bankAccount.Amount, notifications);
            if (notifications.IsSuccess)
            {
                bankAccount.Amount = result;
            }
        }


        public static int Debit(string userId, string bankAccountNumber, int debitAmount, int bankAccountAmount, BaseEntity notifications)
        {
            var user = UserService.GetUserById(userId);
            var bankAccount = user.BankAccounts.Where(k => k.AccountNumber == bankAccountNumber).FirstOrDefault();
            bankAccount.Amount = Debit(debitAmount, bankAccount.Amount, notifications);
            UserService.UpdateUser(user);
            return bankAccount.Amount;

        }

    }
}

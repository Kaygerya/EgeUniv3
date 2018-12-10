using System;
using BankaIslemleri.Data.Entities;
using BankaIslemleri.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BankaIslemleri.Test
{
    [TestClass]
    public class BankAccountServiceTest
    {
        /// <summary>
        /// bu method para cekme islemini test eder
        /// </summary>
        [TestMethod]
        public void WithDraw()
        {
            int withDrawAmount = 100;
            int bankAccountAmount = 500;

            BaseEntity notifications = new BaseEntity();
            int result = BankAccountService.WithDraw(withDrawAmount, bankAccountAmount, notifications);

            Assert.AreEqual(400, result);
            Assert.IsTrue(notifications.IsSuccess);
        }

        [TestMethod]
        public void WithDrawMoreThanAccount()
        {
            int withDrawAmount = 500;
            int bankAccountAmount = 100;

            BaseEntity notifications = new BaseEntity();
            int result = BankAccountService.WithDraw(withDrawAmount, bankAccountAmount, notifications);

            Assert.AreEqual(0, result);
            Assert.AreEqual("Hesabınızda yeterli bakiye yok", notifications.Errors[0]);
        }

        [TestMethod]
        public void WithDrawLessthanZero()
        {
            int withDrawAmount = -100;
            int bankAccountAmount = 100;

            BaseEntity notifications = new BaseEntity();
            int result = BankAccountService.WithDraw(withDrawAmount, bankAccountAmount, notifications);

            Assert.AreEqual(0, result);
            Assert.AreEqual("Cekmek istediğiniz tutar 0 dan büyük olmalıdır.", notifications.Errors[0]);
        }

        [TestMethod]
        public void Debit()
        {
            int debitAmount = 100;
            int bankAccountAmount = 100;
            BaseEntity notifications = new BaseEntity();
            int result = BankAccountService.Debit(debitAmount, bankAccountAmount, notifications);
            Assert.AreEqual(200, result);
        }

        [TestMethod]
        public void DebitLessThanZeroAmount()
        {
            int debitAmount = -50;
            int bankAccountAmount = 100;
            BaseEntity notifications = new BaseEntity();
            int result = BankAccountService.Debit(debitAmount, bankAccountAmount, notifications);
            Assert.AreEqual(0, result);
            Assert.AreEqual("Yatırmak istediğiniz tutar 0'dan buyuk olmalıdır", notifications.Errors[0]);
            Assert.AreEqual(notifications.IsSuccess, false);
        }

        [TestMethod]
        public void BankAccountWithDraw()
        {
            BankAccount bankAccount = new BankAccount();
            bankAccount.Id = "1";
            //bankAccount.UserId = "1";
            bankAccount.AccountNumber = "000001";
            bankAccount.Amount = 300;

            int withDrawAmount = 100;
            BaseEntity notifications = new BaseEntity();
            BankAccountService.WithDraw(withDrawAmount, bankAccount, notifications);
            Assert.AreEqual(200, bankAccount.Amount);
        }

        [TestMethod]
        public void BankAccountWithDrawLessThanZeroAmount()
        {
            BankAccount bankAccount = new BankAccount();
            bankAccount.Id = "1";
            //bankAccount.UserId = "1";
            bankAccount.AccountNumber = "000001";
            bankAccount.Amount = 300;

            int withDrawAmount = -100;
            BaseEntity notifications = new BaseEntity();
            BankAccountService.WithDraw(withDrawAmount, bankAccount, notifications);
            Assert.AreEqual("Cekmek istediğiniz tutar 0 dan büyük olmalıdır.", notifications.Errors[0]);
        }
    }
}

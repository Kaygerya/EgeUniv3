using System;
using BankaIslemleri.Data.Entities;
using BankaIslemleri.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace BankaIslemleri.Test
{
    [TestClass]
    public class UserServiceTest
    {
        [TestMethod]
        public void CreateUserTest()
        {
            User user = new User();
            user.FullName = "Mehmet Akın";
            user.Tel = "05355555555";
            UserService.CreateUser(user);
        }

        [TestMethod]
        public void GetUserById()
        {
            string userId = "5c062daeff981b15dc1e7cb1";
            var user = UserService.GetUserById(userId);
            Assert.AreEqual("Mehmet Akın", user.FullName);
        }

        [TestMethod]
        public void InsertBankAccountToUser()
        {
            BankAccount bankAccount = new BankAccount();
            bankAccount.AccountNumber = "A00001";
            bankAccount.Amount = 100;
            string userId = "5c062daeff981b15dc1e7cb1";

            UserService.InsertBankAccountToUser(bankAccount, userId);

            var user = UserService.GetUserById(userId);
            Assert.AreEqual(1, user.BankAccounts.Where(k=> k.AccountNumber=="A00001").Count());
        }



    }
}

using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MWebStore.SharedKernel.Entities;
using MWebStore.Domain.Scopes;
using ModernWebStore.SharedKernel.Helpers;

namespace MWebStore.Tests.Scope
{

    [TestClass]
    public class UserScopeTests
    {
        private User _validUser = new User("lucasgomesp22@gmail.com", "123456", true);
        private User _invalidPassword = new User("lucasgomesp22@gmail.com", "12", true);
        private User _invalidEmailUser = new User("", "123456", true);

        [TestMethod]
        [TestCategory("User Scopes - Register")]
        public void ShouldRegisterUser()
        {
            Assert.AreEqual(true, UserScopes.RegisterUserScopeIsValid(_validUser));
        }

        [TestMethod]
        [TestCategory("User Scopes - Register")]
        public void ShouldNotRegisterUserWhenPasswordIsInvalid()
        {
            Assert.AreEqual(false, UserScopes.RegisterUserScopeIsValid(_invalidPassword));
        }

        [TestMethod]
        [TestCategory("User Scopes - Register")]
        public void ShouldNotRegisterUserWhenEmailIsInvalid()
        {
            Assert.AreEqual(false, UserScopes.RegisterUserScopeIsValid(_invalidEmailUser));
        }

        [TestMethod]
        [TestCategory("User Scopes - Register")]
        public void ShouldAuthenticateUser()
        {
            //corrigir
            var isValid = UserScopes.AuthenticateUserScopeIsValid(_validUser, "lucasgomesp22@gmail.com", StringHelper.Encrypt("123456"));
            Assert.AreEqual(true, isValid);
        }

        [TestMethod]
        [TestCategory("User Scopes - Register")]
        public void ShouldNotAuthenticateUser()
        {
            Assert.AreEqual(false, UserScopes.AuthenticateUserScopeIsValid(_validUser, "lucasgomesp22@gmail.com", StringHelper.Encrypt("123456")));
        }
    }
}

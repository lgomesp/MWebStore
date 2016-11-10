using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MWebStore.SharedKernel.Entities;
using ModernWebStore.SharedKernel.Helpers;
using MWebStore.Domain.Specs;
using System.Linq;

namespace MWebStore.Tests.Specs
{
    [TestClass]
    public class UserSpecTests
    {
        private List<User> _users;

        public UserSpecTests()
        {
            this._users = new List<User>();
            _users.Add(new User("lucasgomesp22@gmail.com", StringHelper.Encrypt("123456"), true));
        }

        [TestMethod]
        [TestCategory("User Specs - Athenticate")]
        public void ShouldAuthenticate()
        {
            //dado um usuário
            //se obtém a expressão e retorna valor
            var expression = UserSpecs.AuthenticateUser("lucasgomesp22@gmail.com", "123456");
            var user = _users.AsQueryable().Where(expression).FirstOrDefault();

            Assert.AreNotEqual(null, user);
        }

        [TestMethod]
        [TestCategory("User Specs - Athenticate")]
        public void ShouldNotAuthenticateWhenEmailIsWrong()
        {
            var expression = UserSpecs.AuthenticateUser("luc@gmail.com", "123456");
            var user = _users.AsQueryable().Where(expression).FirstOrDefault();

            Assert.AreEqual(null, user);
        }

        [TestMethod]
        [TestCategory("User Specs - Athenticate")]
        public void ShouldNotAuthenticateWhenPasswordIsWrong()
        {
            var expression = UserSpecs.AuthenticateUser("lucasgomesp22@gmail.com", "13456");
            var user = _users.AsQueryable().Where(expression).FirstOrDefault();

            Assert.AreEqual(null, user);
        }

    }
}

using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MWebStore.SharedKernel.Entities;
using MWebStore.Domain.Scopes;

namespace MWebStore.Tests.Scope
{
    /// <summary>
    /// Summary description for CategoryScopeTestes
    /// </summary>
    [TestClass]
    public class CategoryScopeTests
    {
        [TestMethod]
        //group by traits
        [TestCategory("Category")]
        public void ShouldRegisterCategory()
        {
            var category = new Category("Placa Mãe");
            Assert.AreEqual(true, CategoryScopes.CreateCategoryScopeIsValid(category));

        }

        [TestMethod]
        //group by traits
        [TestCategory("Category")]
        public void ShouldUpdateCategoryTitle()
        {
            var category = new Category("Placa Mãe");
            Assert.AreEqual(true, CategoryScopes.UpdateCategoryScopeIsValid(category, "Motherboards"));

        }
    }
}

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MWebStore.Domain.Entities;
using System.Collections.Generic;

namespace MWebStore.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var category = new Category("Placa Mãe");
            var product = new Product("Processador", "Intel Core i3", 123, 5, 1);


            var order = new Order(new List<OrderItem>(), 1);
            var orderItem = new OrderItem(1,  20);
            order.AddItem(orderItem);

            //método do List .NET
            //order.OrderItems.Add(orderItem);


            //salvar categoria
            Assert.AreNotEqual(0, order.OrderItems);
        }
    }
}

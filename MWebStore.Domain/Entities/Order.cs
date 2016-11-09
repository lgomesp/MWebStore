﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace MWebStore.Domain.Entities
{
    public class Order
    {
        //usado apenas internamente
        private IList<OrderItem> _orderItems;

        public Order(IList<OrderItem> orderItems, int userId)
        {
            this.Date = DateTime.Now;
            //iniciando a lista (só assim pode receber valor)
            //this.OrderItems = new List<OrderItem>();
            this._orderItems = new List<OrderItem>();
            orderItems.ToList().ForEach(x => AddItem(x));
            this.OrderItems = orderItems;
            this.UserId = userId;
            this.Status = EOrderStatus.Created;
        } 

        public int Id { get; private set; }
        public DateTime Date { get; private set; }
        public IEnumerable<OrderItem> OrderItems {
            get { return _orderItems; }
            private set { _orderItems = new List<OrderItem>; }
        }
        public int UserId { get; private set; }
        public User User { get; private set; }

        //propriedade computada (não é armazenada no banco)
        public decimal Total
        {
            get
            {
                decimal total = 0;
                foreach (var item in _orderItems)
                    total += (item.Price * item.Quantity);

                return total;
            }
        }

        public EOrderStatus Status { get; private set; }


        public void AddItem(OrderItem item)
        {
            
        }

    }
}

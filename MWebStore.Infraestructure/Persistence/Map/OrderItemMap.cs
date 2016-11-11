using MWebStore.SharedKernel.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MWebStore.Infraestructure.Persistence.Map
{
    public class OrderItemMap : EntityTypeConfiguration<OrderItem>
    {
        public OrderItemMap()
        {
            ToTable("OrderItems");

            HasKey(x => x.Id);

            Property(x => x.Price).IsRequired();
            Property(x => x.Quantity).IsRequired();

            HasRequired(x => x.Order);
            HasRequired(x => x.Product);
        }
    }
}

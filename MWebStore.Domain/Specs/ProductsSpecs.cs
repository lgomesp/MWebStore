using MWebStore.SharedKernel.Entities;
using System;
using System.Linq.Expressions;

namespace MWebStore.Domain.Specs
{
    public static class ProductsSpecs
    {
        public static Expression<Func<Product, bool>> GetProductsInStock()
        {
            return x => x.QuantityOnHand > 0;
        }

        public static Expression<Func<Product, bool>> GetProductsOutOfStock()
        {
            return x => x.QuantityOnHand == 0;
        }
    }
}

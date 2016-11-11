using MWebStore.Domain.Repositories;
using MWebStore.Domain.Specs;
using MWebStore.Infraestructure.Persistence.DataContext;
using MWebStore.SharedKernel.Entities;
using System.Collections.Generic;
using System.Linq;

namespace MWebStore.Infraestructure.Persistence.Repositories
{
    public class ProductRespository : IProductRepository
    {
        private StoreDataContext _context;

        public ProductRespository(StoreDataContext context)
        {
            this._context = context;
        }

        public void Create(Product product)
        {
            _context.Products.Add(product);
        }

        public void Delete(Product product)
        {
            _context.Products.Remove(product);
        }

        public List<Product> Get()
        {
            return _context.Products.ToList();
        }

        public Product Get(int id)
        {
            return _context.Products.Find(id);
        }

        public List<Product> Get(int skip, int take)
        {
            return _context.Products.OrderBy(x => x.Title).Skip(skip).Take(take).ToList();
        }

        public List<Product> GetProductsInStock()
        {
            return _context.Products.Where(ProductsSpecs.GetProductsInStock()).ToList();
        }

        public List<Product> GetProductsOutOfStock()
        {
            return _context.Products.Where(ProductsSpecs.GetProductsOutOfStock()).ToList();
        }

        public void Update(Product product)
        {
            _context.Entry<Product>(product).State = System.Data.Entity.EntityState.Modified;
        }
    }
}

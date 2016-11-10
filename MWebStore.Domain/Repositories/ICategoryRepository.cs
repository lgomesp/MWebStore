using MWebStore.SharedKernel.Entities;
using System.Collections.Generic;

namespace MWebStore.Domain.Repositories
{
    public interface ICategoryRepository
    {
        List<Category> Get();
        List<Category> Get(int skip, int take);
        Category Get(int id);
        void Create(Category category);
        void Update(Category category);
        void Delete(Category category);
    }
}

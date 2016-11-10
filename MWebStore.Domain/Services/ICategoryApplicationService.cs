using MWebStore.Domain.Commands.CategoryCommands;
using MWebStore.SharedKernel.Entities;
using System.Collections.Generic;

namespace MWebStore.Domain.Services
{
    public interface ICategoryApplicationService
    {
        List<Category> Get();
        List<Category> Get(int skip, int take);
        Category Get(int id);
        Category Create(CreateCategoryCommand command);
        Category Update(UpdateCategoryCommand command);
        Category Delete(int id);
    }
}

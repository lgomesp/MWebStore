using MWebStore.Domain.Commands.OrderItemCommands;
using MWebStore.SharedKernel.Entities;
using System.Collections.Generic;

namespace MWebStore.Domain.Services
{
    public interface IProductApplicationService
    {
        List<Product> Get();
        List<Product> Get(int skip, int take);
        List<Product> GetOutOfStock();
        Product Get(int id);
        Product Create(CreateProductCommand command);
        Product UpdateBasicInformation(UpdateProductInfoCommand command);
        Product Delete(int id);
    }
}

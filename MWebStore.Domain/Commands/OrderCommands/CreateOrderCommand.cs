using MWebStore.Domain.Commands.OrderItemCommands;
using System.Collections.Generic;

namespace MWebStore.Domain.Commands.OrderCommands
{
    public class CreateOrderCommand
    {
        public CreateOrderCommand(IList<CreateOrderItemCommand> orderItems)
        {
            this.OrderItems = orderItems;
        }

        public IList<CreateOrderItemCommand> OrderItems { get; set; }
    }
}

namespace MWebStore.SharedKernel.Entities
{
    public class Product
    {
        public Product(
            string title, string description, 
            decimal price, int quantityOnHand, int categoryid)
        {
            this.Title = title;
            this.Description = description;
            this.Price = price;
            this.QuantityOnHand = quantityOnHand;
            this.CategoryId = categoryid;
        }

        public int Id { get; private set; }
        public string Title { get; private set; }
        public string Description { get; private set; }
        public decimal Price { get; private set; }
        public int QuantityOnHand { get; private set; }
        public int CategoryId { get; private set; }
        public Category Category { get; private set; }
    }
}

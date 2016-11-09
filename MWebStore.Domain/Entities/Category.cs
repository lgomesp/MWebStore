using MWebStore.Domain.Scopes;

namespace MWebStore.SharedKernel.Entities
{
    public class Category
    {
        public Category(string title)
        {
            this.Title = title;
        }

        public int Id { get; private set; }
        public string Title { get; private set; }

        //register or validate
        public void Register()
        {
            if (!this.CreateCategoryScopeIsValid())
                return;
        }

        public void UpdateTitle(string title)
        {
            if (!this.UpdateCategoryScopeIsValid(title))
                return;

            this.Title = Title;
        }

    }
}

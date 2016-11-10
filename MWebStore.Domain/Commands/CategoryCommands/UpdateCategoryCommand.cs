namespace MWebStore.Domain.Commands.CategoryCommands
{
    public class UpdateCategoryCommand
       {
            public UpdateCategoryCommand(int id, string title)
            {
                this.Id = id;
                this.Title = title;
            }

            public int Id { get; set; }
            public string Title { get; set; }
        }
}

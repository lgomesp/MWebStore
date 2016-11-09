namespace MWebStore.Domain.Entities
{
    public class User
    {
        public User(string email, string password, bool isAdmin)
        {
            this.Email = email;
            //this.Password = StringHelper.Encrypt(password);
            this.Password = password;
            this.isAdmin = isAdmin;
        }

        public int Id { get; private set; }
        public string Email { get; private set; }
        public string Password { get; private set; }
        public bool isAdmin { get; private set; }
    }
}

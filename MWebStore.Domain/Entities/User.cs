using ModernWebStore.SharedKernel.Helpers;
using MWebStore.Domain.Scopes;

namespace MWebStore.SharedKernel.Entities
{
    public class User
    {
        protected User() { }

        public User(string email, string password, bool isAdmin)
        {
            this.Email = email;
            this.Password = StringHelper.Encrypt(password);
            this.Password = password;
            this.IsAdmin = isAdmin;
        }

        public int Id { get; private set; }
        public string Email { get; private set; }
        public string Password { get; private set; }
        public bool IsAdmin { get; private set; }

        public void Register()
        {
            this.RegisterUserScopeIsValid();
        }

        public void Authenticate(string email, string password)
        {
            this.AuthenticateUserScopeIsValid(email, password);
        }

        //torna o usuário adm
        public void GrantAdmin()
        {
            this.IsAdmin = true;
        }

        public void RevokeAdmin()
        {
            this.IsAdmin = false;
        }
    }
}

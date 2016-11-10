using ModernWebStore.SharedKernel.Validation;
using MWebStore.SharedKernel.Entities;

namespace MWebStore.Domain.Scopes
{
    public static class UserScopes
    {
        public static bool RegisterUserScopeIsValid(this User user)
        {
            return AssertionConcern.IsSatisfiedBy(
                AssertionConcern.AssertNotEmpty(user.Email, "O título é obrigatório"),
                AssertionConcern.AssertLength(user.Password, 3, 15, "Tamanho em caracteres inválido")
                );
        }

        public static bool AuthenticateUserScopeIsValid(this User user, string email, string encryptedPassword)
        {
            return AssertionConcern.IsSatisfiedBy(
                AssertionConcern.AssertNotEmpty(email, "O usuário é obrigatório"),
                AssertionConcern.AssertNotEmpty(encryptedPassword, "A senha é obrigatória"),
                AssertionConcern.AssertAreEquals(user.Email, email, "Usuário ou Senha inválidos"),
                AssertionConcern.AssertAreEquals(user.Password, encryptedPassword, "Usuário ou Senha inválidos")
                );
        }
    }
}

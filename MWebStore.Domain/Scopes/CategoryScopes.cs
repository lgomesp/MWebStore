using ModernWebStore.SharedKernel.Validation;
using MWebStore.SharedKernel.Entities;

namespace MWebStore.Domain.Scopes
{
    public static class CategoryScopes
    {
        //extesion method
        public static bool CreateCategoryScopeIsValid(this Category category)
        {
            return AssertionConcern.IsSatisfiedBy(
                AssertionConcern.AssertNotEmpty(category.Title, "O título é obrigatório"),
                AssertionConcern.AssertLength(category.Title, 3, 15, "Tamanho em caracteres inválido")
                );
        }

        public static bool UpdateCategoryScopeIsValid(this Category category, string title)
        {
            return AssertionConcern.IsSatisfiedBy(
                AssertionConcern.AssertNotEmpty(title, "O título é obrigatório"),
                AssertionConcern.AssertLength(category.Title, 3, 15, "Tamanho em caracteres inválido")
                );
        }
    }
}

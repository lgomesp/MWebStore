using System;

namespace MWebStore.Infraestructure.Persistence
{
    public interface IUnitOfWork : IDisposable
    {
        void Commit();
    }
}

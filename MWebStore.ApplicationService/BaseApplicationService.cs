using ModernWebStore.SharedKernel.Events;
using MWebStore.Infraestructure.Persistence;
using MWebStore.SharedKernel;

namespace MWebStore.ApplicationService
{
    public class BaseApplicationService
    {
        private IUnitOfWork _unitOfWork;
        private IHandler<DomainNotification> _notifications;

        public BaseApplicationService(IUnitOfWork uof)
        {
            this._unitOfWork = uof;
            //obtem uma instância
            this._notifications = DomainEvent.Container.GetService<IHandler<DomainNotification>>();
        }

        public bool Commit()
        {
            //se tiver alguma notificação (erro) não commita
            if (_notifications.HasNotifications())
                return false;

            _unitOfWork.Commit();
            return true;
        }
    }
}

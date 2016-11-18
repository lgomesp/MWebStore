using MWebStore.ApplicationService;
using MWebStore.Domain.Commands.UserCommands;
using MWebStore.Domain.Repositories;
using MWebStore.Domain.Services;
using MWebStore.Infraestructure.Persistence;
using MWebStore.SharedKernel.Entities;
using System.Collections.Generic;

namespace MWebStore.ApplicationService
{
    public class UserApplicationService : BaseApplicationService, IUserApplicationService
    {
        private IUserRepository _repository;

        public UserApplicationService(IUserRepository repository, IUnitOfWork unitOfWork) : base(unitOfWork)
        {
            this._repository = repository;
        }

        public UserApplicationService(IUnitOfWork uof) : base(uof)
        {
        }

        public User Register(RegisterUserCommand command)
        {
            var user = new User(command.Email, command.Password, command.IsAdmin);
            user.Register();
            _repository.Register(user);

            if (Commit())
                return user;

            return null;
        }

        public User Authenticate(string username, string password)
        {
            return _repository.Authenticate(username, password);
        }

        public List<User> List()
        {
            return _repository.List();
        }
    }
}

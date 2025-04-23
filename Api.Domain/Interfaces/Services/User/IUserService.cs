using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Domain.Entities;

namespace Api.Domain.Interfaces.Services.User
{
    public interface IUserService
    {
        Task<UserEntitiy> Get(Guid id);
        Task<IEnumerable<UserEntitiy>> GetAll();
        Task<UserEntitiy> Post(UserEntitiy user);
        Task<UserEntitiy> Put(UserEntitiy user);
        Task<bool> Delete(Guid id);
    }
}

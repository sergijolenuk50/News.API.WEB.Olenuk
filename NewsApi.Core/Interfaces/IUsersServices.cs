using NewsApi.Core.DTOs;
using NewsApi.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsApi.Core.Interfaces
{
    public interface IUsersServices
    {
        Task<List<UsersDto>> GetAll();
        Task<UsersDto> Get(int id);
        Task Delete(int id);
        Task Insert(Users model);
        Task Update(Users news);
    }
}

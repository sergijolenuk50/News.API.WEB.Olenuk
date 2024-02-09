using NewsApi.Core.DTOs;
using NewsApi.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsApi.Core.Interfaces
{
    public interface IRoleServices
    {
        Task<List<RoleDto>> GetAll();
        Task<RoleDto> Get(int Id);
        Task Delete(int Id);
        Task Insert(Role model);
        Task Update(Role model);
    }
}

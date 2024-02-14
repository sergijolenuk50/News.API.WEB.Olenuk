using NewsApi.Core.DTOs;
using NewsApi.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsApi.Core.Interfaces
{
    public interface INewsServices
    {
        Task<List<NewsDto>> GetAll();
        Task<NewsDto> Get(int id);
        Task Delete(int id);
        Task Insert(News model);
        Task Update(News news);

    }
}

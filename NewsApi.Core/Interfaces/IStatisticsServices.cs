using NewsApi.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsApi.Core.Interfaces
{
    public interface IStatisticsServices
    {
        Task<List<Statistics>> GetAll();
        Task<Statistics> Get(int Id);
        Task Delete(int Id);
        Task Update(Statistics author);
        Task Insert(Statistics author);
    }
}

using NewsApi.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsApi.Core.Interfaces
{
    public interface ICategoryServices
    {
        Task<List<Category>> GetAll();
        Task<Category> Get(int Id);
        Task Delete(int Id);
        Task Update(Category category);
        Task Insert(Category category);
    }
}

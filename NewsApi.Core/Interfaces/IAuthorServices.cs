using NewsApi.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsApi.Core.Interfaces
{
    public interface IAuthorServices
    {
        Task<List<Author>> GetAll();
        Task<Author> Get(int Id);
        Task Delete(int Id);
        Task Update(Author author);
        Task Insert(Author author);
    }
}

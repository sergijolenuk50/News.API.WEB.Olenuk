using NewsApi.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsApi.Core.Entities
{
    public class News : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int CategoryId {  get; set; }
        public string Information { get; set; } = string.Empty;
       // public string Imegs { get; set; } = string.Empty;
        public int AuthorId { get; set; }
        public uint CountNewsOpen { get; set; }

    }
}

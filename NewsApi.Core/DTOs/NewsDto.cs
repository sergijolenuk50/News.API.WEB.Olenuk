using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsApi.Core.DTOs
{
    public class NewsDto
    {
        public string Name { get; set; } = string.Empty;
        public string Information { get; set; } = string.Empty;
       // public string Imegs { get; set; } = string.Empty;
        public uint CountNewsOpen { get; set; }
    }
}

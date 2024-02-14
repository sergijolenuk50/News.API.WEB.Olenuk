using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsApi.Core.DTOs
{
    public class StatisticsDto
    {
        public string IP { get; set; } = string.Empty;
        public string BrowserName { get; set; } = string.Empty;
        public string OS { get; set; } = string.Empty;
        public string Cyti { get; set; } = string.Empty;
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildAnalyzer
{
    class ErrorDetails
    {
        public string Description { get; set; }
        public string Project { get; set; }
        public string File { get; set; }
        public int Line { get; set; }
        public int Column { get; set; }
    }
}

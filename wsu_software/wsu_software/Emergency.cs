using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wsu_software
{
    public class Emergency
    {
        public int Id { get; set; }
        public string Alert { get; set; }

        public string location { get; set; }

        public DateTime start_time { get; set; }

        public DateTime end_time { get; set; }

        public bool Resolved { get; set; }
    }
}

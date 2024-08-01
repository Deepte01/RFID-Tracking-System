using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wsu_software
{
    public class RoomCount
    {
        public string name { get; set; }

        public int count { get; set; }


        public string FullInfo
        {
            get { return name.Trim() +" -" +Convert.ToString(count); }
        }
    }
}

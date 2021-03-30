using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TranMinhHao_5951071021
{
    public class WhetherForecast
    {
        public city city { get; set; }
        public List<list> list { get; set; }
    }

    public class temp
    {
        public double day { get; set; }
    }

    public class whether
    {
        public string main { get; set; }
        public string description { get; set; }
    }
    public class city
    {
        public string name { get; set; }
    }

    public class list
    {
        public double dt { get; set; }
        public double pressure { get; set; }
        public double humidity { get; set; }
        public double speed { get; set; }
        public temp temp { get; set; }
        public List<whether> whetherList { get; set; }
    }
}

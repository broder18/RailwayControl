using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RailwayModel.Configure
{
    
    public class Train
    {
        public Station[] Path { get;  set; }
        public Train()
        {

        }
        public Train(Station[] stations)
        {
            Path = stations;
        }

        
    }
}

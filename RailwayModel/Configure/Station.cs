using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RailwayModel.Configure
{
    
    public class Station
    {
        public int Id { get;  set; }
        public Station()
        {

        }
        public Station(int id)
        {
            this.Id = id;
        }
    }
}

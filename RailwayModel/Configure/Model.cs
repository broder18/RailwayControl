using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RailwayModel
{
    [Serializable]
    public class Model
    {
        public Station[] Stations { get;  set; }
        public Link[] Links { get;  set; }
        public Train[] Trains { get;  set; }
    }
}

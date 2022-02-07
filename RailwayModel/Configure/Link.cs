using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace RailwayModel
{
    [Serializable]
    public class Link
    {
        
        public Station From { get; set; }
        public Station To { get; set; }
        
        public int Length { get;  set; }

    }
}

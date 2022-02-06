using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace RailwayModel.Configure
{
    
    public class Link
    {
        
        public Station[] FromTo { get; set; }
        
        public int Length { get;  set; }
        public Link()
        {
            
        }
        public Link(Station[] stations, int len)
        {
            this.FromTo = stations;
            this.Length = len;
        }
    }
}

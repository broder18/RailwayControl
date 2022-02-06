using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RailwayModel.Configure
{
    [Serializable]
    public class Model
    {
        public Station[] Stations { get;  set; }
        public Link[] Links { get;  set; }
        public Train[] Trains { get;  set; }
        public Model()
        {

        }
        public Model(Station[] stations, Link[] links, Train[] trains)
        {
            this.Stations = stations;
            this.Links = links;
            this.Trains = trains;
        }

        public void CreateStations(int length)
        {
            Stations = new Station[length];
            for(int i=0; i < length; i++)
            {
                Stations[i] = new Station(i);
            }
        }

        public void CreateLink(int length)
        {
            Links = new Link[length];
            for(int i=1; i < length; i++)
            {
                Links[i] = new Link(new Station[] { Stations[i - 1], Stations[0] }, i);
            }
        }


    }
}

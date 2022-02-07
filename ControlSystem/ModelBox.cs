using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RailwayModel;

namespace ControlSystem
{
    class ModelBox
    {
        public Model GetModelBox1()
        {
            Station stat1 = new Station { Id = 3 };
            Station stat2 = new Station { Id = 5 };
            Station stat3 = new Station { Id = 6 };
            Station stat4 = new Station { Id = 7 };
            Station stat5 = new Station { Id = 4 };
            Station stat6 = new Station { Id = 8 };
            Station stat7 = new Station { Id = 2 };

            Station[] stations = new Station[] { stat1, stat2, stat3, stat4, stat5, stat6, stat7 };

            Link link1 = new Link{ From = stat1, To = stat2, Length = 3 };
            Link link2 = new Link{ From = stat3, To = stat5,  Length = 2 };
            Link link3 = new Link{ From = stat6, To =  stat1 , Length = 4 };
            Link link4 = new Link{ From = stat4, To = stat5,  Length = 5 };
            Link link5 = new Link{ From = stat1, To = stat5, Length = 2 };
            Link link6 = new Link{ From = stat3, To = stat4, Length = 3 };
            Link link7 = new Link{ From = stat5, To = stat6, Length = 1 };
            Link link8 = new Link{ From = stat2, To = stat5, Length = 10 };

            Link[] links = new Link[] { link1, link2, link3, link4, link5, link6, link7, link8 };

            Train train1 = new Train { Path = new Station[] { stat3, stat4, stat5, stat6 } };
            Train train2 = new Train { Path = new Station[] { stat1, stat6, stat5, stat2, stat1, stat6 } };
            Train train3 = new Train { Path = new Station[] { stat2, stat5, stat4, stat7, stat1, stat3 } };

            
            Model railway = new Model { Stations = stations, Trains = new Train[] { train1, train2, train3 }, Links = links };
            return railway;
        }
        
        public Model GetModelBox2()
        {
            Station stat1 = new Station { Id = 3 };
            Station stat2 = new Station { Id = 5 };
            Station stat3 = new Station{ Id = 6 };
            Station stat4 = new Station{ Id = 7 };
            Station stat5 = new Station{ Id = 4 };
            Station stat6 = new Station{ Id = 8 };
            Station stat7 = new Station{ Id = 2 };

            Link link1 = new Link { From = stat1, To = stat2 , Length = 3 };
            Link link2 = new Link { From = stat3, To = stat5, Length = 2 };
            Link link3 = new Link{ From = stat6, To = stat1, Length = 4 } ;
            Link link4 = new Link{ From = stat4, To = stat5, Length = 5 } ;
            Link link5 = new Link{ From = stat1, To = stat5, Length = 2 };
            Link link6 = new Link{ From = stat3, To = stat4, Length = 3 };
            Link link7 = new Link{ From = stat5, To = stat6, Length = 1 };


            Train train3 = new Train {Path = new Station[] { stat2, stat5, stat4, stat7, stat1, stat3 } };
            Train train4 = new Train {Path = new Station[] { stat1, stat5, stat2, stat1 } };
            Train train5 = new Train { Path = new Station[] { stat3, stat5, stat6, stat1 } };

            Station[] stations = new Station[]{stat1, stat2, stat3, stat4, stat5, stat6, stat7};
            Link[] linkbox = new Link[]{link1, link2, link3, link6, link4, link5, link7};
            Train[] trainbox = new Train[] { train4, train5, train3 };
            Model railway = new Model { Stations = stations, Links = linkbox, Trains = trainbox };
            return railway;
        }
    }
}

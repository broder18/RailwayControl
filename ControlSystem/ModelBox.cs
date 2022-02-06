using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RailwayModel;
using RailwayModel.Configure;

namespace ControlSystem
{
    class ModelBox
    {
        public Model GetModelBox1()
        {
            Station stat1 = new Station(3);
            Station stat2 = new Station(5);
            Station stat3 = new Station(6);
            Station stat4 = new Station(7);
            Station stat5 = new Station(4);
            Station stat6 = new Station(8);
            Station stat7 = new Station(2);

            Station[] stations = new Station[] { stat1, stat2, stat3, stat4, stat5, stat6, stat7 };

            Link link1 = new Link( new Station[] { stat1, stat2 }, 3);
            Link link2 = new Link(new Station[] { stat3, stat5 }, 2);
            Link link3 = new Link(new Station[] { stat6, stat1 }, 4);
            Link link4 = new Link(new Station[] { stat4, stat5 }, 5);
            Link link5 = new Link(new Station[] { stat1, stat5 }, 2);
            Link link6 = new Link(new Station[] { stat3, stat4 }, 3);
            Link link7 = new Link(new Station[] { stat5, stat6 }, 1);
            Link link8 = new Link(new Station[] { stat2, stat5 }, 10);

            Link[] links = new Link[] { link1, link2, link3, link4, link5, link6, link7, link8 };

            Train train1 = new Train(new Station[] { stat3, stat4, stat5, stat6 });
            Train train2 = new Train(new Station[] { stat1, stat6, stat5, stat2, stat1, stat6 });
            Train train3 = new Train(new Station[] { stat2, stat5, stat4, stat7, stat1, stat3 });

            Train[] trainbox = new Train[] { train1, train2, train3 };
            Model railway = new Model(stations, links, trainbox);
            return railway;
        }
        
        public Model GetModelBox2()
        {
            Station stat1 = new Station(3);
            Station stat2 = new Station(5);
            Station stat3 = new Station(6);
            Station stat4 = new Station(7);
            Station stat5 = new Station(4);
            Station stat6 = new Station(8);
            Station stat7 = new Station(2);

            Link link1 = new Link(new Station[] { stat1, stat2 }, 3);
            Link link2 = new Link(new Station[] { stat3, stat5 }, 2);
            Link link3 = new Link(new Station[] { stat6, stat1 }, 4);
            Link link4 = new Link(new Station[] { stat4, stat5 }, 5);
            Link link5 = new Link(new Station[] { stat1, stat5 }, 2);
            Link link6 = new Link(new Station[] { stat3, stat4 }, 3);
            Link link7 = new Link(new Station[] { stat5, stat6 }, 1);


            Train train3 = new Train(new Station[] { stat2, stat5, stat4, stat7, stat1, stat3 });
            Train train4 = new Train(new Station[] { stat1, stat5, stat2, stat1 });
            Train train5 = new Train(new Station[] { stat3, stat5, stat6, stat1 });

            Station[] stations = new Station[]{stat1, stat2, stat3, stat4, stat5, stat6, stat7};
            Link[] linkbox = new Link[]{link1, link2, link3, link6, link4, link5, link7};
            Train[] trainbox = new Train[] { train4, train5, train3 };
            Model railway = new Model(stations, linkbox, trainbox);
            return railway;
        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using RailwayModel.Configure;

namespace RailwayModel.Test
{
    [TestClass]
    public class UnitTest1
    {
        private static Station stat1 = new Station(3);
        private static Station stat2 = new Station(5);
        private static Station stat3 = new Station(6);
        private static Station stat4 = new Station(7);
        private static Station stat5 = new Station(4);
        private static Station stat6 = new Station(8);
        private static Station stat7 = new Station(2);

        

        private static Link link1 = new Link( new Station[] {stat1, stat2} , 3);
        private static Link link2 = new Link(new Station[] { stat3, stat5 }, 2);
        private static Link link3 = new Link(new Station[] { stat6, stat1 }, 4);
        private static Link link4 = new Link(new Station[] { stat4, stat5 }, 5);
        private static Link link5 = new Link(new Station[] { stat1, stat5 }, 2);
        private static Link link6 = new Link(new Station[] { stat3, stat4 }, 3);
        private static Link link7 = new Link(new Station[] { stat5, stat6 }, 1);
        private static Link link8 = new Link(new Station[] { stat2, stat5 }, 10);

        private Station[] stations = new Station[]
        {
            stat1, stat2, stat3, stat4, stat5, stat6, stat7
        };


        private Link[] linkbox1 = new Link[]
        {
            link1, link2, link3, link6, link4
        };

        private Link[] linkbox2 = new Link[]
        {
            link1, link2, link3, link6, link4, link5, link7
        };

        private static Train train1 = new Train(new Station[] {stat3, stat4, stat5, stat6});
        private static Train train2 = new Train(new Station[] {stat1, stat6, stat5, stat2, stat1,stat6 });
        private static Train train3 = new Train(new Station[] {stat2, stat5, stat4, stat7,stat1,stat3});
        private static Train train4 = new Train(new Station[] {stat1 , stat5, stat2 , stat1});
        private static Train train5 = new Train(new Station[] {stat3, stat5, stat6, stat1});

        private Train[] trainbox1 = new Train[] { train1,train2};
        private Train[] trainbox2 = new Train[] { train1, train2, train3 };
        private Train[] trainbox3 = new Train[] { train4, train5, train3 };
 
        [TestMethod]
        public void CollisionTest()
        {
            var model = new Model(stations, linkbox1, trainbox1);
            var modelling = new Modelling(model);
            Assert.IsFalse(modelling.FindCollision());
        }

        [TestMethod]
        public void CollisionTest1()
        {
            var model = new Model(stations, linkbox2, trainbox2);
            var modelling = new Modelling(model);
            Assert.IsFalse(modelling.FindCollision());
        }

        [TestMethod]
        public void CollisionTest2()
        {
            var model = new Model(stations, linkbox2, trainbox3);
            var modelling = new Modelling(model);
            Assert.IsTrue(modelling.FindCollision());
        }
    }
}

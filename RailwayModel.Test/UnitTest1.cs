using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RailwayModel.Test
{
    [TestClass]
    public class UnitTest1
    {
        private static Station stat1 = new Station { Id = 3 };
        private static Station stat2 = new Station { Id = 5 };
        private static Station stat3 = new Station { Id = 6 };
        private static Station stat4 = new Station{ Id = 7 };
        private static Station stat5 = new Station{ Id = 4 };
        private static Station stat6 = new Station{ Id = 8 };
        private static Station stat7 = new Station{ Id = 2 };
        
        

        private static Link link1 = new Link { From = stat1, To =  stat2 , Length = 3 };
        private static Link link2 = new Link { From = stat3, To =  stat5 , Length = 2 };
        private static Link link3 = new Link{ From = stat6, To =  stat1 , Length = 4 };
        private static Link link4 = new Link{ From = stat4, To =  stat5 , Length = 5 };
        private static Link link5 = new Link{ From = stat1, To = stat5 , Length = 2 };
        private static Link link6 = new Link{ From = stat3, To = stat4, Length = 3 };
        private static Link link7 = new Link{ From = stat5, To = stat6, Length = 1 };
        private static Link link8 = new Link{ From = stat2, To = stat5, Length = 10 };

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

        private static Train train1 = new Train { Path = new Station[] { stat3, stat4, stat5, stat6 } };
        private static Train train2 = new Train { Path = new Station[] { stat1, stat6, stat5, stat2, stat1, stat6 } };
        private static Train train3 = new Train { Path = new Station[] { stat2, stat5, stat4, stat7, stat1, stat3 } };
        private static Train train4 = new Train{ Path = new Station[] { stat1, stat5, stat2, stat1 } };
        private static Train train5 = new Train{ Path = new Station[] { stat3, stat5, stat6, stat1 } };

        private Train[] trainbox1 = new Train[] { train1,train2};
        private Train[] trainbox2 = new Train[] { train1, train2, train3 };
        private Train[] trainbox3 = new Train[] { train4, train5, train3 };
 
        [TestMethod]
        public void CollisionTest()
        {
           

            var model = new Model { Stations = stations, Links = linkbox1, Trains = trainbox1 };
            var modelling = new Modelling(model);
            Assert.IsFalse(modelling.FindCollision());
        }

        [TestMethod]
        public void CollisionTest1()
        {
            var model = new Model { Stations = stations, Links = linkbox2, Trains = trainbox2 };
            
            var modelling = new Modelling(model);
            Assert.IsFalse(modelling.FindCollision());
        }

        [TestMethod]
        public void CollisionTest2()
        {
            var model = new Model{ Stations = stations, Links = linkbox2, Trains = trainbox3 };
            var modelling = new Modelling(model);
            Assert.IsTrue(modelling.FindCollision());
        }
    }
}

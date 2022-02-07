using System;
using System.IO;
using RailwayModel;


namespace ControlSystem
{

    class Program
    {
        static void Main(string[] args)
        {
            ModelBox box1 = new ModelBox(); 
            Model railway = box1.GetModelBox1();
            ReadWriteOption.SerializeMode(railway);
            railway = ReadWriteOption.DeserializeMode();
            Modelling modelling = new Modelling(railway);
            modelling.Start();
        }
    }
}

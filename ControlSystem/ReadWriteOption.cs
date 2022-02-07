using System;
using System.Runtime.Serialization.Formatters.Binary;
using RailwayModel;
using System.IO;

namespace ControlSystem
{
    static class ReadWriteOption
    {
        public static void SerializeMode(Model railway)
        {
            Console.WriteLine("Укажите путь .dat файл для записи: ");
            string filename = Console.ReadLine();
            

            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream stream = new FileStream(filename, FileMode.OpenOrCreate))
            {
                formatter.Serialize(stream, railway);
            }

        }

        public static Model DeserializeMode()
        {
            Console.WriteLine("Укажите путь .dat файл для чтения: ");
            string filename = Console.ReadLine();

            try
            {
                Model railway;
                BinaryFormatter formatter = new BinaryFormatter();
                using (FileStream stream = new FileStream(filename, FileMode.Open))
                {
                    railway = (Model)formatter.Deserialize(stream);
                }
                return railway;
            }
            catch
            {
                Console.WriteLine("Неверный путь ");
                return null;
            }
            
            
        }
    }
}

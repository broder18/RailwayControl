using System;
using System.Xml.Serialization;
using RailwayModel.Configure;
using System.IO;

namespace ControlSystem
{
    static class ReadWriteOption
    {
        public static void SerializeMode(Model railway)
        {
            Console.WriteLine("Укажите путь xml файл для записи: ");
            string filename = Console.ReadLine();
            

            XmlSerializer formatter = new XmlSerializer(typeof(Model));
            using (FileStream stream = new FileStream(filename, FileMode.OpenOrCreate))
            {
                formatter.Serialize(stream, railway);
            }

        }

        public static Model DeserializeMode()
        {
            Console.WriteLine("Укажите путь xml файл для чтения: ");
            string filename = Console.ReadLine();

            try
            {
                Model railway;
                using (FileStream stream = new FileStream(filename, FileMode.Open))
                {
                    XmlSerializer formatter = new XmlSerializer(typeof(Model));
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


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RailwayModel
{
    public class Modelling
    {
        public Dictionary<int, int> DictInd { get; private set; }
        public int[,] AdjacensyTable { get; private set; }
        public Model RailWay { get; private set; }
        public Modelling(Model railway)
        {
            this.RailWay = railway;
            DictInd = GetDict(RailWay.Stations);
            AdjacensyTable = GetTableLength(RailWay.Links, RailWay.Stations.Length);
        }

        private Dictionary<int, int> GetDict(Station[] stations)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            for (int ind = 0; ind < stations.Length; ind++)
            {
                dict.Add(stations[ind].GetHashCode(), ind);
            }
            return dict;
        }

        private int[,] GetTableLength(Link[] links, int arraySize)
        {
            int[,] table = new int[arraySize, arraySize];
            for (int i = 0; i < links.Length; i++)
            {
                table[DictInd[links[i].From.GetHashCode()], DictInd[links[i].To.GetHashCode()]] = links[i].Length;
                table[DictInd[links[i].To.GetHashCode()], DictInd[links[i].From.GetHashCode()]] = links[i].Length;

            }
            return table;
        }


        public bool FindCollision()
        {

            var stackTrain = new Queue<Train>();
            foreach (var item in RailWay.Trains)
            {
                stackTrain.Enqueue(item);
            }

            int step = 1;
            int[] timeId = new int[RailWay.Stations.Length];

            while (true)
            {

                if (stackTrain.Count == 0)
                {
                    return false;
                }

                for (int i = 0; i < stackTrain.Count; i++)
                {
                    
                    Train train = stackTrain.Dequeue();
                    int from = train.Path[step - 1].GetHashCode();
                    int to = train.Path[step].GetHashCode();
                    int distance = AdjacensyTable[DictInd[from], DictInd[to]];

                    if (step == train.Path.Length - 1 || distance == 0)
                    {
                        continue;
                    }

                    distance += timeId[DictInd[train.Path[step - 1].GetHashCode()]];

                    if (distance == timeId[DictInd[train.Path[step].GetHashCode()]])
                    {
                        return true;
                    }

                    timeId[DictInd[train.Path[step].GetHashCode()]] = distance;
                    stackTrain.Enqueue(train);
                }
                step++;
            }

        }

        public void Start()
        {
            if (FindCollision() == true)
            {
                Console.WriteLine("произошло столкновение");
                return;
            }
            Console.WriteLine("Столкновений нет");

        }
    }
}

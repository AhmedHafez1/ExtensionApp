using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OrdinaryHuman human = new OrdinaryHuman(100);

            Console.WriteLine(human.BreakWalls(44.8));


           string sentence = AmazeballsSerum.BreakWalls(human, 88.5);

            Console.WriteLine(sentence);

            List<int> list = new List<int>();

            IEnumerable<int> rangeList = Enumerable.Range(0, sentence.Length);

            foreach (int i in rangeList)
            {
                Console.WriteLine(i);
            }
        }
    }
}

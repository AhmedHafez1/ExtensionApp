using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    sealed class OrdinaryHuman
    {
        private int age;
        int weight;

        public int Weight { get { return weight; } set { weight = value; } }
        public OrdinaryHuman(int weight)
        {
            this.weight = weight;
        }
        public void GoToWork() { /* code to go to work */ }
        public void PayBills() { /* code to pay bills */ }
    }

    static class AmazeballsSerum
    {
        public static string BreakWalls(this OrdinaryHuman human, double wallDensity)
        {
            return $"I broke {human.Weight} through a wall of {wallDensity} density.";
        }
    }
}

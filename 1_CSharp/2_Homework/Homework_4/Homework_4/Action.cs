using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_4
{
    public class Action
    {
    public void OrtalamaDizi(int[] Array)
        {
           int ArraySum = Array.Sum();
            Console.WriteLine($"Dizinin elemanlarının toplamı: {ArraySum}");
            double ArrayAvg =  Array.Average();
            Console.WriteLine($"Dizinin elemanlarının ortalaması: {ArrayAvg}");
        }
    }
}

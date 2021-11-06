using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Interview.Sorting
{
    public class FraudulentActivityNotifications
    {
        double Mediana(int[] arr)
        {
            if (arr.Length % 2 == 1)
            {
                return arr[arr.Length / 2];
            }
            else
            {
                int medianIndex = (arr.Length / 2) - 1;
                return (arr[medianIndex] + arr[medianIndex + 1]) / 2.0;
            }
        }
        public int Solve(List<int> expenditure, int d)
        {
            List<int> transactions = new List<int>();
            int counter = 0;
            foreach (var item in expenditure)
            {
                transactions.Add(item);

                if (transactions.Count() == d + 1)
                {
                    int[] t = new int[d];
                    transactions.CopyTo(0, t, 0, d);
                    int lastExp = transactions.Last();
                    
                    
                    System.Array.Sort(t);
                    double m = Mediana(t);
                    if (lastExp >= m * 2)
                    {
                        counter++;
                    }

                    transactions.RemoveAt(0);
                }
            }

            return counter;
        }
    }
    
}

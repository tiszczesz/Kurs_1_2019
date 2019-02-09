using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurs.Primary
{
    public class Parzyste
    {
        public Parzyste(int limit)
        {
            Limit = limit;
        }

        public int Limit { get; set; }

        public List<int> GetParzyste()
        {
            var numbers = new List<int>();
            for (int i = 1; i <= Limit; i++)
            {
                numbers.Add(i*2);
            }
            return numbers;
        }
    }
}

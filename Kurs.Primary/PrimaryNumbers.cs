using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurs.Primary
{
    public class PrimaryNumbers
    {
        
        private int _limit;

        public int Limit
        {
            get { return _limit;}
            set { _limit = value < 2 ? 2 : value; }
        }

        public PrimaryNumbers(int limit)
        {
            Limit = limit;
        }

        public List<int> GetNumbers()
        {
            List<int> numbers = new List<int>();
            for (int i = 2; i <= Limit; i++)
            {
                if(isPrimary(i)) numbers.Add(i);
            }
            return numbers;
        }

        public bool isPrimary(int number)
        {
            if (number < 2) return false;
            for (int i = 2; i * i <= number; i++)
            {
                if (number % i == 0) return false;
            }

            return true;
        }
    }
}

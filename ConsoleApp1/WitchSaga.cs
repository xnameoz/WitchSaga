using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class WitchSaga
    {
        List<Person> list = new List<Person>();
        double average;
        public void Given(int ageOfDate, int yearOfDate)
        {
            list.Add(new Person { AgeOfDate = ageOfDate, YearOfDate = yearOfDate });
        }

        int PeopleKilledOnYear(int year)
        {
            List<string> listNo = new List<string>();

            for(int x = 1; x <= year; x++)
            {
                if (x == 1)
                {
                    listNo.Add("1");
                    continue;
                }
 
                string[] listNoBefore = listNo[x - 2].Split('+');
                listNo.Add(listNo[x - 2] + "+" + (listNoBefore.Length == 1 ? "1" : (Convert.ToInt16(listNoBefore[listNoBefore.Length - 1]) + Convert.ToInt16(listNoBefore[listNoBefore.Length - 2])).ToString()));
            }

            return listNo[listNo.Count - 1].Split('+').Select(Int32.Parse).ToList().Sum();
        }

        public void FindAverage()
        {
            int result = 0;
            foreach (var item in list)
            {
                if (item.YearOfDate - item.AgeOfDate < 1)
                {
                    average = -1;
                    return;
                }

                result += PeopleKilledOnYear(item.YearOfDate - item.AgeOfDate);
            }

            average = ((double)result / (double)list.Count);
        }

        public double Average
        {
            get
            {
                return average;
            }
        }
    }
}

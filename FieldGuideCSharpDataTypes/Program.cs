using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldGuideCSharpDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {

            
            //data type 'int' & multiplication operator
            int experienceYears = 4;
            int trialsPerYear = 5, benchTrials = 3;

            double totalTrials = experienceYears * trialsPerYear + benchTrials;
            Console.WriteLine($"{totalTrials}\n");


            int intMaxValue = int.MaxValue;
            int intMinValue = int.MinValue;

            Console.WriteLine($"{intMaxValue} + {intMinValue}\n");

            char userSelection = 'z';
            char upperVersion = char.ToUpper(userSelection);
            var chars = new[]
{
    'j',
    '\u007A',
    '\x008A',
    (char)109,
};
            Console.WriteLine(string.Join(" ", chars));



            // DateTime yourDateTime = DateTime.UtcNow;
            DateTime myDateTime = DateTime.Now;
            DayOfWeek day = myDateTime.DayOfWeek;
            DateTime yourDay = myDateTime.AddDays(2);
           
            DateTime date1 = DateTime.Now;
            DateTime date2 = DateTime.UtcNow;
            DateTime date3 = DateTime.Today;
            Console.WriteLine($" {myDateTime} + {day} + {yourDay} + {date1} + {date2} + {date3}");

            
            Console.ReadLine();
          
          
        }
    }
}

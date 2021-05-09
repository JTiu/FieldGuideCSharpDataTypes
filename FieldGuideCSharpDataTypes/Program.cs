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

            //max & Min of an int
            int intMaxValue = int.MaxValue;
            int intMinValue = int.MinValue;

            Console.WriteLine($"{intMaxValue} & {intMinValue}\n");

            //use a breakpoint at 29 & 30 to watch 'a' change to 'A'
            char userSelection = 'a';
            char upperVersion = char.ToUpper(userSelection);
            
            Console.WriteLine(upperVersion);



           //testing the usefulness of DateTime
            DateTime myDateTime = DateTime.Now;
            DayOfWeek checkDayOfWeek = myDateTime.DayOfWeek;
            DateTime scheduleEventInTwoDays = myDateTime.AddDays(2);
           
           
           
            Console.WriteLine($" \n{myDateTime} is a {checkDayOfWeek}\n\nyour scheduled event is {scheduleEventInTwoDays}, that is, on {scheduleEventInTwoDays.DayOfWeek}");

            
            Console.ReadLine();
          
          
        }
    }
}

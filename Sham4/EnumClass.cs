using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sham4
{

    using System;

    class EnumClass
    {
        static void Main()
        {
            Weeks today = Weeks.Monday;
            Console.WriteLine($"Today is: {today}");          // Output: Today is: Monday
            Console.WriteLine($"Numeric Value: {(int)today}"); // Output: Numeric Value: 1

            Weeks weekend = (Weeks)6; // Enum from integer
            Console.WriteLine($"Day 6 is: {weekend}");        // Output: Day 6 is: Saturday
        }
    }

    public enum Weeks
    {
        Sunday = 0,
        Monday = 1,
        Tuesday = 2,
        Wednesday = 3,
        Thursday = 4,
        Friday = 5,
        Saturday = 6
    }



}

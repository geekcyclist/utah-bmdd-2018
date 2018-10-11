using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{
    public static class Movement
    {
        public static string Move(string direction)
        {
            string returnValue = string.Empty;
            if (direction == "Up")
            {
                returnValue = "Moved Up";
            }
            else if (direction == "Down")
            {
                returnValue = "Moved Down";
            }
            else if (direction == "Left")
            {
                returnValue = "Moved Left";
            }
            else if (direction == "Right")
            {
                returnValue = "Moved Right";
            }

            return returnValue;
        }
    }
}

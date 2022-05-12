using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    /// <summary>
    /// Class to store data for single route
    /// </summary>
    public class Route
    {
        // Auto-Properties
        public int number { get; set; }
        public string name { get; set; }
        public int length { get; set; }
        public int stopsNumber { get; set; }
        public TimeSpan startTime { get; set; }
        public TimeSpan endTime { get; set; }

        /// <summary>
        /// Constructor with parameters
        /// </summary>
        /// <param name="number">Route number (int)</param>
        /// <param name="name">Route name (string)</param>
        /// <param name="length">Route length (int)</param>
        /// <param name="stopsNumber">Number of stops (int)</param>
        /// <param name="startTime">Route starting time (TimeSpan)</param>
        /// <param name="endTime">Route ending time (TimeSpan)</param>
        public Route(int number, string name, int length, int stopsNumber, TimeSpan startTime, TimeSpan endTime)
        {
            this.number = number;
            this.name = name;
            this.length = length;
            this.stopsNumber = stopsNumber;
            this.startTime = startTime;
            this.endTime = endTime;
        }

        // Overridden method GetHashCode()
        public override int GetHashCode()
        {
            return name.GetHashCode();
        }

        // Overridden method Equals(), check object equality
        public override bool Equals(object obj)
        {
            return Equals(obj as Route);
        }

        public bool Equals(Route other)
        {
            return this.name.Trim() == other.name.Trim();
        }

        /// <summary>
        /// Method for creating a string output from class properties
        /// </summary>
        /// <returns>number, name, length, stopsNumber, startTime and endTime properties concatenated to snigle string</returns>
        public override string ToString()
        {
            return string.Format("{0,4:d2}  {1,-10}  {2,8:d2} {3,8:d2} {4,15} {5,15}", 
                 number, name, length, stopsNumber, startTime, endTime);
        }

        /// <summary>
        /// Compares two routes
        /// </summary>
        /// <param name="r1">the first route</param>
        /// <param name="r2">the second route</param>
        /// <returns>Operators '==' and '!=' compares name
        /// Operators '>' and '<' compares number of stops
        /// Operators '>=' and '<=' compares name and number of stops
        /// </returns>
        public static bool operator >=(Route r1, Route r2)
        {
            int p = string.Compare(r1.name, r2.name, StringComparison.CurrentCulture);
            return r1.stopsNumber > r2.stopsNumber || r1.stopsNumber == r2.stopsNumber && p > 0;
        }

        public static bool operator <=(Route r1, Route r2)
        {
            int p = string.Compare(r1.name, r2.name, StringComparison.CurrentCulture);
            return r1.stopsNumber < r2.stopsNumber || r1.stopsNumber == r2.stopsNumber && p < 0;
        }

        public static bool operator ==(Route r1, Route r2)
        {
            return r1.name.Trim() == r2.name.Trim();
        }

        public static bool operator !=(Route r1, Route r2)
        {
            return r1.name.Trim() != r2.name.Trim();
        }

        public static bool operator >(Route r1, Route r2)
        {
            return r1.stopsNumber > r2.stopsNumber;
        }

        public static bool operator <(Route r1, Route r2)
        {
            return r1.stopsNumber < r2.stopsNumber;
        }
    }
}

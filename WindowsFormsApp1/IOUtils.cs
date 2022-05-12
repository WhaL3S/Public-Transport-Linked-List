using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WindowsFormsApp1
{
    /// <summary>
    /// Class to input data into arrays
    /// </summary>
    class IOUtils
    {
        /// <summary>
        /// Reading txt file
        /// </summary>
        /// <param name="filename"></param>
        /// <param name="header"></param>
        /// <returns></returns>
        public static RoutesLinkedList Read(string filename, ref string header)
        {
            RoutesLinkedList Routes = new RoutesLinkedList();
            using (StreamReader reader = new StreamReader(filename))
            {
                string line = null;
                header = reader.ReadLine().Trim();
                while((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(';');
                    int number = Convert.ToInt32(parts[0]);
                    string name = parts[1];
                    int length = Convert.ToInt32(parts[2]);
                    int stopsNumber = Convert.ToInt32(parts[3]);
                    TimeSpan startTime = TimeSpan.Parse(parts[4]);
                    TimeSpan endTime = TimeSpan.Parse(parts[5]);
                    Route r = new Route(number, name, length, stopsNumber, startTime, endTime);
                    Routes.AddToEnd(r);
                }
            }
            return Routes;
        }
    }
}

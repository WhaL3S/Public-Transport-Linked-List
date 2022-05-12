using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    /// <summary>
    /// Class to do the tasks
    /// </summary>
    class TaskUtils
    {
        /// <summary>
        /// Find the length of selected route
        /// </summary>
        /// <param name="Routes1">First list of routes</param>
        /// <param name="Routes2">Second list of routes</param>
        /// <param name="routeName">Route which length is searched</param>
        /// <returns></returns>
        public static int LengthOfRoute(RoutesLinkedList Routes1, RoutesLinkedList Routes2, string routeName)
        {
            int result = 0;
            for (Routes1.Start(); Routes1.Exists(); Routes1.Next())
                if (Routes1.GetData().name == routeName)
                    result = Routes1.GetData().length;
            for (Routes2.Start(); Routes2.Exists(); Routes2.Next())
                if (Routes2.GetData().name == routeName)
                    result = Routes2.GetData().length;
            return result;
        }

        /// <summary>
        /// Finds and adds routes which undergo conditions of length
        /// </summary>
        /// <param name="Routes">Dynamic array of routes</param>
        /// <param name="ResultRoutes">Resulting array of routes</param>
        /// <param name="a">Lowest value of the interval for length</param>
        /// <param name="b">Highest value of the interval for length</param>
        public static void RoutesWithinInterval(RoutesLinkedList Routes, RoutesLinkedList ResultRoutes, int a, int b)
        {
            for (Routes.Start(); Routes.Exists(); Routes.Next())
            {
                Route r = Routes.GetData();
                if (r.length <= b && r.length >= a)
                {
                    Route newR = new Route(r.number, r.name, r.length, r.stopsNumber, r.startTime, r.endTime);
                    if (ResultRoutes.Contains(newR) == false)
                    {
                        ResultRoutes.AddToEnd(newR);
                    }
                }
            }
            Checker(ResultRoutes, a, b);
        }

        /// <summary>
        /// Checks if there is any route which doesn't undergo length conditions
        /// </summary>
        /// <param name="ResultRoutes">Resulting array of routes</param>
        /// <param name="a">Lowest value of the interval for length</param>
        /// <param name="b">Highest value of the interval for length</param>
        private static void Checker(RoutesLinkedList ResultRoutes, int a, int b)
        {
            for (ResultRoutes.Start(); ResultRoutes.Exists(); ResultRoutes.Next())
            {
                Route r = ResultRoutes.GetData();
                if (r.length > b || r.length < a)
                {
                    ResultRoutes.Remove(r);
                }
            }
        }


        /// <summary>
        /// Finds and adds routes with duration more than inserted into result list
        /// </summary>
        /// <param name="Routes"></param>
        /// <param name="ResultRoutes"></param>
        /// <param name="number"></param>
        public static void RoutesDuration(RoutesLinkedList Routes, RoutesLinkedList ResultRoutes, int number)
        {
            for (Routes.Start(); Routes.Exists(); Routes.Next())
            {
                Route r = Routes.GetData();
                TimeSpan durationTS = r.endTime.Subtract(r.startTime);
                int duration = durationTS.Hours * 60 + durationTS.Minutes;
                if (duration > number)
                {
                    Route newR = new Route(r.number, r.name, r.length, r.stopsNumber, r.startTime, r.endTime);
                    if (ResultRoutes.Contains(newR) == false)
                    {
                        ResultRoutes.AddToEnd(newR);
                    }
                }
            }
            ResultRoutes.Sort();
        }
    }
}

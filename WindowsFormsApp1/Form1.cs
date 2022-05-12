using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        // LinkedLists  
        RoutesLinkedList Routes1;                                       // Linked list for the first data
        RoutesLinkedList Routes2;                                       // Linked list for the second data
        RoutesLinkedList RoutesToInsert;                                // Linked list for inserted data
        RoutesLinkedList ResultRoutes = new RoutesLinkedList();         // Result linked list

        // File names
        private string FileData;         // OpenFileDialog
        private string FileResults;      // SaveFileDialog

        // City names
        string CityName1;                // Name of the first city
        string CityName2;                // Name of the second city
        string CityName3;                // Name of the third city

        /// <summary>
        /// Default constructor (Form1)
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            ToggleControls();
        }

        /// <summary>
        /// Disable (enable) text input, save menu and action menu items
        /// </summary>
        /// <param name="enabled"></param>
        private void ToggleControls(bool enabled = false)
        {
            textBox1.Enabled = enabled;
            saveToolStripMenuItem.Enabled = enabled;
            lengthOfRouteToolStripMenuItem.Enabled = enabled;
            routeWithLengthInIntervalToolStripMenuItem.Enabled = enabled;
            sortByNumberOfStopsToolStripMenuItem.Enabled = enabled;
            removeToolStripMenuItem.Enabled = enabled;
        }

        /// <summary>
        /// Method for displaying route container City data to screen using table format
        /// </summary>
        /// <param name="header">Header</param>
        /// <param name="LB">Listbox</param>
        /// <param name="Routes">Linked list of route data</param>
        private void DisplayRouteToGui(string header, ListBox LB, RoutesLinkedList Routes)
        {
            LB.Items.Add("");
            LB.Items.Add(header);
            LB.Items.Add("----------------------------------------------------------------------------------------------");
            LB.Items.Add("  No Name             Length    Stops     Start time       End time");
            LB.Items.Add("----------------------------------------------------------------------------------------------");
            for (Routes.Start(); Routes.Exists(); Routes.Next())
            {
                Route r = Routes.GetData();
                LB.Items.Add(r.ToString());
            }
            LB.Items.Add("----------------------------------------------------------------------------------------------");
        }

        /// <summary>
        /// Opens menu click handling
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // First file
            openFileDialog1.Title = "Open first initial data file";
            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "Text Files|*.txt|Word Documents|*.doc";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FileData = openFileDialog1.FileName;
                Routes1 = IOUtils.Read(FileData, ref CityName1);
                DisplayRouteToGui(CityName1 + " (initial)", listRoutes, Routes1);
            }
            // Second file
            openFileDialog1.Title = "Open second initial data file";
            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "Text Files|*.txt|Word Documents|*.doc";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FileData = openFileDialog1.FileName;
                Routes2 = IOUtils.Read(FileData, ref CityName2);
                ToggleControls(true);
                DisplayRouteToGui(CityName2 + " (initial)", listRoutes, Routes2);
            }
        }

        /// <summary>
        /// Saves menu click event handling
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Title = "Save your results";
            saveFileDialog1.FileName = "";
            saveFileDialog1.Filter = "Text Files|*.txt|Word Documents|*.doc";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FileResults = saveFileDialog1.FileName;
                using (StreamWriter writer = new StreamWriter(FileResults, false))
                {
                    foreach (string item in listRoutes.Items)
                    {
                        writer.WriteLine(item.ToString());
                    }
                }
            }
        }

        /// <summary>
        /// Closes menu click even handling
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Length of route menu click event handling
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lengthOfRouteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == "")
            {
                MessageBox.Show("Please enter Route's name");
            }
            else
            {
                string routeName = textBox1.Text;
                int lengthOfRoute = TaskUtils.LengthOfRoute(Routes1, Routes2, routeName);
                if (lengthOfRoute > 0)
                {
                    string routeIsFound = string.Format("\n{0}'s length is {1} km", routeName, lengthOfRoute);
                    listRoutes.Items.Add(routeIsFound);
                }
                else
                {
                    string noRouteIsFound = string.Format("\nNo route with name {0} was found ", routeName);
                    listRoutes.Items.Add(noRouteIsFound);
                }
            }
        }

        /// <summary>
        /// Routes with length in interval menu click event handling
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void routeWithLengthInIntervalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (textBox1.Text.Trim() == "")
            {
                MessageBox.Show("Please enter A and B value");
            }
            else
            {
                string line = textBox1.Text;
                string[] parts = line.Split();
                int a = Convert.ToInt32(parts[0]);
                int b = Convert.ToInt32(parts[1]);
                TaskUtils.RoutesWithinInterval(Routes1, ResultRoutes, a, b);
                TaskUtils.RoutesWithinInterval(Routes2, ResultRoutes, a, b);
                if (ResultRoutes.Count != 0)
                {
                    string formatHeader = string.Format("\nRoutes with length in interval [{0};{1}]", a, b);
                    DisplayRouteToGui(formatHeader, listRoutes, ResultRoutes);
                }
                else
                {
                    string noRouteIsFound = string.Format("\nNo route with length in interval [{0};{1}]", a, b);
                    listRoutes.Items.Add(noRouteIsFound);
                }
            }
        }

        /// <summary>
        /// Sorts by number of stops menu click even handling
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sortByNumberOfStopsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ResultRoutes.Count != 0)
            {
                ResultRoutes.Sort();
                DisplayRouteToGui("Sorted by number of stops", listRoutes, ResultRoutes);
            }
            else
            {
                MessageBox.Show("Result list is empty to be sorted");
            }
        }

        /// <summary>
        /// Removes menu click event handling
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == "")
            {
                MessageBox.Show("Please enter a symbol");
            }
            else
            {
                string line = textBox1.Text;
                if (line.Length == 1)
                {
                    if (ResultRoutes.Count != 0)
                    {
                        char symbol = char.Parse(line);
                        string formatHeader = string.Format("\nRoutes with  {0}  are removed ", symbol);
                        ResultRoutes.RemoveALL(symbol); 
                        DisplayRouteToGui(formatHeader, listRoutes, ResultRoutes);
                    }
                    else
                    {
                        string notValidResultContainer = string.Format("\nResult list is empty");
                        listRoutes.Items.Add(notValidResultContainer);
                    }
                }
                else
                {
                    MessageBox.Show("Invalid");
                }

            }
        }

        /// <summary>
        /// Inserts data from the txt file into result list without using sorting method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void insertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Open third initial data file";
            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "Text Files|*.txt|Word Documents|*.doc";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FileData = openFileDialog1.FileName;
                RoutesToInsert = IOUtils.Read(FileData, ref CityName3);
            }
            ResultRoutes.InsertAll(RoutesToInsert);
            DisplayRouteToGui("New data inserted from the city: " + CityName3, listRoutes, ResultRoutes);
        }

        /// <summary>
        /// Routes with duration more than inserted menu click even handling
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void durationMoreThanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == "")
            {
                MessageBox.Show("Please enter a number in minutes");
            }
            else
            {
                string line = textBox1.Text;
                if (Convert.ToInt32(line) > 0)
                {
                    ResultRoutes.Destroy();
                    int number = Convert.ToInt32(line);
                    TaskUtils.RoutesDuration(Routes1, ResultRoutes, number);
                    TaskUtils.RoutesDuration(Routes2, ResultRoutes, number);
                    if(ResultRoutes.Count != 0)
                    {
                        string formatHeader = string.Format("\nRoutes with duration more than {0} minutes", number);
                        DisplayRouteToGui(formatHeader, listRoutes, ResultRoutes);
                    }
                    else
                    {
                        string notValidResultContainer = string.Format("\nThere is no such routes");
                        listRoutes.Items.Add(notValidResultContainer);
                    }
                }
                else
                {
                    MessageBox.Show("Invalid");
                }
            }
        }
    }
}

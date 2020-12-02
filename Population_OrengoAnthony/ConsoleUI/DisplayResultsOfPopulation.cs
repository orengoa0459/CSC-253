using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
  {
    public class DisplayResultsOfPopulation
    {
        public static void DisplayPopulationResults(List<double> population, double finalPop, double initialPop, double growRate, double time,double exp, string input)
        {
            int studyTracker = 1;
            //Displays study title
            Console.WriteLine(PopulationLibrary.StandardMessages.DisplayStudiesTitle());
            //List each element in the List Population
            foreach (var element in population)
            {
                Console.WriteLine($"Lab Study {studyTracker}: {element}");
                studyTracker++;
            }            
            Console.WriteLine(PopulationLibrary.StandardMessages.ReturnToMenu());
            Console.ReadLine();
        }
    }
}

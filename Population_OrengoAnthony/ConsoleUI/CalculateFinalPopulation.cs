using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class CalculateFinalPopulation
    {
        public static void CalculateTheFinalPopulation(List<double> population, double finalPop, double initialPop, double growRate, double time, double exp, double amountOfDays, string input)
        {
            //Set sentinel for each user input to ensure the user inputs a number
            bool populationLoop = false;
            bool growthPercentLoop = false;
            bool dayLoop = false;  

            //Used for current day of study 
            int day = 1;
            double recordInPop = 0;
           

            Console.Clear();
            //Get user to input current bacteria population
            do
            {
                //Displays bacteria population title
                Console.Write(PopulationLibrary.StandardMessages.DisplayBacteriaPopulationTitle());
                //Get user to enter current bacteria population
                Console.Write(PopulationLibrary.StandardMessages.EnterCurrentBacteriaPopulation());
                input = Console.ReadLine();
                if (double.TryParse(input, out initialPop))
                {
                    recordInPop += initialPop;
                    populationLoop = true;
                    Console.Clear();
                }
                else
                {
                    //Displays invalid selection
                    Console.WriteLine(PopulationLibrary.StandardMessages.InvalidSelection());
                    Console.ReadLine();
                    Console.Clear();
                }
                
            } while (populationLoop == false);
            do
            {
                //Displays bacteria population title
                Console.Write(PopulationLibrary.StandardMessages.DisplayBacteriaPopulationTitle());
                Console.WriteLine(PopulationLibrary.StandardMessages.DisplayGrowthRateInst());
                //Get user to input growth percentage
                Console.Write(PopulationLibrary.StandardMessages.EnterGrowthPercentage());
                input = Console.ReadLine();

                if (double.TryParse(input, out growRate))
                {
                    //growRate = growRate / 100;
                    growthPercentLoop = true;
                    Console.Clear();
                }
                else
                {
                    //Displays invalid selection
                    Console.WriteLine(PopulationLibrary.StandardMessages.InvalidSelection());
                    Console.ReadLine();
                    Console.Clear();
                }
            } while (growthPercentLoop == false);
            do
            {
                //Displays bacteria population title
                Console.Write(PopulationLibrary.StandardMessages.DisplayBacteriaPopulationTitle());
                //Get user to input amount of days
                Console.Write(PopulationLibrary.StandardMessages.EnterNumberOfDays());
                input = Console.ReadLine();

                if (double.TryParse(input, out amountOfDays)&& amountOfDays > 0)
                {                    
                        dayLoop = true;                                                         
                }
                else
                {
                    //Displays invalid selection
                    Console.WriteLine(PopulationLibrary.StandardMessages.InvalidSelection());
                    Console.ReadLine();
                    Console.Clear();
                }

            } while (dayLoop == false);
            Console.Clear();

            //Calculate the final bacteria population using the final population formula and display results
            Console.WriteLine(PopulationLibrary.StandardMessages.DisplayResultsTitle(ref amountOfDays));
            for (int x = 0;x < amountOfDays; x++)
            {
                //FinalPopulation = InitialPopulation * e(GrowthRate * Time)
                finalPop = initialPop * Math.Pow(exp,(growRate * time));
                Console.WriteLine($"Day {day}:  {finalPop}");
                initialPop = 0;
                initialPop = initialPop + finalPop;
                day++;                
            }
            //Adds the final population number to the list "population"
            population.Add(finalPop);
            
            Console.WriteLine(PopulationLibrary.StandardMessages.DisplayInitialGrowthDays(ref recordInPop, ref growRate, ref amountOfDays, ref finalPop));
            Console.Write(PopulationLibrary.StandardMessages.ReturnToMenu());
            Console.ReadLine();
        }
    }
}

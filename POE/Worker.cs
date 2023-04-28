using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POE
{
    //----------------------------------------Start---------------------------------------//
    internal class Worker
    {
        //Declaration of Variables and arrays
        int[] Number;
        String[] Ingredient;
        Double[] Quantity;
        String[] Units;
        int[] stepsNum;
        String[] Steps;

        //Method for commencing empty arrays for user input
        public void Recipe()
            {
            Number = new int[0]; 
            Ingredient = new String[0];
            Quantity = new Double[0];
            Units = new String[0];
            Steps = new String[0];
            }

        //Method for asking user for input of recipe details
        public void Details()
        {
            //Asks user to enter the number of ingredients
            Console.WriteLine("Enter number of Ingredients: ");
            int Number = int.Parse(Console.ReadLine());

            //Apples the intended size of arrays
            Ingredient = new string[Number];
            Quantity = new double[Number];
            Units = new string[Number];
            stepsNum = new int[Number];
            Steps = new string[Number]; 

            //Asks user to enter the details of the recipe
            for (int a = 0; a < Number; a++)
            {
                Console.WriteLine("Enter details for ingredient: ");


                Console.WriteLine("Name :");
                Ingredient[a] = Console.ReadLine();//Fills the array with user input
                

                Console.WriteLine("Quantity: ");
                Quantity[a] = double.Parse(Console.ReadLine());//Fills the array with user input

                Console.WriteLine("Enter the measurement Unit: ");
                Units[a] = Console.ReadLine();

                Console.WriteLine("Enter the number of steps: ");
                stepsNum[a] = int.Parse(Console.ReadLine());//Fills the array with user input

                Console.WriteLine("Steps: ");
                Steps[a] = Console.ReadLine();//Fills the array with user input


            }
        }
        //Method to view recipe details
        public void DetailDisplay()
        {
            Console.WriteLine("Recipe Details: ");

            for (int b = 0; b < Ingredient.Length; b++)
            {
                Console.WriteLine($"Ingredients: {Ingredient[b]}");
            }
            for (int c = 0; c < Quantity.Length; c++)
            {
                Console.WriteLine($"Quantity: {Quantity[c]}");
            }
            for (int d = 0; d < Units.Length; d++)
            {
                Console.WriteLine($"Units: {Units[d]}");
            }
            for (int e = 0; e < Steps.Length; e++)
            {
                Console.WriteLine($"Steps: {Steps[e]}");
            }

        }

        //Method to scale quantity
        public void Scaling()
        {
            Console.Write("Enter scale factor (0.5, 2, or 3): ");
            double Scale = double.Parse(Console.ReadLine());

            //for loop for scaling and filling array with the scale amount
            for (int f = 0; f < Scale; f++)
            {
                Quantity[f] = Scale;
            }
            Console.WriteLine("Scaling has been succesfully scaled");
        }
        //Method for resetting Quantities
        public void ResetQuantities()
        {
            // Resets the quantities
            double newQuantity = Convert.ToDouble(Console.ReadLine());

            for (int g = 0; g < Quantity.Length; g++)
            {
                Quantity[g] = newQuantity;
            }
            Console.WriteLine("Quantity has been reset successfully");
        }
        public void ClearData()
        {
            // Reset all the arrays to empty
            Number = new int[0];
            Ingredient = new String[0];
            Quantity = new Double[0];
            Units = new String[0];
            Steps = new String[0];
        }
        //Method for exiting application
        public void Exit()
        {
            System.Environment.Exit(0);
        }
    }//----------------------------------------End---------------------------------------//
}

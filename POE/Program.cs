// See https://aka.ms/new-console-template for more information
using POE;

class Program
{
    static void Main(string[] args)
    {
        //----------------------------------------Start---------------------------------------//
        //Makes the worker class an object
        Worker recipe = new Worker();

        //While loop for creating a menu system that accepts user input
        while (true)
        {
            Console.WriteLine("Enter 1 to add recipe details");//Asks user input
            Console.WriteLine("Enter 2 to view recipe");//Asks user input
            Console.WriteLine("Enter 3 to scale the  recipe");//Asks user input
            Console.WriteLine("Enter 4 to reset the recipe quantity");//Asks user input
            Console.WriteLine("Enter 5 to delete the recipe");//Asks user input
            Console.WriteLine("Enter 6 to exit");//Asks user input

            //Stores user input
            string number = Console.ReadLine();

            //Switch and case for calling methods
            switch (number)
            {
                case "1":
                    recipe.Details();
                    break;
                case "2":
                    recipe.DetailDisplay();
                    break;
                case "3":
                    recipe.Scaling();
                    break;
                case "4":
                    recipe.ResetQuantities(); 
                    break;
                case "5":
                    recipe.ResetQuantities();
                    break;
                    case "6":
                    recipe.Exit();
                    break;
            }

        }
        //----------------------------------------End---------------------------------------//
    }
}
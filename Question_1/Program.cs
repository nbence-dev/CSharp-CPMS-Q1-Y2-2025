namespace Question_1
{
    internal class Program
    {
        
        
        static void Main(string[] args)
        {
            // declare array that will display menu.
            string[] menu = { "1. Add Patient", "2. Remove Patient", "3. Search Patient", "4. Display All Patients", "5. Exit" };

            //array of objects
            const int size = 20;  // To easily change the size
            CPMS[] People = new CPMS[size];

            bool isRunning = true;

            //Run application
            while (isRunning)
            {
                bool isValidChoice = false;
                int choice = 0;
                //Display menu
                displayMenu(menu);

                //Prompt user to enter a choice
                Console.Write("Enter your choice: ");
                //Add validation to ensure user added a number
                try
                {
                    //Convert number to integer
                    choice = int.Parse(Console.ReadLine());

                    if (choice > 0 && choice < 6)
                    {
                        isValidChoice = true;
                    }
                    //If user chooses a number outside the boundary
                    else
                    {
                        Console.WriteLine("You must choose a number from 1 to 5.");
                    }
                    
                }
                catch (FormatException err)
                {
                    Console.WriteLine(err.Message);
                }
                finally 
                {
                    //Increase readability
                    Console.WriteLine();
                }
                //If a valid choice is entered, the user can continue
                if (isValidChoice )
                {
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Sigma");
                            Console.WriteLine();
                            break;
                        case 2:
                            Console.WriteLine();
                            break;
                        case 3:
                            Console.WriteLine();
                            break;
                        case 4:
                            Console.WriteLine();
                            break;
                        case 5:
                            Console.WriteLine();
                            break;
                    }   
                }
                
                

            }
            
        }

        //Function to display menu to add cleanliness to code
        static void displayMenu(string[] menu)
        {
            foreach (string i in menu) 
            {
                Console.WriteLine(i);
            }
            //Increase readability
            Console.WriteLine();
        }
    }

}

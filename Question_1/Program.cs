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
            int counter = 0;
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
                            AddPatient(People);
                            counter++;
                            Console.WriteLine();
                            break;
                        case 2:
                            RemovePatient(People, counter);
                            counter--;
                            break;
                        case 3:
                            Console.WriteLine();
                            break;
                        case 4:
                            DisplayAll(People);
                            //Console.WriteLine();
                            break;
                        case 5:
                            Console.WriteLine("Have a good day!");
                            Environment.Exit(0);
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

        static void AddPatient(CPMS[] People)
        {
            // Get user info
            Console.Write("Enter the patient's name: ");
            string name = Console.ReadLine();
            Console.Write("Enter the patient's age: ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Enter the patient's medical condition: ");
            string medicalCondition = Console.ReadLine();


            CPMS addNew = new CPMS(name, age, medicalCondition);
            for (int i = 0; i < People.Length; i++)
            {
                if (People[i] == null)
                {
                    People[i] = addNew;
                    break;
                }


            }
        }
        static void RemovePatient(CPMS[] People, int counter)
        {
            Console.Write("Enter patient name that you want to remove: ");
            string name = Console.ReadLine();
            for (int i = 0; i < counter; i++)
            {
                if (People[i].Name == name)
                {
                    People[i] = null;
                }
            }
        }

        static void DisplayAll(CPMS[] People)
        {
            foreach (var person in People)
            {
                if (person != null)
                {
                    Console.WriteLine(person.Name);
                    Console.WriteLine();
                }
            }
        }
    }

}

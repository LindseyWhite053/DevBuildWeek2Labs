// Create 3 arrays and fill them with student information—one with name, one with hometown, one with favorite food
string[] students = {"Leslie Knope", "April Ludgate", "Ron Swanson", "Ben Wyatt", "Andy Dwyer"};

string[] hometown = {"Pawnee, Indiana", "Wilmington, Delaware", "Unknown", "Partridge, Minnesota", "Pawnee, Indiana" };

string[] favFood = {"a waffle", "a taco", "bacon", "a calzone", "pizza"};

Console.Write("Welcome! ");


do
{
    //Prompt the user to ask about a particular student by number. 
    Console.WriteLine("Which student would you like to learn more about?");

    
    for (int i = 0; i < students.Length; i++)
    {
        Console.WriteLine($"{i + 1}: {students[i]}");
    }

    bool valid = false;
    int num = 0;


    while (valid == false)
    {
        Console.Write($"Enter a number 1-{students.Length}: ");
        string entry = Console.ReadLine();
        //Convert the input to an integer. Use the integer as the index for the arrays. 
        bool validNum = int.TryParse(entry, out num);

        //Use an if statement to check if the number is out of range, i.e. either less than 1 or greater than the length of the arrays. If so, display a friendly message and let the user try again.
        if (validNum && num >= 1 && num <= 5)
        {
            //Print the selected student’s name.
            Console.Write($"\nStudent {num} is {students[num - 1]}. ");
            valid = true;
        }
        else
        {
            Console.Write("Please enter a valid selection. ");
        }
    }

    Console.WriteLine();
    Console.Write("What would you like to know? ");

    bool validSelection = false;
    while (validSelection == false)
    {
        //Ask the user which category to display: Hometown or Favorite food. Then display the relevant information.
        Console.Write("Enter \"hometown\" or \"favorite food\" to learn more: ");
        string input = Console.ReadLine().ToLower();

        // Use an if statement to check that they entered either category name correctly. If they entered an incorrect category, display a friendly message and re-ask the question. (See hints below!)
        //hint: For the valid category: You might create a separate program to test out some code that uses a while loop and asks for either “Hometown” or “Favorite Food.” And only finishes the loop if either of these two is entered. Once you have it working, copy the code over to your “real” code.
        if (input == "hometown")
        {
            Console.WriteLine($"{students[num - 1]} is from {hometown[num - 1]}.");
            validSelection = true;
        }
        else if (input == "favorite food")
        {
            Console.WriteLine($"{students[num - 1]}'s favorite food is {favFood[num - 1]}.");
            validSelection = true;
        }
        else
        {
            Console.Write("That category does not exist. Please try again. ");
        }

    }

} while (GoAgain());


static bool GoAgain ()
{
    //Ask the user if they would like to learn about another student.
    bool valid = false;
    do
    {
        Console.WriteLine();
        Console.Write("Would you like to learn about another student? (y/n) ");
        string answer = Console.ReadLine().ToLower();


        //confirm if a valid response was given    
        if (answer == "y" || answer == "yes")
        {
            valid = true;
            return true;
        }
        else if (answer == "n" || answer == "no")
        {
            Console.WriteLine("Goodbye");            
            valid = true;
            return false;
  
        } else
        {
            valid = false;
            return false;
            Console.Write("Please enter \"y\" or \"n\" ");
        }

    } while (valid == false);
}

//Extra: Provide an option where the user can see a list of all students. 
//Extra:  Category names: Allow uppercase and lowercase; allow portion of word such as "Food" instead of "Favorite Food"
//Extra Hard Challenge: Allow the user to search by student name (Good challenge but difficult!)
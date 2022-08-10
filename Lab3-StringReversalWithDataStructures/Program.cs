//Write a program that will take in a word from the user and reverse the inputted word.

//Request and take user input 
Console.Write("Enter the word you would like to see reversed: ");
string word = Console.ReadLine();

//Call the method for reversing your string passing in a string 
string revWord = Reverse(word);

//Method for reversing your string which returns a string
static string Reverse(string word)
{
    string newString = "";
    
    //Instantiate a stack
    Stack<char> stackedWord = new Stack<char>();

    //Use the stack to store characters
    foreach (char c in word)
    {
        stackedWord.Push(c);
    }

    //Use the stack to retrieve characters in reverse order
    for (int i = 0; i < word.Length; i++)
    {      
        newString = newString + stackedWord.Pop();
    }
      
    return newString;
}

//Display the reversed string in the console (1 point)
Console.WriteLine($"Your word reversed is {revWord}");



//Extra Challenge: Consider cases where the user does not enter a single word but a sentence instead.
//Do not reverse the entire sentence, instead reverse each word in the sentence, keeping the words in their original positions.


//Extra Challenge: Validate user input: make sure the user is only entering words and not symbols or numbers.



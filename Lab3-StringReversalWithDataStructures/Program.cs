//Write a program that will take in a word from the user and reverse the inputted word.

//Request and take user input 
Console.Write("Enter the phrase you would like to see reversed: ");
string input = Console.ReadLine();

//check if there input is a word or sentence
if (input.Contains(" "))
{
    string revSentence = ReverseSentence(input);

    Console.WriteLine($"Your sentence with reversed words is: ");
    Console.WriteLine(revSentence);
}
else
{
    string revWord = ReverseWord(input);

    Console.WriteLine($"Your word reversed is {revWord}");
}


//Method for reversing your string which returns a string
static string ReverseWord(string baseWord)
{
    string newWord = "";
    
    //Instantiate a stack
    Stack<char> stackedWord = new Stack<char>();

    //Use the stack to store characters
    foreach (char c in baseWord)
    {
        stackedWord.Push(c);
    }

    //Use the stack to retrieve characters in reverse order
    for (int i = 0; i < baseWord.Length; i++)
    {      
        newWord = newWord + stackedWord.Pop();
    }
      
    return newWord;
}


//Method for reversing each word within a string
static string ReverseSentence(string baseString)
{
    string newSentence = "";

    //sentence into words
    string[] words = baseString.Split();

    //for each word in the array reverse the letters 
    foreach (string word in words)
    {
        string newWord = ReverseWord(word);

        // Create a new sentence with the newly reversed words
        newSentence = newSentence + $"{newWord} ";
    }

    return newSentence;
}




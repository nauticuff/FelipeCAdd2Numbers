/*
Carlos Felipe 
10/20/22
Mini Challenge 2 - Add Two Numbers
The code will ask the user to input two numbers
It will then store those numbers as variables
It will finally print out the sum of the two numbers.
*/

Console.Clear();

bool run = true;

Console.WriteLine("This calculator will add two numbers\n");
while(run){
Console.Write("Enter first number: ");
string numOne = Console.ReadLine();

bool isNumOne = Double.TryParse(numOne, out double resultOne);
while(isNumOne == true){
    Console.Write("Enter second number: ");
    string numTwo = Console.ReadLine();
    bool isNumTwo = Double.TryParse(numTwo, out double resultTwo);
    if(isNumTwo == true){
        double answer = resultOne + resultTwo;
        Console.WriteLine("The answer is " + answer);
        Console.Write("\nAdd other numbers?\nType 'YES' or 'NO': ");
        string playChoice = Console.ReadLine().ToUpper();
        while(playChoice != "YES" && playChoice != "NO"){
            Console.WriteLine("I said 'YES' or 'NO'\nTry again: ");
            playChoice = Console.ReadLine().ToUpper();
        }
        if(playChoice == "NO"){
            run = false;
            Console.Write("\nOkay maybe next time");
            break;
        }
        else{
            run = true;
            break;
        }
    }
    else if(isNumTwo == false){
        Console.WriteLine("That is not a number.\nTry again.\n");
    }
}  
if(isNumOne == false){
    Console.WriteLine("That is not a number.\nTry again.\n");
}
}

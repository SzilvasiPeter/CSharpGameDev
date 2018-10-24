class OurProgram
{
    static void Main()
    {
        // Calculate();
        // CalcUserInput();
        System.Console.Write("Please enter a number to be added to 5");
        string userInput = System.Console.ReadLine();
        CalcUserInputParams(userInput);
    }

    // static void Calculate(){
    //     int valueOne = 2;
    //     int valueTwo = 3;
    //     int result;

    //     result = valueOne + valueTwo;
    //     System.Console.WriteLine(result);;
    // }

    // static void CalcUserInput(){
    //     System.Console.WriteLine("Please enter a number to be added ");
    //     int valueFive = 5;
    //     int userInput = System.Convert.ToInt32(System.Console.ReadLine());
    //     int result = valueFive + userInput;
    //     System.Console.WriteLine("That number plus 5 is " + result);
    // }

    static void CalcUserInputParams(string userParams){
        int valueFive = 5;
        int userInput = System.Convert.ToInt32(userParams);
        int result = valueFive + userInput;
        System.Console.WriteLine("That number plus 5 is " + result);
    }
}
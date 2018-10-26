using System;

namespace Practice
{
    class OurProgram
    {
        static void Main()
        {
            // Calculate();
            CalcUserInput();
            // Console.Write("Please enter a number to be added to 5");
            // string userInput = Console.ReadLine();
            // CalcUserInputParams(userInput);
        }

        // static void Calculate(){
        //     int valueOne = 2;
        //     int valueTwo = 3;
        //     int result;

        //     result = valueOne + valueTwo;
        //     Console.WriteLine(result);;
        // }

        static void CalcUserInput(){
            Console.WriteLine("Please enter a number between 1 and 10");
            int userInput= Convert.ToInt32(Console.ReadLine());
            // IF/ELSE
            bool outOfRange = false;
            if(userInput > 1 && userInput < 5){
                Console.Write("That number is between 1 and 5");
            }
            else if(userInput > 5 && userInput < 10){
                Console.Write("That number is between 5 and 10");
            }
            else if (userInput < 1 || userInput > 10){
                outOfRange = true;
                if(outOfRange == true){
                    Console.Write("That number is out of range");
                }
            }
            else{
                Console.Write("That number is 1, 5, or 10");
            }

            // //WHILE loops
            // while(userInput < 10){
            //     userInput += 1;
            //     Console.Write("\n" + userInput + "\n");
            //     if(userInput > 10 || userInput < 1){
            //         break;
            //     }
            // }
            Console.Write("Process Done");
            //FOR loop
            for(int i = userInput; i <= 10; i++){
                Console.Write("\n" + i + "\n");
                if(userInput > 10 || userInput < 1){
                    break;
                }
            }
            Console.Write("Process Done");
        }

        // static void CalcUserInputParams(string userParams){
        //     int valueFive = 5;
        //     int userInput = Convert.ToInt32(userParams);
        //     int result = valueFive + userInput;
        //     Console.WriteLine("That number plus 5 is " + result);
        // }
    }
}
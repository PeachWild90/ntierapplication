using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//CHUNK OF CODE THAT CAN BE REUSED OVER AND OVER
namespace _05_Methods       
{
    class Program
    {
        static void Main(string[] args)
        {
           int sum = AddWholeNumbers(4, 5);
            string input = Console.ReadLine();

            int choice = ParseInput();
        }

        static int AddWholeNumbers(int number1, int number2)
        {
            int number3 = number1 + number2;
            return number3;
        }

        static int ParseInput()
        {
            string inputAsString = Console.ReadLine();
            int input = int.Parse(inputAsString);
            return input;
        }
    }
}

//<Access Specifier> <Return Type> <Method Name>(Parameter List)
//    {
//   Method Body
//    }

//Access Specifier − This determines the visibility of a variable or a method from another class.

//Return type − A method may return a value.The return type is the data type of the value the method returns.If the method is not returning any values, then the return type is void.

//Method name − Method name is a unique identifier and it is case sensitive.It cannot be same as any other identifier declared in the class.

//Parameter list − Enclosed between parentheses, the parameters are used to pass and receive data from a method.The parameter list refers to the type, order, and number of the parameters of a method. Parameters are optional; that is, a method may contain no parameters.

//Method body − This contains the set of instructions needed to complete the required activity
/*#define DEBUG
#define VC_V10
using System;
public class TestClass
{
    public static void Main()
    {
        #if (DEBUG && !VC_V10)
                 Console.WriteLine("DEBUG is defined");
        #elif (!DEBUG && VC_V10)
                 Console.WriteLine("VC_V10 is defined");
        #elif (DEBUG && VC_V10)
                Console.WriteLine("DEBUG and VC_V10 are defined");
        #else
                 Console.WriteLine("DEBUG and VC_V10 are not defined");
        #endif
        Console.ReadKey();
    }
}*/

//Exception Handling
/*using System;
namespace ErrorHandlingApplication
{
    class DivNumbers
    {
        int result;
        DivNumbers()
        {
            result = 0;
        }
        public void division(int num1, int num2)
        {
             try
             {
                result = num1 / num2;
             }
             catch (DivideByZeroException e)
             {
                Console.WriteLine("Exception caught: {0}", e);
             }
             finally
             {
                Console.WriteLine("Result: {0}", result);
             }
        }
        static void Main(string[] args)
        {
            DivNumbers d = new DivNumbers();
            d.division(25,0);
            Console.ReadKey();
        }
    }
}*/

//Creating a user defined exception
using System;
namespace UserDefinedException
{
    class TestTemperature
    {
        static void Main(string[] args)
        {
            Temperature temp = new Temperature();
            try
            {
                temp.showTemp();
            }
            catch (TempIsZeroException e)
            {
                Console.WriteLine("TempIsZeroException: {0}", e.Message);
            }
            Console.ReadKey();
        }
    }
}

public class TempIsZeroException : ApplicationException
{
    public TempIsZeroException(string message)
        : base(message)
    {
    }
}

public class Temperature
{
    int temperature = 0;
    public void showTemp()
    {
        if (temperature == 0)
        {
            throw (new TempIsZeroException("Zero Temperature found"));
        }
        else
        {
            Console.WriteLine("Temperature: {0}", temperature);
        }
    }
}
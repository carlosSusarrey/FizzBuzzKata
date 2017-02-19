namespace FizzBussKata
{
    public class FizzBuzz
    {
        public static string ResultOf(int number)
        {
            var builtResult = "";
            var nonEntered = true;
            if (number % 3 == 0)
            {
                builtResult += "Fizz";
                nonEntered = false;
            }
                
            if (number % 5 == 0)
            {
                builtResult += "Buzz";
                nonEntered = false;
            }

            if (nonEntered)
            {
                builtResult = number.ToString();
            }
            return builtResult;
        }
    }
}
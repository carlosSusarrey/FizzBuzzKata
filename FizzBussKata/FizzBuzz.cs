namespace FizzBussKata
{
    public class FizzBuzz
    {
        public static string ResultOf(int number)
        {
            var builtResult = "";
            var nonEntered = true;
            
            builtResult += BuildResult(number, ref nonEntered, 3, "Fizz");
            builtResult += BuildResult(number, ref nonEntered, 5, "Buzz");

            if (nonEntered)
            {
                builtResult = number.ToString();
            }
            return builtResult;
        }

        private static string BuildResult(int number, ref bool nonFlaged, int checkValue, string word)
        {
            if (number % checkValue != 0 && !number.ToString().Contains(checkValue.ToString()))
            {
                return null;
            }
            var builtResult = word;
            nonFlaged = false;
            return builtResult;
        }
    }
}
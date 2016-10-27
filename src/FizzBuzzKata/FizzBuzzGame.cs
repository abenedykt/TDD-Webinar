namespace FizzBuzzKata
{
    public class FizzBuzzGame
    {
        public string Play(int i)
        {
            if (i % 15 == 0) return "Fizz Buzz";
            if (i % 3 == 0) return "Fizz";
            if (i % 5 == 0) return "Buzz";

            return i.ToString();
        }
    }
}
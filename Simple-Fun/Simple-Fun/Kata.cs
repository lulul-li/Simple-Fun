namespace Simple_Fun
{
    public class Kata
    {
        public string NotSoRandom(double black, double white)
        {
            if (IsEven(black))
            {
                return "White";
            }
            return "Black";
        }

        private static bool IsEven(double black)
        {
            return black % 2 == 0;
        }
    }
}
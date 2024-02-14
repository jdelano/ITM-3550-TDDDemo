namespace MathematicsDemoPrep2024Tests
{
    public class Mathematics
    {
        public bool Prime(int number)
        {
            for (int i = 2; i < number / 2 + 1; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
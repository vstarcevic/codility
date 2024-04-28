namespace Solutions
{
    public class FrogJmp
    {
        public int solution(int X, int Y, int D)
        {
            int possibleSteps = (Y - X) / D;

            while (X + D * possibleSteps < Y)
            {
                possibleSteps++;
            }
            return possibleSteps;
        }
    }
}

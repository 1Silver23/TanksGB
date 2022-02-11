namespace TanksGB.General
{
    public class Calculator:IInput
    {
        public int Multiply(int a, int b)
        {
            return a * b;
        }
    }

    public interface IInput
    {
    }
}

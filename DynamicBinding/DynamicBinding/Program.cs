namespace DynamicBinding
{
    class Program
    {
        static void Main(string[] args)
        {
            dynamic a = 10;
            dynamic b = 5;
            var c = a + b;

            int i = 5;
            dynamic d = i;
            long l = d;
        }
    }
}

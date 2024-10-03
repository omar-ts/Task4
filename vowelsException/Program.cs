namespace vowelsException
{
    internal class Program
    {
        static void print(string x)
        {
            bool vowels = false;
            x.ToCharArray().ToString().ToArray();
            for (int i = 0; i < x.Length; i++)
            {
                if (x[i] == 'a' || x[i] == 'e' || x[i] == 'i' || x[i] == 'o' || x[i] == 'u')
                {
                    vowels = true;
                    break;
                }
            }
            if (vowels)
            {

            }
            else
            {
                throw new Exception();
            }
        }

        static void Main(string[] args)
        {
            string x = "ndhdj";
            try
            {
                print(x);
            }
            catch (Exception e)
            {
                Console.WriteLine("there is no vowels");
            }
        }
    }
}

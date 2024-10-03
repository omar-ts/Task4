using System.Linq.Expressions;

namespace duplicationException
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>() { 1, 1, 2, 3, 4, 5, 5 };
            try
            {
                for (int i = 0; i < list.Count; i++)
                {
                    for (int j = i + 1; j < list.Count; j++)
                    {

                        if (list[i] == list[j])
                        {
                            throw new Exception();
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Duplication founded");
            }
        }
    }
}

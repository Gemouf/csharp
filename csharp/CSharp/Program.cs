

using System.Linq.Expressions;

namespace BaiTap_1
{
    class program
    {
        static void Main(string[] args)
        {
            if (args.Length > 0) // Check if the user entered something
            {
                for (int i = 0; i < args.Length; i++) { Console.Write(args[i]+" "); }
            }
            else
            {
                Console.WriteLine("Hello, Stranger!");
            }
        }
    }
}


//["YEU","HIEU","LAM"]
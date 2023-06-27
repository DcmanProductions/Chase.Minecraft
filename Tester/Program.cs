using Chase.Minecraft;
using System.Text.Json;

namespace Tester
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (MCAuth.Login("drew_cat@live.com", "zRr5x743ySLPnsF", out MCUser user))
            {
                Console.WriteLine(JsonSerializer.Serialize(user));
            }else
            {
                Console.WriteLine("INVALID");
            }
        }
    }
}
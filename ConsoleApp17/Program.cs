using System;
using System.IO;
using System.Diagnostics;
namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            try
            {
                Console.WriteLine("Hello! I am Olshan bot. To view command list use /commands");
                string result, content, name, path, command = "";

                while (command != "/exit")
                {
                    command = Console.ReadLine();
                    switch (command)
                    {

                        case "/color":
                            Console.WriteLine("You can use this colors: Red ,Green, Blue");
                            string color = Console.ReadLine();
                            ChangeColor(color);
                            break;
                        case "/commands":
                            Console.WriteLine("/touch - Create new file\n/git - Open Github.com in Google Chrome\n/TimeDate - date and time\n/exit - close app\n/color - change console color");
                            break;
                        case "/TimeDate":
                            Console.WriteLine(DateTime.Now);
                            break;
                        case "/touch":
                            Console.WriteLine("Choose path");
                            path = Console.ReadLine();
                            Console.WriteLine("file name");
                            name = Console.ReadLine();
                            Console.WriteLine("content");
                            content = Console.ReadLine();
                            if (path.EndsWith(@"\"))
                                result = path + name;
                            else
                                result = path + @"\" + name;

                            File.WriteAllText(result, content);
                            Console.WriteLine("Path:" + result + "\nContent:" + content);
                            break;

                        case "/git":
                            var procStartInfo = new ProcessStartInfo(@"C:\Program Files\Google\Chrome\Application\chrome.exe")
                            {
                                Arguments = "https://github.com/Olshan"
                            };
                            Process.Start(procStartInfo);
                            break;
                        case "/exit":
                            break;


                    }
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
        static void ChangeColor(string color)
        {
            if (color != "red" || color != "green" || color != "blue")
            {
                throw new Exception("Wrong color");
            }
            switch (color)
            {
                case "green":
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case "red":
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case "blue":
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
            }
        }
    }
}

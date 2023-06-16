namespace ConsoleApp78
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "name";
            string password = "0000";
            string menuName = "Custon";
            bool isUserExit = false;
            string userInput;

            Console.WriteLine("Вас приветствует меню \"" + menuName + "\". ");

            while (isUserExit == false)
            {
                const string CommandSetName = "set name";
                const string MenuChangeConsoleColor = "change console color";
                const string CommandConsoleColorBlue = "blue";
                const string CommandConsoleColorGreen = "green";
                const string CommandConsoleColorWhite = "white";
                const string CommandSetPassword = "set password";
                const string CommandWriteName = "write name";
                const string CommandExitProgram = "exit";

                Console.WriteLine("Куда вы хотите зайти?");
                Console.WriteLine(CommandSetName + " - создать имя.");
                Console.WriteLine(MenuChangeConsoleColor + " - изменить цвет консоли.");
                Console.WriteLine(CommandSetPassword + " - создать пароль.");
                Console.WriteLine(CommandWriteName + " - показать созданное имя (требуется пароль).");
                Console.WriteLine(CommandExitProgram + " - выйти из программы.");
                userInput = Console.ReadLine();

                switch (userInput)
                {
                    case CommandSetName:
                        Console.Write("Какое будет ваше имя:");
                        name = Console.ReadLine();
                        break;

                    case MenuChangeConsoleColor:
                        Console.WriteLine("Каким будет цвет консоли:");
                        Console.WriteLine(CommandConsoleColorBlue + " - голубой.");
                        Console.WriteLine(CommandConsoleColorGreen + " - зелёный.");
                        Console.WriteLine(CommandConsoleColorWhite + " - белый.");
                        userInput = Console.ReadLine();

                        if (userInput == CommandConsoleColorBlue)
                        {
                            Console.BackgroundColor = ConsoleColor.Blue;
                        }
                        else if (userInput == CommandConsoleColorGreen)
                        {
                            Console.BackgroundColor = ConsoleColor.Green;
                        }
                        else if (userInput == CommandConsoleColorWhite)
                        {
                            Console.BackgroundColor = ConsoleColor.White;
                        }
                        break;

                    case CommandSetPassword:
                        Console.Write("Какой будет пароль:");
                        password = Console.ReadLine();
                        break;

                    case CommandWriteName:
                        Console.WriteLine("Введите пароль:");
                        userInput = Console.ReadLine();

                        if (userInput == password)
                        {
                            Console.WriteLine("Ваше заданное имя - " + name + ".");
                        }
                        else
                        {
                            Console.WriteLine("Вы ввели неправильный пароль.");
                        }
                        break;

                    case CommandExitProgram:
                        isUserExit = true;
                        break;

                    default:
                        Console.WriteLine("Вы ввели неправильную команду.");
                        break;
                }
            }
        }
    }
}
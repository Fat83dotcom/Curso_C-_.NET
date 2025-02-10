
namespace EditorHTML
{
    public static class Menu
    {
        public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Black;
            DrawScreen();
            WriteOptions();

            var str = Console.ReadLine();
            
            short option = short.Parse(s: str);
            HandleMenuOptions(option);

        }

        internal static void DrawUpAndDownLines(int width)
        {
            Console.Write('+');
            for (int i = 0; i <= width; i++)
            {
                Console.Write('-');
            }

            Console.Write('+');
            Console.Write('\n');
        }

        internal static void DrawnBodyLines(int height)
        {
            for (int lines = 0; lines < height; lines++)
            {
                Console.Write('|');
                for (int i = 0; i <= 30; i++)
                {
                    Console.Write(' ');
                }
                Console.Write('|');
                Console.Write('\n');
            }
        }
         
        public static void DrawScreen()
        {
            DrawUpAndDownLines(30);
            DrawnBodyLines(10);
            DrawUpAndDownLines(30);
        }

        public static void WriteOptions()
        {
            Console.SetCursorPosition(10, 2);
            Console.Write("Editor Html");

            Console.SetCursorPosition(10, 3);
            Console.Write("===========");
            
            Console.SetCursorPosition(3, 4);
            Console.Write("Selecione uma opção abaixo:");
                
            Console.SetCursorPosition(3, 5);
            Console.Write("1 - Novo Arquivo");

            //Console.SetCursorPosition(3, 6);
            //Console.Write("2 - Abrir arquivo");

            Console.SetCursorPosition(3, 7);
            Console.Write("2 - Sair");
            
            Console.SetCursorPosition(3, 8);
            Console.Write("Opção: ");

            Console.SetCursorPosition(10, 8);
        }

        public static void HandleMenuOptions(short option)
        {
            switch(option)
            {
                case 1: Editor.Show();
                    break;
                case 2:
                    {
                        Console.Clear();
                        Environment.Exit(0);
                        break;
                    }
                default:
                    Show();
                    break;
            }
        }
    }
}

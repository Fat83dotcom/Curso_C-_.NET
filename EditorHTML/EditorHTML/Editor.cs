
using System.Text;

namespace EditorHTML
{
    public static class Editor
    {
        public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("Modo Editor");
            Console.WriteLine("-----------");
            Start();
        }

        public static void Start()
        {
            StringBuilder file = new();

            do
            {
                file.Append(Console.ReadLine());
                file.Append(Environment.NewLine);
            }
            while (Console.ReadKey().Key != ConsoleKey.Escape);

            Console.WriteLine("-----------");
            Console.WriteLine("_Deseja salvar o arquivo?[S/N]");
            var option = Console.ReadLine();
            if (option != null && option.Length == 1)
            {
                option = option.ToUpper();
                SaveFile(option, file);
            }

        }

        public static void SaveFile(string option, StringBuilder file)
        {
            if (option == "S")
            {
                try
                {
                    string nameFile =  Guid.NewGuid().ToString();

                    string pathFile = $"C:\\Users\\ferna\\OneDrive\\Área de Trabalho\\{nameFile}.txt";

                    using StreamWriter writer = new(pathFile);
                    {
                        writer.Write(file.ToString());
                    }
                    Console.WriteLine("Arquivo salvo com sucesso.");
                    Thread.Sleep(3000);
                    Viewer.Show(file.ToString());
                }
                catch
                {
                    Console.WriteLine("Erro: Não foi possovel salvar o arquivo.");
                }
            }
            else
            {
                Menu.Show();
            }
        }
    }
}

namespace POOExercicies.ContentContext
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IList<Article> articles = [];
            //articles.Add(new Article("Artigo de teste", "teste-article"));

            //do
            //{
            //    string? title;
            //    string? url;
            //    Console.WriteLine("Digite o titulo: ");
            //    title = Console.ReadLine();
            //    Console.WriteLine("Digite a url: ");
            //    url = Console.ReadLine();
            //    Console.WriteLine("Tecle Enter para continuar ou ESC para sair:");
            //    articles.Add(new Article(title, url)); 
            //}
            //while (Console.ReadKey().Key != ConsoleKey.Escape );

            //foreach (var item in articles)
            //{
            //    Console.WriteLine(item.Id);
            //    Console.WriteLine(item.Title);
            //    Console.WriteLine(item.Url);
            //}

            // Cria os cursos
            Course c1 = new("Curso .Net", "Curso-dot-net")
            {
                Level = Enums.EContentLevel.Advanced
            };
            Course c2 = new("Curso C sharp", "Curso-c-Sharp")
            {
                Level = Enums.EContentLevel.Intermediary
            };
            Course c3 = new("Curso POO", "Curso-POO")
            {
                Level = Enums.EContentLevel.Beginner
            };

            // Cria os items da carreira
            CarrerItem crI3 = new(1, "Carreira POO", "Inicie aqui", c3);
            CarrerItem crI1 = new(3, "Carreira .Net", ".Net", c1);
            CarrerItem crI2 = new(2, "Carreira C Sharp", "C Sharp", c2);

            // cria uma carreira
            Carrer carr = new("Especialista .Net", "nova-carreira-dotnet");
            carr.Items.Add(crI1);
            carr.Items.Add(crI2);
            carr.Items.Add(crI3);

            Console.WriteLine(carr.Title);
            foreach (var item in carr.Items.OrderBy(x=>x.Order))
            {
                Console.WriteLine(
                    $"{item.Order} - {item.Title} - {item.Description} - {item?.Course?.Title} - {item?.Course?.Level}"
                );
            }
        }
    }
}
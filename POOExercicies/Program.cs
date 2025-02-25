﻿using POOExercicies.SubscriptionContext;

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

            Console.WriteLine(crI1.IsInvalid);
            Console.WriteLine(crI2.IsInvalid);
            Console.WriteLine(crI3.IsInvalid);

            // cria uma carreira
            Carrer carr = new("Especialista .Net", "nova-carreira-dotnet");
            carr.Items.Add(crI1);
            carr.Items.Add(crI2);
            carr.Items.Add(crI3);

            Console.WriteLine(carr.Title);
            foreach (var item in carr.Items.OrderBy(x => x.Order))
            {
                Console.WriteLine(
                    $"{item.Order} - {item.Title} - {item.Description} - {item?.Course?.Title} - {item?.Course?.Level}"
                );
                if (item.IsInvalid)
                {
                    foreach (var notification in item.Notifications)
                    {
                        Console.WriteLine($"A classe {notification.Property} enviou uma notificação: {notification.Message}");
                    }
                }
            }
            User us1 = new()
            {
                UserName = "Test",
                Password = "Test",
            };
            Student st1 = new(us1, "Teste_1", "Teste@test.mail.com");
            Student st2 = new(us1, "Teste_2", "tedste@gmail.com");

            Plan pl1 = new("Plano Basico", 1899.99m);
            PayPalSubscription payPalSub = new()
            {
                Plan = pl1,
                EndDate = DateTime.Now.AddYears(1),
            };

            st1.CreateSubscription(payPalSub);
            st1.CreateSubscription(payPalSub);

            foreach (var item in st1.Subscriptions)
            {
                Console.WriteLine($"{item.Plan.Title} - {item.Plan.Price} - {item.EndDate} - {item.IsActive}");
                foreach (var notificastions in st1.Notifications)
                {
                    Console.WriteLine(notificastions.Message);
                }
            }
        }
    }
}

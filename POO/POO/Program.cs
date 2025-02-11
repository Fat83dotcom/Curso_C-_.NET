using System.ComponentModel;
using System.Net.NetworkInformation;

namespace POO
{
    public class Program
    {
        static void Assigned()
        {
            Console.WriteLine("Assinou");
        }

        public static void Main(string[] args)
        {
            DateTime dateDueDate = new(2025, 2, 11, 23, 59, 59);

            // Para garantir que o destrutor seja chamado.
            using CreditCardPayment payment = new(dateDueDate) { NumberCard = 457887745 };

            payment.Pay();
            Person p1 = new();

            p1 = new Personal(); // Up Cast, passa propriedade dos filhos para o pai.

            Corporate p3 = new();
            Person p2 = new();

            //p3 = (Corporate)p2;// Down Cast, Passa propriedade do pai para os filhos.

            Person p4 = new()
            {
                Id = 1,
                Name = "Fernando Mendes"
            };
            Personal p5 = new()
            {
                Id = 2,
                Name = "Fernando Mendes"
            };
            Console.WriteLine(p4.Equals(p5));

            Person.Assing p6 = new(Assigned); // Delegando a assinatura para p6
            p6();

            Room room = new(4);
            room.RoomSoldOutEvent += OnRoomSoldOut;
            room.ReserveSeat();
            room.ReserveSeat();
            room.ReserveSeat();
            room.ReserveSeat();
            room.ReserveSeat();
        }

        private static void OnRoomSoldOut(object? sender, EventArgs e)
        {
            Console.WriteLine("Não há assentos disponiveis");
        }

        public class Payment(DateTime paymentDueDate) : IDisposable
        {
            protected DateTime PaymentDate { get; set; } = DateTime.Now;
            public DateTime PaymentDueDate { get; set; } = paymentDueDate;
            public string? Status { get; set; }

            public virtual void Pay() // metodo polimorfico.
            {

            }

            protected bool VerificatedDate()
            {
                return PaymentDueDate > PaymentDate;
            }

            public void Dispose() // Destrutor.
            {
                Console.WriteLine("Executa alguma ação na destruiçao do objeto");
            }
        }

        public class CreditCardPayment(DateTime paymentDueDate) : Payment(paymentDueDate) // passando um argumento para o pai.
        {
            public int NumberCard { get; set; }

            public override void Pay() // sobrescreve o metodo Pay.
            {
                if (VerificatedDate())
                {
                    Console.WriteLine(PaymentDate);
                    Console.WriteLine($"Número do cartão: {NumberCard}");
                }
                else
                {
                    Console.WriteLine("Não é possivel pagar apos o vencimento.");
                }
            }
        }

        public interface IPayment : IDisposable
        {
            DateTime PaymentDate { get; set; }
            DateTime PaymentDueDate { get; set; }
            string? Status { get; set; }
            void Pay(DateTime paymentDueDate);
            void VerificatedDate();
            new void Dispose();
        }

        public class Person : IEquatable<Person>
        {
            public string? Name { get; set; }
            public int Id { get; set; }

            public delegate void Assing(); // delega para outro ponto do codigo.

            public bool Equals(Person? other)
            {
                return Id == other?.Id;
            }
        }

        public class Personal : Person
        {
            public int CPF { get; set; }
        }

        public class Corporate : Person
        {
            public int CNPJ { get; set; }
        }

        public class Room(int seats)
        {
            public int Seats { get; set; } = seats;
            private int SeatsInUse = 0;

            public void ReserveSeat()
            {
                SeatsInUse++;
                if (SeatsInUse > Seats)
                {
                    OnRoomSoldOut(EventArgs.Empty);
                }
                else
                {
                    Console.WriteLine("Assento reservado.");
                }
            }

            public event EventHandler? RoomSoldOutEvent;

            protected virtual void OnRoomSoldOut(EventArgs e)
            {
                RoomSoldOutEvent?.Invoke(this, e);
            }
        }
    }
}
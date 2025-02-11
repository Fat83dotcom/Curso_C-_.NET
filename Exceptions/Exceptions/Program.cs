using System;

namespace Exceptionss
{
    public class Program
    {

        static void Main()
        {
            int[] arr = [1, 2, 3];

            try
            {
                Meth("");
                Saver("");
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine(arr[i]);
                }
            }
            catch (RegisterDateException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.Date);
            }
            catch(IndexOutOfRangeException e)
            {
                // Os erros são tratados dos mais especificos para os mais genericos
                Console.WriteLine(e.Message.ToString());
                Console.WriteLine("Não foi possivel encontrar o indice");
            }
            catch (ArgumentNullException e)
            {
                // captura o erro lançado pelo throw
                Console.WriteLine(e.StackTrace); // melhor para depuraçao
                Console.WriteLine(e.InnerException);
                Console.WriteLine(e.Message.ToString()); // mostra a mensagem que foi definida no lançamento
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message.ToString());
                // exibe uma mensagem mais amigavel para o usuario.
            }
            finally
            {
                Console.WriteLine("Chegou ao fim");
            }
        }

        private static void Saver(string fileName)
        {
            if (string.IsNullOrEmpty(fileName))
            {
                // lança um erro quando o arquivo é vazio ou nulo
                throw new ArgumentNullException(nameof(fileName), "O filename não pode ser vazio ou nulo.");
            }
        }

        private static void Meth(string fileName)
        {
            if (string.IsNullOrEmpty(fileName))
            {
                throw new RegisterDateException(DateTime.Now);
            }
        }

        // excessão personalizada
        public class RegisterDateException(DateTime date) : Exception
        {
            public DateTime Date { get; private set; } = date;
            public override String Message => "Data e hora do erro: ";
        }
    }
}
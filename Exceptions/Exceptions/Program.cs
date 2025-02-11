namespace Exceptionss
{
    public class Program
    {
        static void Main()
        {
            int[] arr = [1, 2, 3];

            try
            {
                Saver("");
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine(arr[i]);
                }
            }
            catch(IndexOutOfRangeException e)
            {
                // Os erros são tratados dos mais especificos para os mais genericos
                Console.WriteLine(e.Message.ToString());
                Console.WriteLine("Não foi possivel encontrar o indice");
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine(e.Message.ToString());
                // captura o erro lançado pelo throw
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message.ToString());
                // exibe uma mensagem mais amigavel para o usuario.
            }
        }

        private static void Saver(string filename)
        {
            if (string.IsNullOrEmpty(filename))
            {
                // lança um erro quando o arquivo é vazio ou nulo
                throw new ArgumentNullException("O arquivo não pode ser vazio ou nulo.");
            }
        }
    }
}
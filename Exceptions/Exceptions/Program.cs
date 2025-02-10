namespace Exceptionss
{
    public class Program
    {
        static void Main()
        {
            int[] arr = [1, 2, 3];

            try
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine(arr[i]);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message.ToString());
                // exibe uma mensagem mais amigavel para o usuario.i
            }
        }
    }
}
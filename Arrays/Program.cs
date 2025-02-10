
namespace Array
{
    public class Program
    {
        private static void Main(string[] args)
        {
            // incicializando arrays.
            int[] array = new int[5];
            string[] array2 = new string[5];
            float[] array3 = new float[5];

            // atribuindo valores na inicialização.
            int[] array4 = [23, 54, 765, 12, 43];
            string[] array5 = ["C#", "é muito", "bom", "para", "carai"];
            Test[] array6 = [new Test(), new Test()];

            // atribuindo valores aos arrays.
            array[0] = 78;
            array2[0] = "Fernando";
            array3[0] = 78.09f;

            //lendo os elementos do array.
            for (int i = 0; i < array4.Length; i++)
            {
                Console.WriteLine(array4[i]);
            }
            //lendo os elementos do array
            for (int i = 0; i < array5.Length; i++)
            {
                Console.WriteLine(array5[i]);
            }
            // atribuindo um guild para um id.
            for (int i = 0; i < array6.Length; i++)
            {
                array6[i] = new Test()
                {
                    Id = Guid.NewGuid()
                };
            }
            //lendo os elementos do array.
            for (int i = 0; i < array6.Length; i++)
            {
                Console.WriteLine(array6[i].Id);
            }

            // Copiando arrays.
            int[] array7 = array4;
            array4[0] = 45;
            Console.WriteLine(array7[0]); // arrays são objetos de referencia, uma modificação no array4 reflete no array7.

            array4.CopyTo(array7, 0); // copia o valor do array4 na  posição 0 para o array7 na posição 0.
            Console.WriteLine(array7[0]);

            int[] array8 = (int[])array4.Clone(); // Cria uma copia raza do array.
            foreach (int i in array8)
            {
                Console.WriteLine(i);
            }
        }
    }

    public struct Test(Guid id)
    {
        public Guid Id = id;
    }

}
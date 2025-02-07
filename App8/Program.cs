var id = Guid.NewGuid();

var text = string.Format("O Guid gerado foi {0}", id);
var text2 = $"O Guid gerado foi {id}."; // Tipo mais usado de interpolaçao

Console.WriteLine(text);
Console.WriteLine(text2);

string text3 = "Testando";
Console.WriteLine(text3.CompareTo("Testando")); // Compara dua strings, retorna 0 se iguais e outro
                                                // se não.

string text4 = "Testando2";
Console.WriteLine(text4.Contains("do2")); // Verifica se a string passada esta contida na string
                                          // \\comparada, retorn True para sim.

string text5 = "Aqui é um texto.";
Console.WriteLine(text5.StartsWith("aqui é", StringComparison.OrdinalIgnoreCase));
// Verifica se o arquivo inicia com a string passada e Ignora o case sensitive.

Console.WriteLine(text5.StartsWith("aqui é"));
// Case sensitive.

Console.WriteLine(text5.EndsWith("xto."));
// Verifica se o aquivo termina com a string passada. StringComparison pode ser usado.
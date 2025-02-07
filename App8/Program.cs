using System.Net.Http.Headers;

var id = Guid.NewGuid();

var text = string.Format("O Guid gerado foi {0}", id);
var text2 = $"O Guid gerado foi {id}."; // Tipo mais usado de interpolaçao.

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

string text6 = "Será que é igual?";
Console.WriteLine(text6.Equals("Será que é igual?"));
// Retorna True.

Console.WriteLine(text6.Equals("Acho que não."));
// Retorna False.

string text7 = "Este texto é um teste.";
Console.WriteLine(text7.IndexOf('x'));
// Retorna a posição da letra passada no inde of.

Console.WriteLine(text7.LastIndexOf('t'));
// Retorna a posição a ultima ocorrencia da letra.

Console.WriteLine(text7.ToLower());
// Retorna todas minusculas.

Console.WriteLine(text7.ToUpper());
// Retorna maiusculas.

Console.WriteLine(text7.Insert(5, " aqui foi um texto "));
// Insere uma string nã posição especificada.

Console.WriteLine(text7.Remove(5, 5));
// Remove as strings iniciando no index especificado no primeiro parametro
// e remove os proximos carateres especificados no segundo parametro.

Console.WriteLine(text7.Length);
// Retorna a quantidade de caracteres da string.

for (int i = text7.Length - 1 ; i >= 0; i--)
{
    Console.WriteLine(text7[i]);
}

string text8 = "Mais um teste muito foda";
Console.WriteLine(text8.Replace("o", "0"));
// Substitui o valor do primeiro argumento pelo valor do segundo.

string[] division = text8.Split(" ");

foreach (string s in division)
    Console.WriteLine(s);

string text9 = "C# é uma liguagem de programação phoda.";
string result = text9.Substring(0, 8);
// Fatia uma string a partir do indice do primeiro argumento
// até o segundo, excluindo o segundo
Console.WriteLine(result);

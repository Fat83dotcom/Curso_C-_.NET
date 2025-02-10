using System.Globalization;

decimal value = 66.52m;

// Modifica a forma que o ponto decimal é mostrado
CultureInfo culture = CultureInfo.CreateSpecificCulture("pt-BR");
Console.WriteLine(value.ToString("C", culture)); // o formatador "C" ja coloca o tipo da moeda
// formatadores para decimal
// G => Generico
// F => Maior Precisão
// N => Número sem formataçaõ de moeda
// P => Porcentagem

Console.WriteLine(Math.Round(value, 1)); // arredonda o numero.
Console.WriteLine(Math.Ceiling(value)); // arredonda para cima
Console.WriteLine(Math.Floor(value)); // arredonda para baixo



using System.Globalization;

DateTime date = new(); // Inicializa uma struct com os atributos de data.
Console.Clear();
Console.WriteLine(date);

date = DateTime.Now; // Retorna a data atual.
Console.WriteLine(date);
Console.WriteLine("");

DateTime date2 = new(2025, 2, 10, 7, 0, 0, DateTimeKind.Local); // Cria uma data manualmente.

// Mostra cada tipo de data
Console.WriteLine(date2.Year);
Console.WriteLine(date2.Month);
Console.WriteLine(date2.Day);
Console.WriteLine(date2.Hour);
Console.WriteLine(date2.Minute);
Console.WriteLine(date2.Second);
Console.WriteLine(date2.Kind);
Console.WriteLine("");

// Obtendo as datas por formatação
string dateFormated = String.Format("{0:yy}", date2); // mostra o ano com 2 digitos.
Console.WriteLine(dateFormated);
dateFormated = String.Format("{0:yyyy}", date2); // mostra o ano com 4 digitos.
Console.WriteLine(dateFormated);
dateFormated = String.Format("{0:m}", date2); // mostra o mes por extenso e o dia.
Console.WriteLine(dateFormated);
dateFormated = String.Format("{0:dd}", date2); // mostra o dia.
Console.WriteLine(dateFormated);
dateFormated = String.Format("{0:dd/MM/yyyy}", date2); // mostra a data formatada completa.
Console.WriteLine(dateFormated);
dateFormated = String.Format("{0}", date2); // mostra a data no formato padrao.
Console.WriteLine(dateFormated);
Console.WriteLine("");

// preformatação
dateFormated = String.Format("{0:t}", date2); // mostra a hora no formato curto.
Console.WriteLine(dateFormated);
dateFormated = String.Format("{0:d}", date2); // mostra somente a data.
Console.WriteLine(dateFormated);
dateFormated = String.Format("{0:T}", date2); // mostra a hora no formato longo.
Console.WriteLine(dateFormated);
dateFormated = String.Format("{0:D}", date2); // mostra a data e hora no formato padrao com o dia da semana.
Console.WriteLine(dateFormated);
dateFormated = String.Format("{0:g}", date2); // mostra a data e hora no formato curto.
Console.WriteLine(dateFormated);
dateFormated = String.Format("{0:f}", date2); // mostra a data e hora no formato padrao com dia da semana.
Console.WriteLine(dateFormated);
Console.WriteLine("");

dateFormated = String.Format("{0:r}", date2); // mostra a data no formato universal.
Console.WriteLine(dateFormated);
dateFormated = String.Format("{0:s}", date2); // mostra a data no formato para bancos de dados.
Console.WriteLine(dateFormated);
dateFormated = String.Format("{0:u}", date2); // mostra a data no formato json com time zone.
Console.WriteLine(dateFormated);
Console.WriteLine("");

// metodos para manipular (Somar ou subtrair) data
Console.WriteLine(date2.AddDays(24)); // adicionar 24 dias a data.
Console.WriteLine(date2.AddMonths(2)); // adicionat 2 meses a data .
Console.WriteLine(date2.AddYears(1));  // adicionar 1 ano a data.
Console.WriteLine(date2.AddHours(44)); // adicionar 44 horas a data.
Console.WriteLine(date2.AddMinutes(24)); // adicionar 24 minutos a data.
Console.WriteLine(date2.AddSeconds(115)); // adicionar 115 segundos a data.
Console.WriteLine("");

// comparação de datas
DateTime date3 = DateTime.Now;

if (date3.Date == DateTime.Now.Date) // compara somente a data, eliminando o restante dos elementos.
{
    Console.WriteLine("True");
}

date3 = date3.AddDays(1);

if (date3.Date > DateTime.Now.Date) // compara se a data3 é maior que a data atual.
{
    Console.WriteLine("True");
}

Console.WriteLine("");

// culture info
CultureInfo pt = new("pt-PT");
CultureInfo br = new("pt-BR");
CultureInfo en = new("en-US");
CultureInfo de = new("de-DE");
CultureInfo atual = CultureInfo.CurrentCulture;

Console.WriteLine(DateTime.Now.ToString("D", pt));
Console.WriteLine(DateTime.Now.ToString("D", br));
Console.WriteLine(DateTime.Now.ToString("D", en));
Console.WriteLine(DateTime.Now.ToString("D", de));
Console.WriteLine(DateTime.Now.ToString("D", atual));

Console.WriteLine("");

//  timezone
DateTime utcDate = DateTime.UtcNow;
Console.WriteLine(utcDate);
Console.WriteLine(utcDate.ToLocalTime());

TimeZoneInfo timeZoneAutralia = TimeZoneInfo.FindSystemTimeZoneById("Pacific/Auckland");
DateTime horaAustralia = TimeZoneInfo.ConvertTimeFromUtc(utcDate, timeZoneAutralia);

Console.WriteLine(String.Format("{0:r}", horaAustralia));

var allTimeZones = TimeZoneInfo.GetSystemTimeZones();

foreach (var timeZone in allTimeZones)
{
    Console.WriteLine(timeZone.Id);
    Console.WriteLine(timeZone);
    Console.WriteLine(TimeZoneInfo.ConvertTimeFromUtc(DateTime.Now.ToUniversalTime(), timeZone));
    Console.WriteLine("-----------------------");
}
Console.WriteLine("");

// timespan
TimeSpan nano = new(1);
Console.WriteLine(nano);

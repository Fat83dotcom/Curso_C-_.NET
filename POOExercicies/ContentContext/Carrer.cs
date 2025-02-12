namespace POOExercicies.ContentContext
{
    public class Carrer(string? title, string? url) : Content(title, url)
    {
        public IList<CarrerItem> Items { get; set; } = [];
        public int TotalCourses => Items.Count; // retorna a contagem dos items com expression body (=>)
    }
}

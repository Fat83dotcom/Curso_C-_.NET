namespace POOExercicies.ContentContext
{
    public class CarrerItem
    {
        public CarrerItem(int order, string? title, string? description, Course course)
        {
            Order = order;
            Title = title;
            Description = description;
            Course = course;
        }

        public int Order { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
            
        public Course? Course
        {
            get;
            set
            {
                if (value != null)
                {
                    Console.WriteLine("passou aqui");
                    field = value;
                }
                else
                {
                    throw new ArgumentNullException(nameof(value), "O curso não pode ser nulo.");
                }
            }
        }
    }
}

using POOExercicies.SharedContext;

namespace POOExercicies.ContentContext
{
    public class CarrerItem : Base
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
                    field = value;
                }
                else
                {
                    AddNotification(new("Course", "Curso não pode ser nulo"));
                }
            }
        }
    }
}

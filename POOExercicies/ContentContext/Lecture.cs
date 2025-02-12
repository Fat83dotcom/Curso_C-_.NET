using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POOExercicies.ContentContext.Enums;

namespace POOExercicies.ContentContext
{
    public class Lecture
    {
        public int Order { get; set; }
        public string? Title { get; set; }
        public int DurationInMinutes { get; set; }
        public EContentLevel Level { get; set; }
    }
}

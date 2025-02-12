using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POOExercicies.ContentContext.Enums;

namespace POOExercicies.ContentContext
{
    public class Course(string? title, string? url) : Content(title, url)
    {
        public string? Tags { get; set; }
        public EContentLevel Level { get; set; }
        public IList<Module> Modules { get; set; } = [];
    }
}

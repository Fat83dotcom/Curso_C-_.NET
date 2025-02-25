﻿using POOExercicies.ContentContext.Enums;
using POOExercicies.SharedContext;

namespace POOExercicies.ContentContext
{
    public class Module : Base
    {
        public int Order { get; set; }
        public string? Title { get; set; }
        public IList<Lecture> Lectures { get; set; } = [];
        public EContentLevel Level { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace CodeSquirl.Recipy.Model
{
    public class Recipy
    {
        public Guid ID { get; set; }

        public string Name { get; set; } = string.Empty;

        public RecipyType Type { get; set; } = RecipyType.Undefined;

        public DietType Diet { get; set; } = DietType.All;

        public IList<Ingredient> Ingredients { get; set; } = new List<Ingredient>();

        public IList<InstructionBase> Instructions { get; set; } = new List<InstructionBase>();

        public TimeSpan Duration { get; set; } = new TimeSpan();

        public Guid UserID { get; set; }

        public bool AllowRemnants { get; set; }

        public bool Deleted { get; set; }
    }
}

using System;

namespace CodeSquirl.Recipy.Model
{
    public class Necessity
    {
        public Guid ID { get; set; } = Guid.NewGuid();

        public string Name { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public bool Electrical { get; set; }
    }
}

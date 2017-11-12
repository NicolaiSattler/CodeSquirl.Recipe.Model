using System;

namespace CodeSquirl.Recipy.Model
{
    public class Unit
    {
        public Guid ID { get; set; } 

        public int Value { get; set; }

        public UnitType Type { get; set; } = UnitType.Undefined;
    }
}

using System.Collections.Generic;

namespace Alternative.Model.Entities
{
    public class Teacher : BaseEntity
    {
        public string LinkKhNure { get; set; }

        public byte[] Photo { get; set; }

        public IEnumerable<Alternative> Alternatives { get; set; }

        public User User { get; set; }
    }
}

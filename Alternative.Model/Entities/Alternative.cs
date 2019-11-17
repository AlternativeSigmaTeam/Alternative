namespace Alternative.Model.Entities
{
    public class Subject : BaseEntity
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public bool IsDeleted { get; set; }

        public Faculty Faculty { get; set; }

        public User User { get; set; }
    }
}
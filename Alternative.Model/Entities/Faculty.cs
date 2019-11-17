namespace Alternative.Model.Entities
{
    public class Faculty : BaseEntity
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public bool IsDeleted { get; set; }
    }
}
using System;
using Alternative.Model.Entities;

namespace Alternative.Model.Entities
{
    public class UsersAlternatives
    {
        public Guid UserId { get; set; }
        
        public Guid AlternativeId { get; set; }

        public User User { get;  set; }

        public Alternative Alternative { get; set; }
    }
}

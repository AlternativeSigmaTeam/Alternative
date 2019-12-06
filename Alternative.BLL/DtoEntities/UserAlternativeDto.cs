using System;
using System.Collections.Generic;
using System.Text;

namespace Alternative.BLL.DtoEntities
{
    public class UserAlternativeDto
    {
        public short Priority { get; set; }

        public Guid AlternativeId { get; set; }

        public Guid UserId { get; set; }
    }
}

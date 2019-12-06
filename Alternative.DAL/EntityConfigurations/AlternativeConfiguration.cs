using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Alternative.DAL.EntityConfigurations
{
    public class AlternativeConfiguration : IEntityTypeConfiguration<Model.Entities.Alternative>
    {
        public void Configure(EntityTypeBuilder<Model.Entities.Alternative> builder)
        {
            //builder.HasData(GetSeedAlternative());
        }

        private List<Model.Entities.Alternative> GetSeedAlternative()
        {
            var list = new List<Model.Entities.Alternative>()
            {
                new Model.Entities.Alternative(){
                    Id = DalConstants.DalConstants.KmosId,
                    Name = "KMOC", Description = "some alternative", IsDeleted = false,
                    MaxQuantity = 30
                },
                new Model.Entities.Alternative
                {
                    Id = DalConstants.DalConstants.AofmId,
                    Name = "АОФМ",
                    Description = "underfined",
                    IsDeleted = false,
                    MaxQuantity = 23, TeacherId = DalConstants.DalConstants.UserOneId
                }
            };

            return list;
        }
    }
}

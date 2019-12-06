using System.Collections.Generic;
using Alternative.Model.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Alternative.DAL.EntityConfigurations
{
    public class SpecialtyConfiguration : IEntityTypeConfiguration<Specialty>
    {
        public void Configure(EntityTypeBuilder<Specialty> builder)
        {
            builder.ToTable("Specialty");
            //builder.HasData(GetSeedSpeciality());
        }

        private List<Specialty> GetSeedSpeciality()
        {
            var list = new List<Specialty>
            {
                new Specialty
                {
                    Id = DalConstants.DalConstants.PIId,
                    IsDeleted = false,
                    Name = "ПИ"
                },
                new Specialty
                {
                    Id =  DalConstants.DalConstants.KNId,
                    IsDeleted = false,
                    Name = "КН"
                },
                new Specialty
                {
                    Id =  DalConstants.DalConstants.KIUId,
                    IsDeleted = false,
                    Name = "КИУ"
                }
            };

            return list;
        }
    }
}
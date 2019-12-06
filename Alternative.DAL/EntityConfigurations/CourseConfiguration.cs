using System;
using System.Collections.Generic;
using System.Text;
using Alternative.Model.Entities;
using Alternative.Model.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Alternative.DAL.EntityConfigurations
{
    public class CourseConfiguration : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            //builder.HasData(GetSeedCourse());
        }

        private List<Course> GetSeedCourse()
        {
            var list = new List<Course>()
            {
                new Course()
                {
                    Id = DalConstants.DalConstants.FirstCourse,
                    Semestr = Semestr.First
                },
                new Course()
                {
                    Id = DalConstants.DalConstants.SecondCourse,
                    Semestr = Semestr.Second
                }
            };

            return list;
        }
    }
}

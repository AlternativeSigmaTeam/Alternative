using System.Collections.Generic;
using Alternative.Model.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Alternative.DAL.EntityConfigurations
{
    public class TeacherConfiguration : IEntityTypeConfiguration<Teacher>
    {
        public void Configure(EntityTypeBuilder<Teacher> builder)
        {
            builder.ToTable("Teacher");

            builder.HasOne(x => x.User)
                .WithOne(x => x.Teacher)
                .HasForeignKey<Teacher>(x => x.UserId);
        }

        private List<Teacher> GetSeedTeachers()
        {
            var list = new List<Teacher>()
            {
                new Teacher()
                {
                    Id = DalConstants.DalConstants.UserOneId,
                    LinkKhNure = "https://trello.com/b/HYtccOhi/alternative-sprint-3"
                }
            };

            return list;
        }
    }
}

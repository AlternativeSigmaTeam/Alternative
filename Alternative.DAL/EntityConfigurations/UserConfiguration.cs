using System.Collections.Generic;
using Alternative.Model.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Alternative.DAL.EntityConfigurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("User");
            //builder.HasData(GetSeedUsers());
        }

        private List<User> GetSeedUsers()
        {
            var list = new List<User>()
            {
                new User()
                {
                    Id = DalConstants.DalConstants.UserOneId,
                    FullName = "Petrov Vasiliy",
                    Email = "Petrov.Vasiliy@nure.ua",
                    IsDeleted = false,
                    RoleId = DalConstants.DalConstants.TeacherId
                },
                new User()
                {
                    Id = DalConstants.DalConstants.UserTwoId,
                    FullName = "Ivanov Ivan",
                    Email = "Ivanov.Ivan@nure.ua",
                    IsDeleted = false,
                    RoleId = DalConstants.DalConstants.StudentId
                },
                new User()
                {
                    Id = DalConstants.DalConstants.UserThreeId,
                    FullName = "Petuh Petuhov",
                    Email = "Petuh.Petuhov@nure.ua",
                    IsDeleted = false,
                    RoleId = DalConstants.DalConstants.AdminId
                }
            };

            return list;
        }
    }
}
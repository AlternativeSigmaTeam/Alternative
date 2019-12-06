using System;
using System.Collections.Generic;
using System.Linq;
using Alternative.BLL.DtoEntities;
using Alternative.BLL.Interfaces;
using Alternative.DAL.UnitOfWork;
using Alternative.Model.Entities;
using AutoMapper;

namespace Alternative.BLL.Services
{
    public class UserService : IUserService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public UserService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public void Create(User entity)
        {
            throw new NotImplementedException();
        }

        public void Edit(User entity)
        {
            _unitOfWork.GetRepository<User>().Edit(entity);
            _unitOfWork.Commit();
        }

        public void Delete(User entity)
        {
            throw new NotImplementedException();
        }

        public bool IsUserExisted(Guid id)
        {
            var user = _unitOfWork.GetRepository<User>().GetSingle(x => x.Id == id);
            if (user == null)
            {
                return false;
            }

            return true;
        }

        public User GetUserById(Guid id)
        {
            return _unitOfWork.GetRepository<User>().GetSingle(x => x.Id == id);
        }

        public IEnumerable<User> GetAllUsers()
        {
            return _unitOfWork.GetRepository<User>().GetMany();
        }

        public IEnumerable<User> GetAllFreeUsers()
        {
            var users = _unitOfWork.GetRepository<User>().GetMany();
            users.ToList().ForEach(x=>x.Teacher = _unitOfWork.GetRepository<Teacher>().GetSingle(w=>w.UserId == x.Id));
            return users.Where(x => x.Teacher == null);
        }

        public bool SaveUserAlternativePriority(UserAlternativeDto alternativeDto)
        {
            var user = _unitOfWork.GetRepository<User>().GetSingle(x => x.Id == alternativeDto.UserId, x=>x.UsersAlternativeses);
            var userAlternative = user.UsersAlternativeses.FirstOrDefault(x => x.AlternativeId == alternativeDto.AlternativeId);

            if (userAlternative != null)
            {
                user.UsersAlternativeses.FirstOrDefault(x => x.AlternativeId == alternativeDto.AlternativeId).Priority =
                    alternativeDto.Priority;
                Edit(user);
                return true;
            }
            else
            {
                var listOfUserAlt = user.UsersAlternativeses.ToList();

                listOfUserAlt.Add(new UsersAlternatives
                {

                    AlternativeId = alternativeDto.AlternativeId,
                    UserId = alternativeDto.UserId,
                    Priority = alternativeDto.Priority
                });

                user.UsersAlternativeses = listOfUserAlt;

                Edit(user);
                return true;
            }

            return false;
        }
    }
}

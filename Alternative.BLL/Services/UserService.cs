using System;
using System.Collections.Generic;
using System.Text;
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
            throw new NotImplementedException();
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
    }
}

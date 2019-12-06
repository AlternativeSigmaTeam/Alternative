using System;
using System.Collections.Generic;
using System.Text;
using Alternative.BLL.Interfaces;
using Alternative.DAL.UnitOfWork;
using Alternative.Model.Entities;
using AutoMapper;

namespace Alternative.BLL.Services
{
    public class TeacherService : ITeacherService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public TeacherService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public void Create(Teacher entity)
        {
            if (entity.Id == Guid.Empty)
            {
                entity.Id = Guid.NewGuid();
            }

            _unitOfWork.GetRepository<Teacher>().Insert(entity);
            _unitOfWork.Commit();
        }

        public void Edit(Teacher entity)
        {
            _unitOfWork.GetRepository<Teacher>().Edit(entity);
            _unitOfWork.Commit();
        }

        public void Delete(Teacher entity)
        {
            _unitOfWork.GetRepository<Teacher>().Delete(entity);
            _unitOfWork.Commit();
        }

        public IEnumerable<Teacher> GetAllTeahers()
        {
            var teachers = _unitOfWork.GetRepository<Teacher>().GetMany(null, null, x=>x.User);
            return teachers;
        }

        public Teacher GetTeacherById(Guid id)
        {
            return _unitOfWork.GetRepository<Teacher>().GetSingle(x => x.Id == id);
        }

        public Teacher GetTeacherByUserId(Guid id)
        {
            return _unitOfWork.GetRepository<Teacher>().GetSingle(x=>x.UserId == id);
        }
    }
}

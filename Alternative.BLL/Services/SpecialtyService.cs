using System;
using System.Collections.Generic;
using System.Text;
using Alternative.BLL.Interfaces;
using Alternative.DAL.UnitOfWork;
using Alternative.Model.Entities;
using AutoMapper;

namespace Alternative.BLL.Services
{
    public class SpecialtyService : ISpecialtyService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public SpecialtyService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public void Create(Specialty entity)
        {
            _unitOfWork.GetRepository<Specialty>().Insert(entity);
            _unitOfWork.Commit();
        }

        public void Edit(Specialty entity)
        {
            _unitOfWork.GetRepository<Specialty>().Edit(entity);
            _unitOfWork.Commit();
        }

        public void Delete(Specialty entity)
        {
            var specialty = _unitOfWork.GetRepository<Specialty>().GetSingle(x => x.Id == entity.Id);
            specialty.IsDeleted = true;
            Edit(specialty);
        }

        public IEnumerable<Specialty> GetAllSpecialties()
        {
            return _unitOfWork.GetRepository<Specialty>().GetMany();
        }

        public Specialty GetSpesialtyById(Guid id)
        {
            return _unitOfWork.GetRepository<Specialty>().GetSingle(x => x.Id == id);
        }
    }
}

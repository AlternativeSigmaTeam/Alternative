using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Alternative.BLL.DtoEntities;
using Alternative.BLL.Interfaces;
using Alternative.DAL.UnitOfWork;
using Alternative.Model.Entities;
using AutoMapper;

namespace Alternative.BLL.Services
{
    public class AlternativeService : IAlternativeService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public AlternativeService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public void Create(Model.Entities.Alternative entity)
        {
            _unitOfWork.GetRepository<Model.Entities.Alternative>().Insert(entity);
            _unitOfWork.Commit();
        }

        public void Edit(Model.Entities.Alternative entity)
        {
            _unitOfWork.GetRepository<Model.Entities.Alternative>().Edit(entity);
            _unitOfWork.Commit();
        }

        public void Delete(Model.Entities.Alternative entity)
        {
            var alternative = _unitOfWork.GetRepository<Model.Entities.Alternative>().GetSingle(x=>x.Id == entity.Id);
            alternative.IsDeleted = true;
            Edit(entity);
        }

        public IEnumerable<Model.Entities.Alternative> GetAllAlternatives()
        {
            var alternatives = _unitOfWork.GetRepository<Model.Entities.Alternative>()
                .GetMany(x=>x.IsDeleted != true, null, x=>x.AlternativesCourses, x=>x.UsersAlternatives);
            return alternatives;
        }

        public Model.Entities.Alternative GetAlternativeByid(Guid id)
        {
            var alternative = _unitOfWork.GetRepository<Model.Entities.Alternative>()
                .GetSingle(x => x.Id == id && x.IsDeleted !=true, x => x.AlternativesCourses, x => x.UsersAlternatives);
            return alternative;
        }

        public IEnumerable<Model.Entities.Alternative> GetAlternativesByFilter(FilterDto filter)
        {
            var alternatives = _unitOfWork.GetRepository<Model.Entities.Alternative>()
                .GetMany(x => x.AlternativesCourses.Any(w => w.CourseId == filter.SelectedCourses), null, x=>x.Teacher, x=>x.AlternativesCourses, x=>x.Teacher.User, x=>x.UsersAlternatives);

            foreach (var alternative in alternatives)
            {
                foreach (var alternativesCourse in alternative.AlternativesCourses)
                {
                    alternativesCourse.Course = _unitOfWork.GetRepository<Course>()
                        .GetSingle(x => x.Id == filter.SelectedCourses);
                }
            }
            
            return alternatives.Where(x=>x.AlternativesCourses.Any(w=>w.Course.Semestr == filter.Semestr));
        }
    }
}

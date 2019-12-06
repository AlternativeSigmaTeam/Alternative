using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Alternative.BLL.Interfaces;
using Alternative.DAL.UnitOfWork;
using Alternative.Model.Entities;
using AutoMapper;
using Microsoft.EntityFrameworkCore.Internal;

namespace Alternative.BLL.Services
{
    public class CourseService : ICourseService
    {

        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CourseService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public void Create(Course entity)
        {
            throw new NotImplementedException();
        }

        public void Edit(Course entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Course entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Course> GetCoursesByCurrentSpeciality(Guid specialtyId)
        {
            var courses = _unitOfWork.GetRepository<Course>()
                .GetMany(x=>x.SpecialityCourseses.Any(i=>i.SpecialtyId == specialtyId), null, x => x.SpecialityCourseses, x => x.AlternativesCourses);

            return courses;
        }

        public Course GetCourseById(Guid id)
        {
            return _unitOfWork.GetRepository<Course>().GetSingle(x => x.Id == id);
        }
    }
}

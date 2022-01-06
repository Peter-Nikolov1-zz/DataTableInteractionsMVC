using DataTableInteractions.Data;
using DataTableInteractions.Data.Entities;
using DataTableInteratctions.Models.CohortModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTableInteractions.Services
{
    public class CohortService
    {
        private readonly ApplicationDbContext _context = new ApplicationDbContext();

        // Create
        public bool CreateCohort(CohortCreate model)
        {
            Cohort entity = new Cohort
            {
                CourseCode = model.CourseCode,
                StartDate = model.StartDate,
                EndDate = model.EndDate,
                FullTime = model.FullTime,
                Language = model.Language
            };

            _context.Cohorts.Add(entity);
            return _context.SaveChanges() == 1;
        }

        // Get All
        public List<CohortDetail> GetAllCohorts()
        {
            var cohortEntities = _context.Cohorts.ToList();
            var cohortList = cohortEntities.Select(c => new CohortDetail
            {
                Id = c.Id,
                CourseCode = c.CourseCode,
                StartDate = c.StartDate,
                EndDate = c.EndDate,
                FullTime = c.FullTime,
                Language = c.Language
            }).ToList();
            return cohortList;
        }

        // Get by ID
        public CohortDetail GetCohortById(int cohortId)
        {
            var cohortEntity = _context.Cohorts.Find(cohortId);
            if (cohortEntity == null)
                return null;

            var detail = new CohortDetail
            {
                Id = cohortEntity.Id,
                CourseCode = cohortEntity.CourseCode,
                StartDate = cohortEntity.StartDate,
                EndDate = cohortEntity.EndDate,
                FullTime = cohortEntity.FullTime,
                Language = cohortEntity.Language
            };
            return detail;
        }
    }
}

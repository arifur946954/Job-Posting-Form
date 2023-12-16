using EfCoreRelation.Entity.Employees;

namespace EfCoreRelation.Entity.WorkExpreanceDetails
{
    public class WorkExperience
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public Employee employee { get; set; }
        public List<ExperienceOne> experienceOnes { get; set; }
        public List<ExperienceTwo> experienceTwos { get; set; }
        public List<ExperienceThree> experienceThrees { get; set; }
        public List<ExperienceFour> experienceFours { get; set; }
        public List<ExperienceFive> experienceFives { get; set; }

    }
}

using EfCoreRelation.Entity.Employees;

namespace EfCoreRelation.Entity.AccademicQualificationDetails
{
    public class AccademicQualification
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public Employee employee { get; set; }
        public List<AcQualifOne> acQualifOnes { get; set; }
        public List<AcQualifTwo> acQualifTwos { get; set; }
        public List<AcQualifThree> acQualifThrees { get; set; }
    }
}

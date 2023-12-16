using EfCoreRelation.Entity.AccademicQualificationDetails;

namespace EfCoreRelation.DTOs.AccademicQualification
{
    public class AccadeMicQulificationDto
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
       
        public List<AcQualifOne> acQualifOnes { get; set; }
        public List<AcQualifTwo> acQualifTwos { get; set; }
        public List<AcQualifThree> acQualifThrees { get; set; }
    }
}

using EfCoreRelation.Entity.AccademicQualificationDetails;

namespace EfCoreRelation.DTOs.AccademicQualification
{
    public class AccadeMicQulificationDto
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
       
        public List<AccQualifOneDto> acQualifOnes { get; set; }
        public List<AccQualifTwoDto> acQualifTwos { get; set; }
        public List<AccQualifThreeDto> acQualifThrees { get; set; }
    }
}

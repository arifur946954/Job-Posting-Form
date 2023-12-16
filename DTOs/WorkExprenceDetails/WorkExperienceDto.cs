using EfCoreRelation.Entity.WorkExpreanceDetails;

namespace EfCoreRelation.DTOs.WorkExprenceDetails
{
    public class WorkExperienceDto
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
     
        public List<ExpreienceOneDto> expreienceOnes { get; set; }
        public List<ExpreienceTwoDto> experienceTwos { get; set; }
        public List<ExpreienceThreeDto> experienceThrees { get; set; }
        public List<ExpreienceFourDto> experienceFours { get; set; }
        public List<ExpreienceFiveDto> experienceFives { get; set; }
    }
}

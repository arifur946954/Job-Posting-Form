using EfCoreRelation.Entity.WorkExpreanceDetails;

namespace EfCoreRelation.DTOs.WorkExprenceDetails
{
    public class ExpreienceOneDto
    {
        public int Id { get; set; }
       
      
        public string Post { get; set; }
        public string Organization { get; set; }
        public string JobLocation { get; set; }
        public int Selary { get; set; }
        public string ReportingTo { get; set; }
        public string DefaultProduct { get; set; }
        public int WorkExperienceId { get; set; }

    }
}

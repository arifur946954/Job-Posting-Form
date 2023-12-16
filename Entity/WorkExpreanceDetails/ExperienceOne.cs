namespace EfCoreRelation.Entity.WorkExpreanceDetails
{
    public class ExperienceOne
    {
        public int Id { get; set; }
        public int WorkExperienceId { get; set; }
        public WorkExperience workExperience { get; set; }
        public string Post { get; set; }
        public string Organization { get; set; }
        public string JobLocation { get; set; }
        public int Selary { get; set; }
        public string ReportingTo { get; set; }
        public string DefaultProduct { get; set; }

    }
}

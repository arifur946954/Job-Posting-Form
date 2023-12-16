namespace EfCoreRelation.DTOs.AccademicQualification
{
    public class AccQualifTwoDto
    {
        public int Id { get; set; }
        public string Degree { get; set; }
        public string University { get; set; }
        public string Instution { get; set; }
        public string Major { get; set; }
        public double Result { get; set; }
        public string PassingYear { get; set; }

        public int AccdmQlfId { get; set; }
    }
}

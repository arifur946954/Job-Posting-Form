using EfCoreRelation.Entity;
using EfCoreRelation.Entity.AccademicQualificationDetails;
using EfCoreRelation.Entity.Address;
using EfCoreRelation.Entity.Employees;
using EfCoreRelation.Entity.WorkExpreanceDetails;
using Microsoft.EntityFrameworkCore;

namespace EfCoreRelation.Data
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions options) : base(options)
        {
        }

     
       
        public DbSet<Employee> employees { get; set; }
        //all address table 
        public DbSet<EmployeeAddress> employeeAddresses { get; set; }
        public DbSet<PresentAddress> presentAddresses { get; set; }
        public DbSet<ParmanentAddress> parmanentAddresses { get; set; }
        //Accademic qualificatin Table
        public DbSet<AccademicQualification> accademicQualifications { get; set; }
        public DbSet<AcQualifOne> acQualifOnes { get; set; }
        public DbSet<AcQualifTwo> acQualifTwos { get; set; }
        public DbSet<AcQualifThree> acQualifThrees { get; set; }

        //All work Expreince table added here

        public DbSet<WorkExperience> workExperiences { get; set; }
        public DbSet<ExperienceOne> experienceOnes { get; set; }
        public DbSet<ExperienceTwo> experienceTwos { get; set; }
        public DbSet<ExperienceThree> experienceThrees { get; set; }
        public DbSet<ExperienceFour> experienceFours { get; set; }
        public DbSet<ExperienceFive> experienceFives { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)

        {//Employee address table 
            modelBuilder.Entity<EmployeeAddress>()
                .HasOne(_ => _.employee)
                 .WithMany(_ => _.employeeAddresses)
                 .HasForeignKey(_ => _.EmployeeId) ;


            //Present Address Table 
            modelBuilder.Entity<PresentAddress>()
               .HasOne(_ => _.employeeAddress)
                .WithMany(_ => _.presentAddresses)
                .HasForeignKey(_ => _.EmployeeAddressId);

            //Parmanent address table
            modelBuilder.Entity<ParmanentAddress>()
               .HasOne(_ => _.employeeAddress)
                .WithMany(_ => _.parmanentAddresses)
                .HasForeignKey(_ => _.EmployeeAddressId);

            //Accademic qulification table 
            modelBuilder.Entity<AccademicQualification>()
               .HasOne(_ => _.employee)
                .WithMany(_ => _.accademicQualifications)
                .HasForeignKey(_ => _.EmployeeId);


            //Accademic qulification One table 
            modelBuilder.Entity<AcQualifOne>()
               .HasOne(_ => _.accademicQualification)
                .WithMany(_ => _.acQualifOnes)
                .HasForeignKey(_ => _.AccdmQlfId);

            //Accademic qulification Two table 
            modelBuilder.Entity<AcQualifTwo>()
               .HasOne(_ => _.accademicQualification)
                .WithMany(_ => _.acQualifTwos)
                .HasForeignKey(_ => _.AccdmQlfId);

            //Accademic qulification Three table 
            modelBuilder.Entity<AcQualifThree>()
               .HasOne(_ => _.accademicQualification)
                .WithMany(_ => _.acQualifThrees)
                .HasForeignKey(_ => _.AccdmQlfId);

            //Work Experience MAin Table  
            modelBuilder.Entity<WorkExperience>()
               .HasOne(_ => _.employee)
                .WithMany(_ => _.workExperiences)
                .HasForeignKey(_ => _.EmployeeId);


            //Work Experience One Table  
            modelBuilder.Entity<ExperienceOne>()
               .HasOne(_ => _.workExperience)
                .WithMany(_ => _.experienceOnes)
                .HasForeignKey(_ => _.WorkExperienceId);

            //Work Experience Two Table  
            modelBuilder.Entity<ExperienceTwo>()
               .HasOne(_ => _.workExperience)
                .WithMany(_ => _.experienceTwos)
                .HasForeignKey(_ => _.WorkExperienceId);

            //Work Experience Three Table  
            modelBuilder.Entity<ExperienceThree>()
               .HasOne(_ => _.workExperience)
                .WithMany(_ => _.experienceThrees)
                .HasForeignKey(_ => _.WorkExperienceId);

            //Work Experience Four Table  
            modelBuilder.Entity<ExperienceFour>()
               .HasOne(_ => _.workExperience)
                .WithMany(_ => _.experienceFours)
                .HasForeignKey(_ => _.WorkExperienceId);

            //Work Experience Five Table  
            modelBuilder.Entity<ExperienceFive>()
               .HasOne(_ => _.workExperience)
                .WithMany(_ => _.experienceFives)
                .HasForeignKey(_ => _.WorkExperienceId);





















        }


    }





     

    }


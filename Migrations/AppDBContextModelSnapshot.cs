﻿// <auto-generated />
using EfCoreRelation.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EfCoreRelation.Migrations
{
    [DbContext(typeof(AppDBContext))]
    partial class AppDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.25")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("EfCoreRelation.Entity.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("EfCoreRelation.Entity.CustomerAddress", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.ToTable("customerAddresses");
                });

            modelBuilder.Entity("EfCoreRelation.Entity.PermanentAddress", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CustomerAddressId")
                        .HasColumnType("int");

                    b.Property<string>("District")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Thana")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CustomerAddressId");

                    b.ToTable("permanentAddresses");
                });

            modelBuilder.Entity("EfCoreRelation.Entity.PresentAddress", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CustomerAddressId")
                        .HasColumnType("int");

                    b.Property<string>("District")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Thana")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CustomerAddressId");

                    b.ToTable("presentAddress");
                });

            modelBuilder.Entity("EfCoreRelation.Entity.CustomerAddress", b =>
                {
                    b.HasOne("EfCoreRelation.Entity.Customer", "customer")
                        .WithMany("customerAddresses")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("customer");
                });

            modelBuilder.Entity("EfCoreRelation.Entity.PermanentAddress", b =>
                {
                    b.HasOne("EfCoreRelation.Entity.CustomerAddress", "customerAddress")
                        .WithMany("permanentAddresses")
                        .HasForeignKey("CustomerAddressId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("customerAddress");
                });

            modelBuilder.Entity("EfCoreRelation.Entity.PresentAddress", b =>
                {
                    b.HasOne("EfCoreRelation.Entity.CustomerAddress", "customerAddress")
                        .WithMany("presentAddresses")
                        .HasForeignKey("CustomerAddressId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("customerAddress");
                });

            modelBuilder.Entity("EfCoreRelation.Entity.Customer", b =>
                {
                    b.Navigation("customerAddresses");
                });

            modelBuilder.Entity("EfCoreRelation.Entity.CustomerAddress", b =>
                {
                    b.Navigation("permanentAddresses");

                    b.Navigation("presentAddresses");
                });
#pragma warning restore 612, 618
        }
    }
}

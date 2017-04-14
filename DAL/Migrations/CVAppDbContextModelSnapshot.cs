using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using DAL;

namespace DAL.Migrations
{
    [DbContext(typeof(CVAppDbContext))]
    partial class CVAppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Domain.Characteristic", b =>
                {
                    b.Property<int>("CharacteristicId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CharacteristicName");

                    b.Property<int?>("PersonId");

                    b.HasKey("CharacteristicId");

                    b.HasIndex("PersonId");

                    b.ToTable("Characteristics");
                });

            modelBuilder.Entity("Domain.Contact", b =>
                {
                    b.Property<int>("ContactId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ContactTypeId");

                    b.Property<string>("ContactValue");

                    b.Property<int>("PersonId");

                    b.HasKey("ContactId");

                    b.HasIndex("ContactTypeId");

                    b.HasIndex("PersonId");

                    b.ToTable("Contacts");
                });

            modelBuilder.Entity("Domain.ContactType", b =>
                {
                    b.Property<int>("ContactTypeId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ContactTypeName");

                    b.HasKey("ContactTypeId");

                    b.ToTable("ContactTypes");
                });

            modelBuilder.Entity("Domain.Experience", b =>
                {
                    b.Property<int>("ExperienceId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<string>("Job");

                    b.Property<int>("PersonId");

                    b.HasKey("ExperienceId");

                    b.HasIndex("PersonId");

                    b.ToTable("Experiences");
                });

            modelBuilder.Entity("Domain.Language", b =>
                {
                    b.Property<int>("LanguageId")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("PersonId");

                    b.HasKey("LanguageId");

                    b.HasIndex("PersonId");

                    b.ToTable("Languages");
                });

            modelBuilder.Entity("Domain.Person", b =>
                {
                    b.Property<int>("PersonId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AdditionalInformation");

                    b.Property<string>("Address");

                    b.Property<DateTime>("BirthDate");

                    b.Property<int?>("ContactTypeId");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.HasKey("PersonId");

                    b.HasIndex("ContactTypeId");

                    b.ToTable("Persons");
                });

            modelBuilder.Entity("Domain.PersonCharacteristic", b =>
                {
                    b.Property<int>("PersonCharacteristicId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CharacteristicId");

                    b.Property<int>("PersonId");

                    b.HasKey("PersonCharacteristicId");

                    b.HasIndex("CharacteristicId");

                    b.HasIndex("PersonId");

                    b.ToTable("PersonCharacteristics");
                });

            modelBuilder.Entity("Domain.Skill", b =>
                {
                    b.Property<int>("SkillId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("PersonId");

                    b.Property<string>("SkillDescription");

                    b.Property<string>("SkillName");

                    b.HasKey("SkillId");

                    b.HasIndex("PersonId");

                    b.ToTable("Skills");
                });

            modelBuilder.Entity("Domain.Characteristic", b =>
                {
                    b.HasOne("Domain.Person")
                        .WithMany("Characteristics")
                        .HasForeignKey("PersonId");
                });

            modelBuilder.Entity("Domain.Contact", b =>
                {
                    b.HasOne("Domain.ContactType", "ContactType")
                        .WithMany("Contacts")
                        .HasForeignKey("ContactTypeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Domain.Person", "Person")
                        .WithMany("Contacts")
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Domain.Experience", b =>
                {
                    b.HasOne("Domain.Person", "Person")
                        .WithMany("WorkExperiences")
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Domain.Language", b =>
                {
                    b.HasOne("Domain.Person")
                        .WithMany("Languages")
                        .HasForeignKey("PersonId");
                });

            modelBuilder.Entity("Domain.Person", b =>
                {
                    b.HasOne("Domain.ContactType")
                        .WithMany("Persons")
                        .HasForeignKey("ContactTypeId");
                });

            modelBuilder.Entity("Domain.PersonCharacteristic", b =>
                {
                    b.HasOne("Domain.Characteristic", "Characteristic")
                        .WithMany("PersonCharacteristics")
                        .HasForeignKey("CharacteristicId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Domain.Person", "Person")
                        .WithMany()
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Domain.Skill", b =>
                {
                    b.HasOne("Domain.Person", "Person")
                        .WithMany("Skills")
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}

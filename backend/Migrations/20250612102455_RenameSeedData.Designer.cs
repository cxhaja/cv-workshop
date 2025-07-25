﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using backend.Data;

#nullable disable

namespace backend.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20250612102455_RenameSeedData")]
    partial class RenameSeedData
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("backend.Data.Models.Experience", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<string>("Company")
                        .HasColumnType("text")
                        .HasColumnName("company");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("description");

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("end_date");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("text")
                        .HasColumnName("image_url");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("role");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("start_date");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("title");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("type");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid")
                        .HasColumnName("user_id");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("experience", "public");

                    b.HasData(
                        new
                        {
                            Id = new Guid("cccccccc-cccc-cccc-cccc-cccccccccccc"),
                            Company = "Computas AS",
                            Description = "Sommerjobb som utvikler hos Computas AS.",
                            EndDate = new DateTime(2011, 8, 31, 0, 0, 0, 0, DateTimeKind.Utc),
                            ImageUrl = "https://www.proff.no/imagine/cache/7029839_fullsize.jpg",
                            Role = "Utvikler",
                            StartDate = new DateTime(2011, 6, 1, 0, 0, 0, 0, DateTimeKind.Utc),
                            Title = "Sommerjobb hos Computas",
                            Type = "work",
                            UserId = new Guid("11111111-1111-1111-1111-111111111111")
                        },
                        new
                        {
                            Id = new Guid("dddddddd-dddd-dddd-dddd-dddddddddddd"),
                            Company = "Universitetet i Oslo",
                            Description = "Fullførte bachelorgrad i informatikk ved Universitetet i Oslo.",
                            EndDate = new DateTime(2012, 5, 31, 0, 0, 0, 0, DateTimeKind.Utc),
                            ImageUrl = "https://koro.no/content/uploads/2016/01/bilde-012uN1buKPdh-825x550.jpg",
                            Role = "Student",
                            StartDate = new DateTime(2008, 8, 1, 0, 0, 0, 0, DateTimeKind.Utc),
                            Title = "Bachelor i informatikk ved UiO",
                            Type = "education",
                            UserId = new Guid("11111111-1111-1111-1111-111111111111")
                        },
                        new
                        {
                            Id = new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"),
                            Company = "Universitetet i Oslo",
                            Description = "Fullførte mastergrad i informatikk ved Universitetet i Oslo.",
                            EndDate = new DateTime(2014, 5, 31, 0, 0, 0, 0, DateTimeKind.Utc),
                            ImageUrl = "https://koro.no/content/uploads/2016/01/bilde-012uN1buKPdh-825x550.jpg",
                            Role = "Student",
                            StartDate = new DateTime(2012, 8, 1, 0, 0, 0, 0, DateTimeKind.Utc),
                            Title = "Master i informatikk ved UiO",
                            Type = "education",
                            UserId = new Guid("11111111-1111-1111-1111-111111111111")
                        },
                        new
                        {
                            Id = new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeef"),
                            Company = "Norges teknisk-naturvitenskapelige universitet",
                            Description = "Fullførte mastergrad i datateknologi ved NTNU Trondheim.",
                            EndDate = new DateTime(2024, 6, 30, 0, 0, 0, 0, DateTimeKind.Utc),
                            ImageUrl = "https://www.lifeinnorway.net/wp-content/uploads/2021/07/ntnu-trondheim-main-building.jpg",
                            Role = "Student",
                            StartDate = new DateTime(2019, 8, 1, 0, 0, 0, 0, DateTimeKind.Utc),
                            Title = "Master i Datateknologi ved NTNU",
                            Type = "education",
                            UserId = new Guid("11111111-1111-1111-1111-111111111111")
                        },
                        new
                        {
                            Id = new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeeb"),
                            Company = "Teknologiporten ved NTNU",
                            Description = "Multidisiplinær bedriftskontakt",
                            EndDate = new DateTime(2022, 6, 30, 0, 0, 0, 0, DateTimeKind.Utc),
                            ImageUrl = "https://www.lifeinnorway.net/wp-content/uploads/2021/07/ntnu-trondheim-main-building.jpg",
                            Role = "Student",
                            StartDate = new DateTime(2019, 8, 1, 0, 0, 0, 0, DateTimeKind.Utc),
                            Title = "Næringslivssjef i Teknologiporten",
                            Type = "Voluntary",
                            UserId = new Guid("11111111-1111-1111-1111-111111111111")
                        },
                        new
                        {
                            Id = new Guid("eeedeeee-eeee-eeee-eeee-eeeeeeeeeeea"),
                            Description = "Hobbyprosjekt for å teste API-ene til Oslo Bysykkel i Android Studio",
                            EndDate = new DateTime(2022, 10, 28, 0, 0, 0, 0, DateTimeKind.Utc),
                            ImageUrl = "https://tellusdmsmedia.newmindmedia.com/wsimgs/4_897936618.jpg[ProductImage][4D037D0DBBC22BD05D8BF069F3]",
                            Role = "Student",
                            StartDate = new DateTime(2022, 8, 1, 0, 0, 0, 0, DateTimeKind.Utc),
                            Title = "Oslo bysykkelsjekker",
                            Type = "Hobby project",
                            UserId = new Guid("11111111-1111-1111-1111-111111111111")
                        });
                });

            modelBuilder.Entity("backend.Data.Models.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("address");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("birth_date");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("description");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("text")
                        .HasColumnName("image_url");

                    b.Property<string>("LinkedInUrl")
                        .HasColumnType("text")
                        .HasColumnName("linkedin_url");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("phone");

                    b.Property<string>("Skills")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("skills");

                    b.Property<string>("University")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("university");

                    b.HasKey("Id");

                    b.ToTable("user", "public");

                    b.HasData(
                        new
                        {
                            Id = new Guid("11111111-1111-1111-1111-111111111111"),
                            Address = "Oslogata, 0278 Oslo",
                            BirthDate = new DateTime(1990, 6, 15, 0, 0, 0, 0, DateTimeKind.Utc),
                            Description = "Erfaren webutvikler.",
                            ImageUrl = "https://example.com/alice.jpg",
                            LinkedInUrl = "https://linkedin.com/in/knutvikler",
                            Name = "Knut Vikler",
                            Phone = "+47 123 45 678",
                            Skills = "JavaScript;React;CSS;HTML;TypeScript",
                            University = "Universitetet i Oslo"
                        },
                        new
                        {
                            Id = new Guid("11111111-1111-1111-1111-111111111112"),
                            Address = "Oslogata, 0278 Oslo",
                            BirthDate = new DateTime(1990, 6, 15, 0, 0, 0, 0, DateTimeKind.Utc),
                            Description = "Seig backendutvikler",
                            ImageUrl = "https://example.com/alice.jpg",
                            LinkedInUrl = "https://linkedin.com/in/computas",
                            Name = "Comp Utas",
                            Phone = "+47 123 45 678",
                            Skills = "Go;TypeScript;Kotlin;Postgres",
                            University = "Universitetet på Svalbard"
                        },
                        new
                        {
                            Id = new Guid("11111111-1111-1111-1111-111111111113"),
                            Address = "Oslogata, 0278 Oslo",
                            BirthDate = new DateTime(1990, 6, 15, 0, 0, 0, 0, DateTimeKind.Utc),
                            Description = "Senior fullstackutvikler.",
                            ImageUrl = "https://example.com/alice.jpg",
                            LinkedInUrl = "https://linkedin.com/in/lsk",
                            Name = "Kari Kanari",
                            Phone = "+47 123 45 678",
                            Skills = "JavaScript;React;Kotlin;CSS;HTML;TypeScript;Python",
                            University = "NTNU"
                        });
                });

            modelBuilder.Entity("backend.Data.Models.Experience", b =>
                {
                    b.HasOne("backend.Data.Models.User", "User")
                        .WithMany("Experiences")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("backend.Data.Models.User", b =>
                {
                    b.Navigation("Experiences");
                });
#pragma warning restore 612, 618
        }
    }
}

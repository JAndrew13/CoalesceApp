﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Training.CoalesceApp.Data;

#nullable disable

namespace Training.CoalesceApp.Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240806040550_InitialDataModel")]
    partial class InitialDataModel
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0-preview.6.24327.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Training.CoalesceApp.Data.Models.ApplicationUser", b =>
                {
                    b.Property<string>("ApplicationUserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OrganizationId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("ApplicationUserId");

                    b.HasIndex("OrganizationId");

                    b.ToTable("ApplicationUsers");
                });

            modelBuilder.Entity("Training.CoalesceApp.Data.Models.Event", b =>
                {
                    b.Property<string>("EventId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTimeOffset>("End")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OrganizationId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTimeOffset>("Start")
                        .HasColumnType("datetimeoffset");

                    b.HasKey("EventId");

                    b.HasIndex("OrganizationId");

                    b.ToTable("Events");
                });

            modelBuilder.Entity("Training.CoalesceApp.Data.Models.Organization", b =>
                {
                    b.Property<string>("OrganizationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("OrganizationId");

                    b.ToTable("Organizations");
                });

            modelBuilder.Entity("Training.CoalesceApp.Data.Models.TriviaAnswer", b =>
                {
                    b.Property<int>("TriviaAnswerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TriviaAnswerId"));

                    b.Property<string>("EventId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("IsCorrect")
                        .HasColumnType("bit");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TriviaQuestionId")
                        .HasColumnType("int");

                    b.HasKey("TriviaAnswerId");

                    b.HasIndex("EventId");

                    b.HasIndex("TriviaQuestionId");

                    b.ToTable("TriviaAnswers");
                });

            modelBuilder.Entity("Training.CoalesceApp.Data.Models.TriviaGuess", b =>
                {
                    b.Property<int>("TriviaGuessId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TriviaGuessId"));

                    b.Property<string>("ApplicationUserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("EventId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("TriviaAnswerId")
                        .HasColumnType("int");

                    b.HasKey("TriviaGuessId");

                    b.HasIndex("ApplicationUserId");

                    b.HasIndex("EventId");

                    b.HasIndex("TriviaAnswerId");

                    b.ToTable("TriviaGuesses");
                });

            modelBuilder.Entity("Training.CoalesceApp.Data.Models.TriviaQuestion", b =>
                {
                    b.Property<int>("TriviaQuestionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TriviaQuestionId"));

                    b.Property<string>("EventId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TriviaQuestionId");

                    b.HasIndex("EventId");

                    b.ToTable("TriviaQuestions");
                });

            modelBuilder.Entity("Training.CoalesceApp.Data.Models.TriviaQuestionTag", b =>
                {
                    b.Property<int>("TriviaQuestionTagId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TriviaQuestionTagId"));

                    b.Property<int>("TriviaQuestionId")
                        .HasColumnType("int");

                    b.Property<int>("TriviaTagId")
                        .HasColumnType("int");

                    b.HasKey("TriviaQuestionTagId");

                    b.HasIndex("TriviaQuestionId");

                    b.HasIndex("TriviaTagId");

                    b.ToTable("TriviaQuestionTags");
                });

            modelBuilder.Entity("Training.CoalesceApp.Data.Models.TriviaTag", b =>
                {
                    b.Property<int>("TriviaTagId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TriviaTagId"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TriviaTagId");

                    b.ToTable("TriviaTags");
                });

            modelBuilder.Entity("Training.CoalesceApp.Data.Models.ApplicationUser", b =>
                {
                    b.HasOne("Training.CoalesceApp.Data.Models.Organization", "Organization")
                        .WithMany()
                        .HasForeignKey("OrganizationId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Organization");
                });

            modelBuilder.Entity("Training.CoalesceApp.Data.Models.Event", b =>
                {
                    b.HasOne("Training.CoalesceApp.Data.Models.Organization", "Organization")
                        .WithMany()
                        .HasForeignKey("OrganizationId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Organization");
                });

            modelBuilder.Entity("Training.CoalesceApp.Data.Models.TriviaAnswer", b =>
                {
                    b.HasOne("Training.CoalesceApp.Data.Models.Event", "Event")
                        .WithMany()
                        .HasForeignKey("EventId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Training.CoalesceApp.Data.Models.TriviaQuestion", "TriviaQuestion")
                        .WithMany("Answers")
                        .HasForeignKey("TriviaQuestionId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Event");

                    b.Navigation("TriviaQuestion");
                });

            modelBuilder.Entity("Training.CoalesceApp.Data.Models.TriviaGuess", b =>
                {
                    b.HasOne("Training.CoalesceApp.Data.Models.ApplicationUser", "ApplicationUser")
                        .WithMany()
                        .HasForeignKey("ApplicationUserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Training.CoalesceApp.Data.Models.Event", "Event")
                        .WithMany()
                        .HasForeignKey("EventId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Training.CoalesceApp.Data.Models.TriviaAnswer", "TriviaAnswer")
                        .WithMany()
                        .HasForeignKey("TriviaAnswerId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("ApplicationUser");

                    b.Navigation("Event");

                    b.Navigation("TriviaAnswer");
                });

            modelBuilder.Entity("Training.CoalesceApp.Data.Models.TriviaQuestion", b =>
                {
                    b.HasOne("Training.CoalesceApp.Data.Models.Event", "Event")
                        .WithMany()
                        .HasForeignKey("EventId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Event");
                });

            modelBuilder.Entity("Training.CoalesceApp.Data.Models.TriviaQuestionTag", b =>
                {
                    b.HasOne("Training.CoalesceApp.Data.Models.TriviaQuestion", "TriviaQuestion")
                        .WithMany("Tags")
                        .HasForeignKey("TriviaQuestionId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Training.CoalesceApp.Data.Models.TriviaTag", "TriviaTag")
                        .WithMany()
                        .HasForeignKey("TriviaTagId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("TriviaQuestion");

                    b.Navigation("TriviaTag");
                });

            modelBuilder.Entity("Training.CoalesceApp.Data.Models.TriviaQuestion", b =>
                {
                    b.Navigation("Answers");

                    b.Navigation("Tags");
                });
#pragma warning restore 612, 618
        }
    }
}
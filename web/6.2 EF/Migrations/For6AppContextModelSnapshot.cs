﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using _6._2_EF;

namespace _6._2_EF.Migrations
{
    [DbContext(typeof(For6AppContext))]
    partial class For6AppContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("_6._2_EF.Phones", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("Company")
                        .HasColumnType("nchar(10)")
                        .IsFixedLength(true)
                        .HasMaxLength(10);

                    b.Property<int?>("Cost")
                        .HasColumnType("int");

                    b.Property<bool>("IsChina")
                        .HasColumnType("bit");

                    b.Property<string>("Model")
                        .HasColumnType("nchar(10)")
                        .IsFixedLength(true)
                        .HasMaxLength(10);

                    b.HasKey("Id");

                    b.ToTable("Phones");
                });

            modelBuilder.Entity("_6._2_EF.Users", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<int?>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nchar(10)")
                        .IsFixedLength(true)
                        .HasMaxLength(10);

                    b.Property<int?>("PhoneId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PhoneId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("_6._2_EF.Users", b =>
                {
                    b.HasOne("_6._2_EF.Phones", "Phone")
                        .WithMany("Users")
                        .HasForeignKey("PhoneId")
                        .HasConstraintName("FK_Users_Phones");
                });
#pragma warning restore 612, 618
        }
    }
}

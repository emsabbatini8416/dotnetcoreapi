﻿// <auto-generated />
using System;
using API;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace API.Migrations
{
    [DbContext(typeof(APIContext))]
    partial class APIContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("API.Models.Permiso", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellido")
                        .IsRequired();

                    b.Property<DateTime>("Fecha");

                    b.Property<string>("Nombre")
                        .IsRequired();

                    b.Property<int>("TipoPermisoId");

                    b.HasKey("Id");

                    b.HasIndex("TipoPermisoId");

                    b.ToTable("Permisos","dbo");
                });

            modelBuilder.Entity("API.Models.TipoPermiso", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("TipoPermisos","dbo");
                });

            modelBuilder.Entity("API.Models.Permiso", b =>
                {
                    b.HasOne("API.Models.TipoPermiso", "TipoPermiso")
                        .WithMany()
                        .HasForeignKey("TipoPermisoId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
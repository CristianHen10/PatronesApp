// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PatronesApp.Models;

namespace PatronesApp.Migrations
{
    [DbContext(typeof(UniversidadContext))]
    partial class UniversidadContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.4")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PatronesApp.Models.Cursos", b =>
                {
                    b.Property<int>("IdCurso")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NombreCurso")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Ts")
                        .HasColumnType("datetime2");

                    b.HasKey("IdCurso");

                    b.ToTable("Cursos");
                });

            modelBuilder.Entity("PatronesApp.Models.Estudiantes", b =>
                {
                    b.Property<int>("IdEstudiante")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CursosAsignados")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Edad")
                        .HasColumnType("int");

                    b.Property<string>("JornadaClases")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PrimerApellido")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PrimerNombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SegundoApellido")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SegundoNombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Ts")
                        .HasColumnType("datetime2");

                    b.HasKey("IdEstudiante");

                    b.ToTable("Estudiantes");
                });

            modelBuilder.Entity("PatronesApp.Models.Profesores", b =>
                {
                    b.Property<int>("IdProfesor")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ApellidoProfesor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CursosDictados")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("JornadaClases")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NombreProfesor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Ts")
                        .HasColumnType("datetime2");

                    b.HasKey("IdProfesor");

                    b.ToTable("Profesores");
                });
#pragma warning restore 612, 618
        }
    }
}

﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ServicioUsuario.Database;

namespace ServicioUsuario.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20210908215737_add_tabla")]
    partial class add_tabla
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ServicioUsuario.Database.Entities.DatosPJEH", b =>
                {
                    b.Property<int>("IDSolicitud")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AsuntoRelacionado")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Estado")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FechaAudiencia")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("JuzgadoAsignado")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NUC")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NoOficioSolicitud")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SalaAsignada")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TipoAudiencia")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IDSolicitud");

                    b.ToTable("DatosPJEH");
                });

            modelBuilder.Entity("ServicioUsuario.Database.Entities.Usuario", b =>
                {
                    b.Property<int>("IdUsuario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Contacto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Direccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdUsuario");

                    b.ToTable("Usuarios");
                });
#pragma warning restore 612, 618
        }
    }
}
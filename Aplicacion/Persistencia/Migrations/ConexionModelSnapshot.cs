﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Persistencia;

namespace Persistencia.Migrations
{
    [DbContext(typeof(Conexion))]
    partial class ConexionModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("Dominio.Empleado", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Apellido")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cedula")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CodigoEmpleado")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RolEmpleado")
                        .HasColumnType("int");

                    b.Property<string>("Sucursal")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Usuario")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Empleados");
                });

            modelBuilder.Entity("Dominio.Factura", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("CantidadProductos")
                        .HasColumnType("int");

                    b.Property<bool>("CompraVenta")
                        .HasColumnType("bit");

                    b.Property<int>("NumeroFactura")
                        .HasColumnType("int");

                    b.Property<string>("Sucursal")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Facturas");
                });

            modelBuilder.Entity("Dominio.Producto", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Fabricante")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PrecioCompra")
                        .HasColumnType("int");

                    b.Property<int>("PrecioVenta")
                        .HasColumnType("int");

                    b.Property<string>("Version")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Productos");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Producto");
                });

            modelBuilder.Entity("Dominio.Consola", b =>
                {
                    b.HasBaseType("Dominio.Producto");

                    b.Property<string>("Almacenamiento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Disco")
                        .HasColumnType("int");

                    b.Property<string>("MemoriaRam")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumeroControles")
                        .HasColumnType("int");

                    b.Property<string>("VelocidadProcesamiento")
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("Consola");
                });

            modelBuilder.Entity("Dominio.Controles", b =>
                {
                    b.HasBaseType("Dominio.Producto");

                    b.Property<string>("Tipo")
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("Controles");
                });

            modelBuilder.Entity("Dominio.Videojuego", b =>
                {
                    b.HasBaseType("Dominio.Producto");

                    b.Property<bool>("Multiplataformausing")
                        .HasColumnType("bit");

                    b.HasDiscriminator().HasValue("Videojuego");
                });
#pragma warning restore 612, 618
        }
    }
}

﻿// <auto-generated />
using Hotel.Web.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Hotel.Web.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.27")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Hotel.Web.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.HasKey("CategoryId");

                    b.ToTable("DishCategory");
                });

            modelBuilder.Entity("Hotel.Web.Models.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("CustomerName")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.HasKey("CustomerId");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("Hotel.Web.Models.Menu", b =>
                {
                    b.Property<int>("DishID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("DishName")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("DishPrice")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(120)")
                        .HasMaxLength(120);

                    b.Property<short>("Quantity")
                        .HasColumnType("smallint");

                    b.HasKey("DishID");

                    b.HasIndex("CategoryId");

                    b.ToTable("Menu");
                });

            modelBuilder.Entity("Hotel.Web.Models.OrderDetails", b =>
                {
                    b.Property<int>("OrderDetailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<int>("DishId")
                        .HasColumnType("int");

                    b.Property<int>("PaymentMethod")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("OrderDetailId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("DishId");

                    b.HasIndex("PaymentMethod");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("Hotel.Web.Models.Payment", b =>
                {
                    b.Property<int>("OrderDetailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("PaymentMethods")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.HasKey("OrderDetailId");

                    b.ToTable("Payments");
                });

            modelBuilder.Entity("Hotel.Web.Models.Menu", b =>
                {
                    b.HasOne("Hotel.Web.Models.Category", "Category")
                        .WithMany("Menu")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Hotel.Web.Models.OrderDetails", b =>
                {
                    b.HasOne("Hotel.Web.Models.Customer", "Customers")
                        .WithMany("OrderDetails")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Hotel.Web.Models.Menu", "Menus")
                        .WithMany("OrderDetails")
                        .HasForeignKey("DishId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Hotel.Web.Models.Payment", "Payments")
                        .WithMany("OrderDetails")
                        .HasForeignKey("PaymentMethod")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}

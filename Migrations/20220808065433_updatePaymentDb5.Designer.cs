﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ReturnOrderMgmtSystemV1.Models;

namespace ReturnOrderMgmtSystemV1.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220808065433_updatePaymentDb5")]
    partial class updatePaymentDb5
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ReturnOrderMgmtSystemV1.Models.PaymentDetails", b =>
                {
                    b.Property<string>("RequestId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CardNbr")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameOnCard")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("TxnDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ValidThru")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RequestId");

                    b.ToTable("paymentDetails");
                });

            modelBuilder.Entity("ReturnOrderMgmtSystemV1.Models.ProcessedOrderData", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ComponentName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ComponentType")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.Property<string>("CustContactNo")
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.Property<DateTime>("DateOfDelivery")
                        .HasColumnType("datetime2");

                    b.Property<double>("PckgngAndDlvryCharge")
                        .HasColumnType("float");

                    b.Property<double>("ProcessingCharge")
                        .HasColumnType("float");

                    b.Property<float>("Quantity")
                        .HasColumnType("real");

                    b.Property<DateTime>("RequestDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("RequestId")
                        .IsRequired()
                        .HasColumnType("nvarchar(15)")
                        .HasMaxLength(15);

                    b.Property<string>("customerName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("processedOrderData");
                });

            modelBuilder.Entity("ReturnOrderMgmtSystemV1.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(25)")
                        .HasMaxLength(25);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(18)")
                        .HasMaxLength(18);

                    b.Property<string>("PhNumber")
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(25)")
                        .HasMaxLength(25);

                    b.HasKey("Id");

                    b.ToTable("user");
                });
#pragma warning restore 612, 618
        }
    }
}

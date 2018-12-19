﻿// <auto-generated />
using System;
using BankingData;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BankingData.Migrations
{
    [DbContext(typeof(ChilinDoContext))]
    [Migration("20181219164842_AddSystemLog")]
    partial class AddSystemLog
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BankingData.Entity.AccountDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AcountInfoId");

                    b.Property<decimal>("Balance");

                    b.Property<string>("Currency");

                    b.Property<bool>("IsDeleted");

                    b.Property<byte[]>("Version")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.HasKey("Id");

                    b.HasIndex("AcountInfoId");

                    b.ToTable("AccountDetails");

                    b.HasData(
                        new { Id = 1, AcountInfoId = 1, Balance = 1000m, Currency = "USD", IsDeleted = false },
                        new { Id = 2, AcountInfoId = 1, Balance = 1000m, Currency = "MYR", IsDeleted = false },
                        new { Id = 3, AcountInfoId = 2, Balance = 1000000m, Currency = "VND", IsDeleted = false },
                        new { Id = 4, AcountInfoId = 2, Balance = 1000000m, Currency = "BAHT", IsDeleted = false },
                        new { Id = 5, AcountInfoId = 2, Balance = 3000m, Currency = "USD", IsDeleted = false }
                    );
                });

            modelBuilder.Entity("BankingData.Entity.AccountInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AccountName");

                    b.Property<bool>("IsDeleted");

                    b.HasKey("Id");

                    b.ToTable("AccountInfos");

                    b.HasData(
                        new { Id = 1, AccountName = "AccountA", IsDeleted = false },
                        new { Id = 2, AccountName = "AccountB", IsDeleted = false }
                    );
                });

            modelBuilder.Entity("BankingData.Entity.SystemLog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Exception");

                    b.Property<string>("Level");

                    b.Property<string>("Message");

                    b.Property<string>("MessageTemplate");

                    b.Property<string>("Properties");

                    b.Property<DateTime>("TimeStamp");

                    b.HasKey("Id");

                    b.ToTable("SystemLogs");
                });

            modelBuilder.Entity("BankingData.Entity.TransactionHistory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AccountId");

                    b.Property<decimal>("Amount");

                    b.Property<string>("Currency");

                    b.Property<bool>("IsSuccess");

                    b.Property<string>("Message");

                    b.HasKey("Id");

                    b.ToTable("TransactionHistories");

                    b.HasData(
                        new { Id = 1, AccountId = 1, Amount = 1000m, Currency = "USD", IsSuccess = true },
                        new { Id = 2, AccountId = 1, Amount = 1000m, Currency = "MYR", IsSuccess = true },
                        new { Id = 3, AccountId = 2, Amount = 1000000m, Currency = "VND", IsSuccess = true },
                        new { Id = 4, AccountId = 2, Amount = 1000000m, Currency = "BAHT", IsSuccess = true },
                        new { Id = 5, AccountId = 2, Amount = 3000m, Currency = "USD", IsSuccess = true }
                    );
                });

            modelBuilder.Entity("BankingData.Entity.AccountDetail", b =>
                {
                    b.HasOne("BankingData.Entity.AccountInfo", "AccountInfo")
                        .WithMany("AccountDetails")
                        .HasForeignKey("AcountInfoId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}

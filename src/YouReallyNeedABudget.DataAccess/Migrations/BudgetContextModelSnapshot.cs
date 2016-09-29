using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using YouReallyNeedABudget.DataAccess;

namespace YouReallyNeedABudget.DataAccess.Migrations
{
    [DbContext(typeof(BudgetContext))]
    partial class BudgetContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("YouReallyNeedABudget.Models.Account", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("LogId");

                    b.Property<string>("Name");

                    b.Property<int>("Type");

                    b.HasKey("ID");

                    b.HasIndex("LogId");

                    b.ToTable("Account");
                });

            modelBuilder.Entity("YouReallyNeedABudget.Models.Log", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("ID");

                    b.ToTable("Log");
                });

            modelBuilder.Entity("YouReallyNeedABudget.Models.Payee", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("ID");

                    b.ToTable("Payee");
                });

            modelBuilder.Entity("YouReallyNeedABudget.Models.Transaction", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccountId");

                    b.Property<decimal>("Amount");

                    b.Property<bool>("Cleared");

                    b.Property<DateTime>("Date");

                    b.Property<string>("Memo");

                    b.Property<int?>("PayeeId");

                    b.HasKey("ID");

                    b.HasIndex("AccountId");

                    b.HasIndex("PayeeId");

                    b.ToTable("Transaction");
                });

            modelBuilder.Entity("YouReallyNeedABudget.Models.Account", b =>
                {
                    b.HasOne("YouReallyNeedABudget.Models.Log", "Log")
                        .WithMany("Accounts")
                        .HasForeignKey("LogId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("YouReallyNeedABudget.Models.Transaction", b =>
                {
                    b.HasOne("YouReallyNeedABudget.Models.Account", "Account")
                        .WithMany("Transactions")
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("YouReallyNeedABudget.Models.Payee", "Payee")
                        .WithMany()
                        .HasForeignKey("PayeeId");
                });
        }
    }
}

using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace YouReallyNeedABudget.DataAccess.Migrations
{
    public partial class payeeprimarykeychange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Transaction_Payee_PayeeId",
                table: "Transaction");

            migrationBuilder.DropIndex(
                name: "IX_Transaction_PayeeId",
                table: "Transaction");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Payee",
                table: "Payee");

            migrationBuilder.DropColumn(
                name: "PayeeId",
                table: "Transaction");

            migrationBuilder.DropColumn(
                name: "ID",
                table: "Payee");

            migrationBuilder.AddColumn<string>(
                name: "PayeeName",
                table: "Transaction",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Transaction_PayeeName",
                table: "Transaction",
                column: "PayeeName");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Payee",
                nullable: false);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Payee",
                table: "Payee",
                column: "Name");

            migrationBuilder.AddForeignKey(
                name: "FK_Transaction_Payee_PayeeName",
                table: "Transaction",
                column: "PayeeName",
                principalTable: "Payee",
                principalColumn: "Name",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Transaction_Payee_PayeeName",
                table: "Transaction");

            migrationBuilder.DropIndex(
                name: "IX_Transaction_PayeeName",
                table: "Transaction");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Payee",
                table: "Payee");

            migrationBuilder.DropColumn(
                name: "PayeeName",
                table: "Transaction");

            migrationBuilder.AddColumn<int>(
                name: "PayeeId",
                table: "Transaction",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ID",
                table: "Payee",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            migrationBuilder.CreateIndex(
                name: "IX_Transaction_PayeeId",
                table: "Transaction",
                column: "PayeeId");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Payee",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Payee",
                table: "Payee",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Transaction_Payee_PayeeId",
                table: "Transaction",
                column: "PayeeId",
                principalTable: "Payee",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ReturnOrderMgmtSystemV1.Migrations
{
    public partial class updatePaymentDbAddTxnDate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "TxnDate",
                table: "paymentDetails",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TxnDate",
                table: "paymentDetails");
        }
    }
}

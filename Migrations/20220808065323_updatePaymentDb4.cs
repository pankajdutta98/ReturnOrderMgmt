using Microsoft.EntityFrameworkCore.Migrations;

namespace ReturnOrderMgmtSystemV1.Migrations
{
    public partial class updatePaymentDb4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_paymentDetails",
                table: "paymentDetails");

            migrationBuilder.DropColumn(
                name: "RequestId",
                table: "paymentDetails");

            migrationBuilder.AlterColumn<string>(
                name: "CardNbr",
                table: "paymentDetails",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_paymentDetails",
                table: "paymentDetails",
                column: "CardNbr");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_paymentDetails",
                table: "paymentDetails");

            migrationBuilder.AlterColumn<string>(
                name: "CardNbr",
                table: "paymentDetails",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<string>(
                name: "RequestId",
                table: "paymentDetails",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_paymentDetails",
                table: "paymentDetails",
                column: "RequestId");
        }
    }
}

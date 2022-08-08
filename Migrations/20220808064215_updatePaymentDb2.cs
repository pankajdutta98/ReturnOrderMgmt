using Microsoft.EntityFrameworkCore.Migrations;

namespace ReturnOrderMgmtSystemV1.Migrations
{
    public partial class updatePaymentDb2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_paymentDetails",
                table: "paymentDetails");

            migrationBuilder.AlterColumn<string>(
                name: "CardNbr",
                table: "paymentDetails",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<string>(
                name: "RequestId",
                table: "paymentDetails",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_paymentDetails",
                table: "paymentDetails",
                column: "RequestId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AddPrimaryKey(
                name: "PK_paymentDetails",
                table: "paymentDetails",
                column: "CardNbr");
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ReturnOrderMgmtSystemV1.Migrations
{
    public partial class addProcessedOrderDataDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "processedOrderData",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RequestId = table.Column<string>(maxLength: 15, nullable: false),
                    customerName = table.Column<string>(nullable: true),
                    CustContactNo = table.Column<string>(maxLength: 10, nullable: true),
                    ComponentType = table.Column<string>(nullable: false),
                    ComponentName = table.Column<string>(nullable: true),
                    Quantity = table.Column<float>(nullable: false),
                    ProcessingCharge = table.Column<double>(nullable: false),
                    PckgngAndDlvryCharge = table.Column<double>(nullable: false),
                    DateOfDelivery = table.Column<DateTime>(nullable: false),
                    RequestDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_processedOrderData", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "processedOrderData");
        }
    }
}

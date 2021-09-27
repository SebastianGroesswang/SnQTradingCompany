using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SnQTradingCompany.Logic.Migrations
{
    public partial class addCOndition : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Condition",
                schema: "App",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    CostumerId = table.Column<int>(type: "int", nullable: false),
                    ConditionType = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<double>(type: "float", nullable: false),
                    Value = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    RowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Condition", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Condition_Costumer_CostumerId",
                        column: x => x.CostumerId,
                        principalSchema: "ItemMaster",
                        principalTable: "Costumer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Condition_Product_ProductId",
                        column: x => x.ProductId,
                        principalSchema: "ItemMaster",
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Condition_CostumerId",
                schema: "App",
                table: "Condition",
                column: "CostumerId");

            migrationBuilder.CreateIndex(
                name: "IX_Condition_ProductId",
                schema: "App",
                table: "Condition",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Condition",
                schema: "App");
        }
    }
}

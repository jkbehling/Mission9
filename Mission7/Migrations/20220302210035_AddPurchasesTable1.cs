using Microsoft.EntityFrameworkCore.Migrations;

namespace Mission7.Migrations
{
    public partial class AddPurchasesTable1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BasketLineItem_Purchases_PurchaseDonationId",
                table: "BasketLineItem");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Purchases",
                table: "Purchases");

            migrationBuilder.DropIndex(
                name: "IX_BasketLineItem_PurchaseDonationId",
                table: "BasketLineItem");

            migrationBuilder.DropColumn(
                name: "DonationId",
                table: "Purchases");

            migrationBuilder.DropColumn(
                name: "PurchaseDonationId",
                table: "BasketLineItem");

            migrationBuilder.AddColumn<int>(
                name: "OrderId",
                table: "Purchases",
                nullable: false,
                defaultValue: 0)
                .Annotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddColumn<int>(
                name: "PurchaseOrderId",
                table: "BasketLineItem",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Purchases",
                table: "Purchases",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_BasketLineItem_PurchaseOrderId",
                table: "BasketLineItem",
                column: "PurchaseOrderId");

            migrationBuilder.AddForeignKey(
                name: "FK_BasketLineItem_Purchases_PurchaseOrderId",
                table: "BasketLineItem",
                column: "PurchaseOrderId",
                principalTable: "Purchases",
                principalColumn: "OrderId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BasketLineItem_Purchases_PurchaseOrderId",
                table: "BasketLineItem");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Purchases",
                table: "Purchases");

            migrationBuilder.DropIndex(
                name: "IX_BasketLineItem_PurchaseOrderId",
                table: "BasketLineItem");

            migrationBuilder.DropColumn(
                name: "OrderId",
                table: "Purchases");

            migrationBuilder.DropColumn(
                name: "PurchaseOrderId",
                table: "BasketLineItem");

            migrationBuilder.AddColumn<int>(
                name: "DonationId",
                table: "Purchases",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0)
                .Annotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddColumn<int>(
                name: "PurchaseDonationId",
                table: "BasketLineItem",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Purchases",
                table: "Purchases",
                column: "DonationId");

            migrationBuilder.CreateIndex(
                name: "IX_BasketLineItem_PurchaseDonationId",
                table: "BasketLineItem",
                column: "PurchaseDonationId");

            migrationBuilder.AddForeignKey(
                name: "FK_BasketLineItem_Purchases_PurchaseDonationId",
                table: "BasketLineItem",
                column: "PurchaseDonationId",
                principalTable: "Purchases",
                principalColumn: "DonationId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

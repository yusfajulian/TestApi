using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TestApi.Migrations
{
    public partial class semua : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tb_custommer",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    custommer_name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_custommer", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "tb_payment_method",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    is_active = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_payment_method", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "tb_product",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name_product = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    price = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_product", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "tb_custommer_addresses",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    custommerid = table.Column<int>(type: "int", nullable: true),
                    address = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_custommer_addresses", x => x.id);
                    table.ForeignKey(
                        name: "FK_tb_custommer_addresses_tb_custommer_custommerid",
                        column: x => x.custommerid,
                        principalTable: "tb_custommer",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "tb_detail_payment",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    payment_Methodid = table.Column<int>(type: "int", nullable: true),
                    jumlah = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_detail_payment", x => x.id);
                    table.ForeignKey(
                        name: "FK_tb_detail_payment_tb_payment_method_payment_Methodid",
                        column: x => x.payment_Methodid,
                        principalTable: "tb_payment_method",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "tb_detail_product",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    productid = table.Column<int>(type: "int", nullable: true),
                    jumlah = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_detail_product", x => x.id);
                    table.ForeignKey(
                        name: "FK_tb_detail_product_tb_product_productid",
                        column: x => x.productid,
                        principalTable: "tb_product",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "tb_transaksi",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    productid = table.Column<int>(type: "int", nullable: true),
                    payment_Methodid = table.Column<int>(type: "int", nullable: true),
                    custommer_Addressid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_transaksi", x => x.id);
                    table.ForeignKey(
                        name: "FK_tb_transaksi_tb_custommer_addresses_custommer_Addressid",
                        column: x => x.custommer_Addressid,
                        principalTable: "tb_custommer_addresses",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_tb_transaksi_tb_payment_method_payment_Methodid",
                        column: x => x.payment_Methodid,
                        principalTable: "tb_payment_method",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_tb_transaksi_tb_product_productid",
                        column: x => x.productid,
                        principalTable: "tb_product",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tb_custommer_addresses_custommerid",
                table: "tb_custommer_addresses",
                column: "custommerid");

            migrationBuilder.CreateIndex(
                name: "IX_tb_detail_payment_payment_Methodid",
                table: "tb_detail_payment",
                column: "payment_Methodid");

            migrationBuilder.CreateIndex(
                name: "IX_tb_detail_product_productid",
                table: "tb_detail_product",
                column: "productid");

            migrationBuilder.CreateIndex(
                name: "IX_tb_transaksi_custommer_Addressid",
                table: "tb_transaksi",
                column: "custommer_Addressid");

            migrationBuilder.CreateIndex(
                name: "IX_tb_transaksi_payment_Methodid",
                table: "tb_transaksi",
                column: "payment_Methodid");

            migrationBuilder.CreateIndex(
                name: "IX_tb_transaksi_productid",
                table: "tb_transaksi",
                column: "productid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tb_detail_payment");

            migrationBuilder.DropTable(
                name: "tb_detail_product");

            migrationBuilder.DropTable(
                name: "tb_transaksi");

            migrationBuilder.DropTable(
                name: "tb_custommer_addresses");

            migrationBuilder.DropTable(
                name: "tb_payment_method");

            migrationBuilder.DropTable(
                name: "tb_product");

            migrationBuilder.DropTable(
                name: "tb_custommer");
        }
    }
}

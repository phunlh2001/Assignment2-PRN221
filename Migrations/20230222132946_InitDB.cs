using Microsoft.EntityFrameworkCore.Migrations;

namespace Assignment2.Migrations
{
    public partial class InitDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Cat_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cat_Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Cat_ID);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    pro_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    pro_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pro_quantity = table.Column<int>(type: "int", nullable: false),
                    pro_price = table.Column<long>(type: "bigint", nullable: false),
                    pro_description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cat_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.pro_id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_cat_id",
                        column: x => x.cat_id,
                        principalTable: "Categories",
                        principalColumn: "Cat_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Cat_ID", "Cat_Name" },
                values: new object[] { 1, "Samsung" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Cat_ID", "Cat_Name" },
                values: new object[] { 2, "Apple" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Cat_ID", "Cat_Name" },
                values: new object[] { 3, "Nokia" });

            migrationBuilder.CreateIndex(
                name: "IX_Products_cat_id",
                table: "Products",
                column: "cat_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}

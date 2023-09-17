using Microsoft.EntityFrameworkCore.Migrations;

namespace morePoints.Migrations
{
    public partial class JerseyViewItem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "JerseyItem",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    jerseyid = table.Column<int>(type: "int", nullable: true),
                    price = table.Column<int>(type: "int", nullable: false),
                    JerseyViewId = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JerseyItem", x => x.id);
                    table.ForeignKey(
                        name: "FK_JerseyItem_Jersey_jerseyid",
                        column: x => x.jerseyid,
                        principalTable: "Jersey",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_JerseyItem_jerseyid",
                table: "JerseyItem",
                column: "jerseyid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "JerseyItem");
        }
    }
}

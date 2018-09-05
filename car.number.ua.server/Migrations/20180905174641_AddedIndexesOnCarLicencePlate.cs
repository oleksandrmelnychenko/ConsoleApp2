using Microsoft.EntityFrameworkCore.Migrations;

namespace car.id.server.Migrations
{
    public partial class AddedIndexesOnCarLicencePlate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Posts2018_NRegNew",
                table: "Posts2018",
                column: "NRegNew");

            migrationBuilder.CreateIndex(
                name: "IX_Posts2017_NRegNew",
                table: "Posts2017",
                column: "NRegNew");

            migrationBuilder.CreateIndex(
                name: "IX_Posts2016_NRegNew",
                table: "Posts2016",
                column: "NRegNew");

            migrationBuilder.CreateIndex(
                name: "IX_Posts2015_NRegNew",
                table: "Posts2015",
                column: "NRegNew");

            migrationBuilder.CreateIndex(
                name: "IX_Posts2014_NRegNew",
                table: "Posts2014",
                column: "NRegNew");

            migrationBuilder.CreateIndex(
                name: "IX_Posts2013_NRegNew",
                table: "Posts2013",
                column: "NRegNew");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_NRegNew",
                table: "Posts",
                column: "NRegNew");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Posts2018_NRegNew",
                table: "Posts2018");

            migrationBuilder.DropIndex(
                name: "IX_Posts2017_NRegNew",
                table: "Posts2017");

            migrationBuilder.DropIndex(
                name: "IX_Posts2016_NRegNew",
                table: "Posts2016");

            migrationBuilder.DropIndex(
                name: "IX_Posts2015_NRegNew",
                table: "Posts2015");

            migrationBuilder.DropIndex(
                name: "IX_Posts2014_NRegNew",
                table: "Posts2014");

            migrationBuilder.DropIndex(
                name: "IX_Posts2013_NRegNew",
                table: "Posts2013");

            migrationBuilder.DropIndex(
                name: "IX_Posts_NRegNew",
                table: "Posts");
        }
    }
}

using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace car.id.server.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Person = table.Column<string>(nullable: true),
                    RegAddrKoatuu = table.Column<string>(nullable: true),
                    OperCode = table.Column<string>(nullable: true),
                    OperName = table.Column<string>(nullable: true),
                    DReg = table.Column<string>(nullable: true),
                    DepCode = table.Column<string>(nullable: true),
                    Dep = table.Column<string>(nullable: true),
                    Brand = table.Column<string>(nullable: true),
                    ModelName = table.Column<string>(nullable: true),
                    MakeYear = table.Column<string>(nullable: true),
                    Color = table.Column<string>(nullable: true),
                    Kind = table.Column<string>(nullable: true),
                    Body = table.Column<string>(nullable: true),
                    Purpose = table.Column<string>(nullable: true),
                    Fuel = table.Column<string>(nullable: true),
                    Capacity = table.Column<string>(nullable: true),
                    OwnWeight = table.Column<string>(nullable: true),
                    TotalWeight = table.Column<string>(nullable: true),
                    NRegNew = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Posts");
        }
    }
}

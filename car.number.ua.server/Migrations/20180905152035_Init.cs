using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace car.id.server.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Person = table.Column<string>(maxLength: 250, nullable: true),
                    RegAddrKoatuu = table.Column<string>(maxLength: 250, nullable: true),
                    OperCode = table.Column<string>(maxLength: 250, nullable: true),
                    OperName = table.Column<string>(maxLength: 250, nullable: true),
                    DReg = table.Column<string>(maxLength: 250, nullable: true),
                    DepCode = table.Column<string>(maxLength: 250, nullable: true),
                    Dep = table.Column<string>(maxLength: 250, nullable: true),
                    Brand = table.Column<string>(maxLength: 250, nullable: true),
                    ModelName = table.Column<string>(maxLength: 250, nullable: true),
                    MakeYear = table.Column<string>(maxLength: 250, nullable: true),
                    Color = table.Column<string>(maxLength: 250, nullable: true),
                    Kind = table.Column<string>(maxLength: 250, nullable: true),
                    Body = table.Column<string>(maxLength: 250, nullable: true),
                    Purpose = table.Column<string>(maxLength: 250, nullable: true),
                    Fuel = table.Column<string>(maxLength: 250, nullable: true),
                    Capacity = table.Column<string>(maxLength: 250, nullable: true),
                    OwnWeight = table.Column<string>(maxLength: 250, nullable: true),
                    TotalWeight = table.Column<string>(maxLength: 250, nullable: true),
                    NRegNew = table.Column<string>(maxLength: 50, nullable: true)
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

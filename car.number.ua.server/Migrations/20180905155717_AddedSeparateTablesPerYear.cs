using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace car.id.server.Migrations
{
    public partial class AddedSeparateTablesPerYear : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Posts2013",
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
                    table.PrimaryKey("PK_Posts2013", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Posts2014",
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
                    table.PrimaryKey("PK_Posts2014", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Posts2015",
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
                    table.PrimaryKey("PK_Posts2015", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Posts2016",
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
                    table.PrimaryKey("PK_Posts2016", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Posts2017",
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
                    table.PrimaryKey("PK_Posts2017", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Posts2018",
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
                    table.PrimaryKey("PK_Posts2018", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Posts2013");

            migrationBuilder.DropTable(
                name: "Posts2014");

            migrationBuilder.DropTable(
                name: "Posts2015");

            migrationBuilder.DropTable(
                name: "Posts2016");

            migrationBuilder.DropTable(
                name: "Posts2017");

            migrationBuilder.DropTable(
                name: "Posts2018");
        }
    }
}

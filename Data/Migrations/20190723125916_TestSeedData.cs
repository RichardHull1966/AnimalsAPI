using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AnimalsAPI.Data.Migrations
{
    public partial class TestSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cats",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    Type = table.Column<string>(maxLength: 100, nullable: false),
                    YearOfBirth = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cats", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Hamsters",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 150, nullable: false),
                    Age = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hamsters", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Cats",
                columns: new[] { "Id", "Name", "Type", "YearOfBirth" },
                values: new object[,]
                {
                    { 1, "Amber", "Bengal", 2000 },
                    { 2, "Tiddles", "Tabby", 2010 },
                    { 3, "Mr Mestopheles", "Ginger tom", 2001 },
                    { 4, "Spot", "Old moggy", 2012 }
                });

            migrationBuilder.InsertData(
                table: "Hamsters",
                columns: new[] { "Id", "Age", "Name" },
                values: new object[,]
                {
                    { 1, 2, "Squealer" },
                    { 2, 1, "Squidgy" },
                    { 3, 3, "Fluff Bag" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cats");

            migrationBuilder.DropTable(
                name: "Hamsters");
        }
    }
}

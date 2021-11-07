using Microsoft.EntityFrameworkCore.Migrations;

namespace ArabalarDunyasii.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Arabalar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Model = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Yil = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Arabalar", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Arabalar",
                columns: new[] { "Id", "Model", "Yil" },
                values: new object[,]
                {
                    { 1, "Volkswagen Passat 1.6 TDI BlueMotion ComfortLine", 2018 },
                    { 2, "Seat Ibiza 1.6 Stella", 2001 },
                    { 3, "Renault Fluence 1.5 dCi Authentique", 2011 },
                    { 4, "Seat Leon 1.6 TDI CR Style", 2014 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Arabalar");
        }
    }
}

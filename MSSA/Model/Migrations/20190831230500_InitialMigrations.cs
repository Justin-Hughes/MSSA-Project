using Microsoft.EntityFrameworkCore.Migrations;

namespace MSSA.Model.Migrations
{
    public partial class InitialMigrations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Statistics",
                columns: table => new
                {
                    Username = table.Column<string>(nullable: false),
                    Wins = table.Column<long>(nullable: false),
                    Losses = table.Column<long>(nullable: false),
                    Draws = table.Column<long>(nullable: false),
                    TotalShotsFired = table.Column<long>(nullable: false),
                    TotalDistanceTraveled = table.Column<long>(nullable: false),
                    TotalDamageDealt = table.Column<long>(nullable: false),
                    Accuracy = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Statistics", x => x.Username);
                });

            migrationBuilder.CreateTable(
                name: "Tank",
                columns: table => new
                {
                    Username = table.Column<string>(nullable: false),
                    Health = table.Column<int>(nullable: false),
                    WeaponName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tank", x => x.Username);
                });

            migrationBuilder.CreateTable(
                name: "Weapon",
                columns: table => new
                {
                    WeaponName = table.Column<string>(nullable: false),
                    TrajectoryType = table.Column<string>(nullable: true),
                    Damage = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Weapon", x => x.WeaponName);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Statistics");

            migrationBuilder.DropTable(
                name: "Tank");

            migrationBuilder.DropTable(
                name: "Weapon");
        }
    }
}

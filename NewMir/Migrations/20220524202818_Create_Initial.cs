using Microsoft.EntityFrameworkCore.Migrations;

namespace NewMir.Migrations
{
    public partial class Create_Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Good_Talons",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    name = table.Column<string>(nullable: true),
                    fio = table.Column<string>(nullable: true),
                    otchestvo = table.Column<string>(nullable: true),
                    vrach = table.Column<string>(nullable: true),
                    data = table.Column<string>(nullable: true),
                    time = table.Column<string>(nullable: true),
                    name_hospital = table.Column<string>(nullable: true),
                    number_kabinet = table.Column<string>(nullable: true),
                    stoimost = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Good_Talons", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Hospitals",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    name = table.Column<string>(nullable: true),
                    adres = table.Column<string>(nullable: true),
                    all_vrach = table.Column<string>(nullable: true),
                    img = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hospitals", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Kabinets",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    number_kabinet = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kabinets", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Stores",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    name = table.Column<string>(nullable: true),
                    fio = table.Column<string>(nullable: true),
                    otchestvo = table.Column<string>(nullable: true),
                    vrach = table.Column<string>(nullable: true),
                    data = table.Column<string>(nullable: true),
                    time = table.Column<string>(nullable: true),
                    name_hospital = table.Column<string>(nullable: true),
                    number_kabinet = table.Column<int>(nullable: false),
                    stoimost = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stores", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Talons",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    name = table.Column<string>(nullable: true),
                    fio = table.Column<string>(nullable: true),
                    otchestvo = table.Column<string>(nullable: true),
                    vrach = table.Column<string>(nullable: true),
                    data = table.Column<string>(nullable: true),
                    time = table.Column<string>(nullable: true),
                    yslyga = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Talons", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    login = table.Column<string>(nullable: true),
                    password = table.Column<string>(nullable: true),
                    email = table.Column<string>(nullable: true),
                    name = table.Column<string>(nullable: true),
                    fio = table.Column<string>(nullable: true),
                    otchestvo = table.Column<string>(nullable: true),
                    data = table.Column<string>(nullable: true),
                    prava_dostypa = table.Column<bool>(nullable: false),
                    img = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Vrachs",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    name = table.Column<string>(nullable: true),
                    fio = table.Column<string>(nullable: true),
                    otchestvo = table.Column<string>(nullable: true),
                    spechialnost = table.Column<string>(nullable: true),
                    Grahic_vrach = table.Column<string>(nullable: true),
                    time = table.Column<string>(nullable: true),
                    name_hospital = table.Column<string>(nullable: true),
                    number_kabinet = table.Column<int>(nullable: false),
                    img = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vrachs", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Yslygs",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    name = table.Column<string>(nullable: true),
                    stoimost = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Yslygs", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Good_Talons");

            migrationBuilder.DropTable(
                name: "Hospitals");

            migrationBuilder.DropTable(
                name: "Kabinets");

            migrationBuilder.DropTable(
                name: "Stores");

            migrationBuilder.DropTable(
                name: "Talons");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Vrachs");

            migrationBuilder.DropTable(
                name: "Yslygs");
        }
    }
}

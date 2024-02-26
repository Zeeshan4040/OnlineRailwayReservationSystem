using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineRailwayReservationSystem.Migrations
{
    public partial class RailwayReservation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tbl_StationMaster",
                columns: table => new
                {
                    Station_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Station_Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Station_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Station_Type = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbl_StationMaster", x => x.Station_Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tbl_StationMaster");
        }
    }
}

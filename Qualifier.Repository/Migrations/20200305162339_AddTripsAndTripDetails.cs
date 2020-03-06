using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Qualifier.Repository.Migrations
{
    public partial class AddTripsAndTripDetails : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Plaque",
                table: "Taxis");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Taxis",
                newName: "TaxiId");

            migrationBuilder.AddColumn<string>(
                name: "CarPlate",
                table: "Taxis",
                maxLength: 9,
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Trips",
                columns: table => new
                {
                    TripId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    StartDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: true),
                    Source = table.Column<string>(maxLength: 100, nullable: true),
                    Target = table.Column<string>(maxLength: 100, nullable: true),
                    Qaulification = table.Column<float>(nullable: false),
                    SourceLatitude = table.Column<string>(nullable: true),
                    SourceLongitude = table.Column<string>(nullable: true),
                    TargetLatitude = table.Column<string>(nullable: true),
                    TargetLongitude = table.Column<string>(nullable: true),
                    Remarks = table.Column<string>(nullable: true),
                    TaxiId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trips", x => x.TripId);
                    table.ForeignKey(
                        name: "FK_Trips_Taxis_TaxiId",
                        column: x => x.TaxiId,
                        principalTable: "Taxis",
                        principalColumn: "TaxiId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TripDetails",
                columns: table => new
                {
                    TripDetailId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Date = table.Column<DateTime>(nullable: false),
                    TripId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TripDetails", x => x.TripDetailId);
                    table.ForeignKey(
                        name: "FK_TripDetails_Trips_TripId",
                        column: x => x.TripId,
                        principalTable: "Trips",
                        principalColumn: "TripId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TripDetails_TripId",
                table: "TripDetails",
                column: "TripId");

            migrationBuilder.CreateIndex(
                name: "IX_Trips_TaxiId",
                table: "Trips",
                column: "TaxiId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TripDetails");

            migrationBuilder.DropTable(
                name: "Trips");

            migrationBuilder.DropColumn(
                name: "CarPlate",
                table: "Taxis");

            migrationBuilder.RenameColumn(
                name: "TaxiId",
                table: "Taxis",
                newName: "Id");

            migrationBuilder.AddColumn<string>(
                name: "Plaque",
                table: "Taxis",
                maxLength: 6,
                nullable: false,
                defaultValue: "");
        }
    }
}

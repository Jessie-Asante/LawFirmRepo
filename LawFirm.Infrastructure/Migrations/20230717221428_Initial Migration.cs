using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LawFirm.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TblAboutTags",
                columns: table => new
                {
                    AbtId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Image = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    ImageHeader = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Caption = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblAboutTags", x => x.AbtId);
                });

            migrationBuilder.CreateTable(
                name: "TblBookingTags",
                columns: table => new
                {
                    BktId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Day = table.Column<int>(type: "int", nullable: false),
                    dtpDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblBookingTags", x => x.BktId);
                });

            migrationBuilder.CreateTable(
                name: "TblHomeTags",
                columns: table => new
                {
                    HmtId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Image = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    ImageHeader = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Caption = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblHomeTags", x => x.HmtId);
                });

            migrationBuilder.CreateTable(
                name: "TblReasonsTags",
                columns: table => new
                {
                    RstId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Comments = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblReasonsTags", x => x.RstId);
                });

            migrationBuilder.CreateTable(
                name: "TblServiceTags",
                columns: table => new
                {
                    SvtId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Header = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Comments = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblServiceTags", x => x.SvtId);
                });

            migrationBuilder.CreateTable(
                name: "TblUserBookings",
                columns: table => new
                {
                    UsbId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmailAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MobNox = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblUserBookings", x => x.UsbId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TblAboutTags");

            migrationBuilder.DropTable(
                name: "TblBookingTags");

            migrationBuilder.DropTable(
                name: "TblHomeTags");

            migrationBuilder.DropTable(
                name: "TblReasonsTags");

            migrationBuilder.DropTable(
                name: "TblServiceTags");

            migrationBuilder.DropTable(
                name: "TblUserBookings");
        }
    }
}

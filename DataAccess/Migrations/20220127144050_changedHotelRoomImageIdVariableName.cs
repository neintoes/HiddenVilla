using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class changedHotelRoomImageIdVariableName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HotelRoomImage_RoomModel_HotelRoomId",
                table: "HotelRoomImage");

            migrationBuilder.DropColumn(
                name: "RoomId",
                table: "HotelRoomImage");

            migrationBuilder.AlterColumn<int>(
                name: "HotelRoomId",
                table: "HotelRoomImage",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_HotelRoomImage_RoomModel_HotelRoomId",
                table: "HotelRoomImage",
                column: "HotelRoomId",
                principalTable: "RoomModel",
                principalColumn: "HotelRoomId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HotelRoomImage_RoomModel_HotelRoomId",
                table: "HotelRoomImage");

            migrationBuilder.AlterColumn<int>(
                name: "HotelRoomId",
                table: "HotelRoomImage",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "RoomId",
                table: "HotelRoomImage",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_HotelRoomImage_RoomModel_HotelRoomId",
                table: "HotelRoomImage",
                column: "HotelRoomId",
                principalTable: "RoomModel",
                principalColumn: "HotelRoomId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

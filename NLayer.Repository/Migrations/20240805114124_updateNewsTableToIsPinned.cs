using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NLayer.Repository.Migrations
{
    /// <inheritdoc />
    public partial class updateNewsTableToIsPinned : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "IsPinned",
                table: "News",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.UpdateData(
                table: "Albumes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 5, 14, 41, 24, 694, DateTimeKind.Local).AddTicks(8674));

            migrationBuilder.UpdateData(
                table: "Albumes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 5, 14, 41, 24, 694, DateTimeKind.Local).AddTicks(8682));

            migrationBuilder.UpdateData(
                table: "Albumes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 5, 14, 41, 24, 694, DateTimeKind.Local).AddTicks(8683));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 5, 14, 41, 24, 694, DateTimeKind.Local).AddTicks(8819));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 5, 14, 41, 24, 694, DateTimeKind.Local).AddTicks(8821));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 5, 14, 41, 24, 694, DateTimeKind.Local).AddTicks(8822));

            migrationBuilder.UpdateData(
                table: "NewsComments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CommentedDate",
                value: new DateTime(2024, 8, 5, 14, 41, 24, 694, DateTimeKind.Local).AddTicks(8742));

            migrationBuilder.UpdateData(
                table: "NewsComments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CommentedDate",
                value: new DateTime(2024, 8, 5, 14, 41, 24, 694, DateTimeKind.Local).AddTicks(8744));

            migrationBuilder.UpdateData(
                table: "NewsComments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CommentedDate",
                value: new DateTime(2024, 8, 5, 14, 41, 24, 694, DateTimeKind.Local).AddTicks(8745));

            migrationBuilder.UpdateData(
                table: "NewsComments",
                keyColumn: "Id",
                keyValue: 4,
                column: "CommentedDate",
                value: new DateTime(2024, 8, 5, 14, 41, 24, 694, DateTimeKind.Local).AddTicks(8746));

            migrationBuilder.UpdateData(
                table: "PictureComments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CommentedDate",
                value: new DateTime(2024, 8, 5, 14, 41, 24, 694, DateTimeKind.Local).AddTicks(8876));

            migrationBuilder.UpdateData(
                table: "PictureComments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CommentedDate",
                value: new DateTime(2024, 8, 5, 14, 41, 24, 694, DateTimeKind.Local).AddTicks(8878));

            migrationBuilder.UpdateData(
                table: "PictureComments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CommentedDate",
                value: new DateTime(2024, 8, 5, 14, 41, 24, 694, DateTimeKind.Local).AddTicks(8879));

            migrationBuilder.UpdateData(
                table: "PictureComments",
                keyColumn: "Id",
                keyValue: 4,
                column: "CommentedDate",
                value: new DateTime(2024, 8, 5, 14, 41, 24, 694, DateTimeKind.Local).AddTicks(8880));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "IsPinned",
                table: "News",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Albumes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 4, 0, 44, 44, 154, DateTimeKind.Local).AddTicks(2659));

            migrationBuilder.UpdateData(
                table: "Albumes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 4, 0, 44, 44, 154, DateTimeKind.Local).AddTicks(2669));

            migrationBuilder.UpdateData(
                table: "Albumes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 4, 0, 44, 44, 154, DateTimeKind.Local).AddTicks(2670));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 4, 0, 44, 44, 154, DateTimeKind.Local).AddTicks(2810));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 4, 0, 44, 44, 154, DateTimeKind.Local).AddTicks(2812));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 4, 0, 44, 44, 154, DateTimeKind.Local).AddTicks(2813));

            migrationBuilder.UpdateData(
                table: "NewsComments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CommentedDate",
                value: new DateTime(2024, 8, 4, 0, 44, 44, 154, DateTimeKind.Local).AddTicks(2738));

            migrationBuilder.UpdateData(
                table: "NewsComments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CommentedDate",
                value: new DateTime(2024, 8, 4, 0, 44, 44, 154, DateTimeKind.Local).AddTicks(2740));

            migrationBuilder.UpdateData(
                table: "NewsComments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CommentedDate",
                value: new DateTime(2024, 8, 4, 0, 44, 44, 154, DateTimeKind.Local).AddTicks(2741));

            migrationBuilder.UpdateData(
                table: "NewsComments",
                keyColumn: "Id",
                keyValue: 4,
                column: "CommentedDate",
                value: new DateTime(2024, 8, 4, 0, 44, 44, 154, DateTimeKind.Local).AddTicks(2742));

            migrationBuilder.UpdateData(
                table: "PictureComments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CommentedDate",
                value: new DateTime(2024, 8, 4, 0, 44, 44, 154, DateTimeKind.Local).AddTicks(2875));

            migrationBuilder.UpdateData(
                table: "PictureComments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CommentedDate",
                value: new DateTime(2024, 8, 4, 0, 44, 44, 154, DateTimeKind.Local).AddTicks(2877));

            migrationBuilder.UpdateData(
                table: "PictureComments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CommentedDate",
                value: new DateTime(2024, 8, 4, 0, 44, 44, 154, DateTimeKind.Local).AddTicks(2878));

            migrationBuilder.UpdateData(
                table: "PictureComments",
                keyColumn: "Id",
                keyValue: 4,
                column: "CommentedDate",
                value: new DateTime(2024, 8, 4, 0, 44, 44, 154, DateTimeKind.Local).AddTicks(2879));
        }
    }
}

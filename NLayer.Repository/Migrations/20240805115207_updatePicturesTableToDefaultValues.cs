using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NLayer.Repository.Migrations
{
    /// <inheritdoc />
    public partial class updatePicturesTableToDefaultValues : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Albumes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 5, 14, 52, 7, 92, DateTimeKind.Local).AddTicks(7561));

            migrationBuilder.UpdateData(
                table: "Albumes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 5, 14, 52, 7, 92, DateTimeKind.Local).AddTicks(7571));

            migrationBuilder.UpdateData(
                table: "Albumes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 5, 14, 52, 7, 92, DateTimeKind.Local).AddTicks(7572));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 5, 14, 52, 7, 92, DateTimeKind.Local).AddTicks(7705));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 5, 14, 52, 7, 92, DateTimeKind.Local).AddTicks(7707));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 5, 14, 52, 7, 92, DateTimeKind.Local).AddTicks(7708));

            migrationBuilder.UpdateData(
                table: "NewsComments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CommentedDate",
                value: new DateTime(2024, 8, 5, 14, 52, 7, 92, DateTimeKind.Local).AddTicks(7634));

            migrationBuilder.UpdateData(
                table: "NewsComments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CommentedDate",
                value: new DateTime(2024, 8, 5, 14, 52, 7, 92, DateTimeKind.Local).AddTicks(7635));

            migrationBuilder.UpdateData(
                table: "NewsComments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CommentedDate",
                value: new DateTime(2024, 8, 5, 14, 52, 7, 92, DateTimeKind.Local).AddTicks(7637));

            migrationBuilder.UpdateData(
                table: "NewsComments",
                keyColumn: "Id",
                keyValue: 4,
                column: "CommentedDate",
                value: new DateTime(2024, 8, 5, 14, 52, 7, 92, DateTimeKind.Local).AddTicks(7638));

            migrationBuilder.UpdateData(
                table: "PictureComments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CommentedDate",
                value: new DateTime(2024, 8, 5, 14, 52, 7, 92, DateTimeKind.Local).AddTicks(7768));

            migrationBuilder.UpdateData(
                table: "PictureComments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CommentedDate",
                value: new DateTime(2024, 8, 5, 14, 52, 7, 92, DateTimeKind.Local).AddTicks(7769));

            migrationBuilder.UpdateData(
                table: "PictureComments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CommentedDate",
                value: new DateTime(2024, 8, 5, 14, 52, 7, 92, DateTimeKind.Local).AddTicks(7771));

            migrationBuilder.UpdateData(
                table: "PictureComments",
                keyColumn: "Id",
                keyValue: 4,
                column: "CommentedDate",
                value: new DateTime(2024, 8, 5, 14, 52, 7, 92, DateTimeKind.Local).AddTicks(7772));

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PictureDislike", "PictureLike" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "PictureDislike", "PictureLike" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "PictureDislike", "PictureLike" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "PictureDislike", "PictureLike" },
                values: new object[] { 0, 0 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Albumes",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 5, 14, 46, 59, 959, DateTimeKind.Local).AddTicks(3848));

            migrationBuilder.UpdateData(
                table: "Albumes",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 5, 14, 46, 59, 959, DateTimeKind.Local).AddTicks(3858));

            migrationBuilder.UpdateData(
                table: "Albumes",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 5, 14, 46, 59, 959, DateTimeKind.Local).AddTicks(3859));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 5, 14, 46, 59, 959, DateTimeKind.Local).AddTicks(3983));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 5, 14, 46, 59, 959, DateTimeKind.Local).AddTicks(3984));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 8, 5, 14, 46, 59, 959, DateTimeKind.Local).AddTicks(3986));

            migrationBuilder.UpdateData(
                table: "NewsComments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CommentedDate",
                value: new DateTime(2024, 8, 5, 14, 46, 59, 959, DateTimeKind.Local).AddTicks(3918));

            migrationBuilder.UpdateData(
                table: "NewsComments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CommentedDate",
                value: new DateTime(2024, 8, 5, 14, 46, 59, 959, DateTimeKind.Local).AddTicks(3920));

            migrationBuilder.UpdateData(
                table: "NewsComments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CommentedDate",
                value: new DateTime(2024, 8, 5, 14, 46, 59, 959, DateTimeKind.Local).AddTicks(3921));

            migrationBuilder.UpdateData(
                table: "NewsComments",
                keyColumn: "Id",
                keyValue: 4,
                column: "CommentedDate",
                value: new DateTime(2024, 8, 5, 14, 46, 59, 959, DateTimeKind.Local).AddTicks(3922));

            migrationBuilder.UpdateData(
                table: "PictureComments",
                keyColumn: "Id",
                keyValue: 1,
                column: "CommentedDate",
                value: new DateTime(2024, 8, 5, 14, 46, 59, 959, DateTimeKind.Local).AddTicks(4042));

            migrationBuilder.UpdateData(
                table: "PictureComments",
                keyColumn: "Id",
                keyValue: 2,
                column: "CommentedDate",
                value: new DateTime(2024, 8, 5, 14, 46, 59, 959, DateTimeKind.Local).AddTicks(4044));

            migrationBuilder.UpdateData(
                table: "PictureComments",
                keyColumn: "Id",
                keyValue: 3,
                column: "CommentedDate",
                value: new DateTime(2024, 8, 5, 14, 46, 59, 959, DateTimeKind.Local).AddTicks(4045));

            migrationBuilder.UpdateData(
                table: "PictureComments",
                keyColumn: "Id",
                keyValue: 4,
                column: "CommentedDate",
                value: new DateTime(2024, 8, 5, 14, 46, 59, 959, DateTimeKind.Local).AddTicks(4046));

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PictureDislike", "PictureLike" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "PictureDislike", "PictureLike" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "PictureDislike", "PictureLike" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Pictures",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "PictureDislike", "PictureLike" },
                values: new object[] { null, null });
        }
    }
}

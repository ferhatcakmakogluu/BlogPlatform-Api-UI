using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NLayer.Repository.Migrations
{
    /// <inheritdoc />
    public partial class updatev2NewsTableToDefaultValues : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                columns: new[] { "CreatedDate", "DislikeCount", "LikeCount", "ReadCount" },
                values: new object[] { new DateTime(2024, 8, 5, 14, 46, 59, 959, DateTimeKind.Local).AddTicks(3983), 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "DislikeCount", "LikeCount", "ReadCount" },
                values: new object[] { new DateTime(2024, 8, 5, 14, 46, 59, 959, DateTimeKind.Local).AddTicks(3984), 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "DislikeCount", "LikeCount", "ReadCount" },
                values: new object[] { new DateTime(2024, 8, 5, 14, 46, 59, 959, DateTimeKind.Local).AddTicks(3986), 0, 0, 0 });

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                columns: new[] { "CreatedDate", "DislikeCount", "LikeCount", "ReadCount" },
                values: new object[] { new DateTime(2024, 8, 5, 14, 41, 24, 694, DateTimeKind.Local).AddTicks(8819), null, null, null });

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "DislikeCount", "LikeCount", "ReadCount" },
                values: new object[] { new DateTime(2024, 8, 5, 14, 41, 24, 694, DateTimeKind.Local).AddTicks(8821), null, null, null });

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "DislikeCount", "LikeCount", "ReadCount" },
                values: new object[] { new DateTime(2024, 8, 5, 14, 41, 24, 694, DateTimeKind.Local).AddTicks(8822), null, null, null });

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
    }
}

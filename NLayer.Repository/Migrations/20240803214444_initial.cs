using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NLayer.Repository.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Admins",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Role = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admins", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Albumes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AlbumeName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CoverPhoto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AlbumeLike = table.Column<int>(type: "int", nullable: true),
                    AlbumeDislike = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Albumes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "News",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(350)", maxLength: 350, nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    ReadCount = table.Column<int>(type: "int", nullable: true),
                    LikeCount = table.Column<int>(type: "int", nullable: true),
                    DislikeCount = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsPinned = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_News", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pictures",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PictureUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PictureLike = table.Column<int>(type: "int", nullable: true),
                    PictureDislike = table.Column<int>(type: "int", nullable: true),
                    AlbumeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pictures", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pictures_Albumes_AlbumeId",
                        column: x => x.AlbumeId,
                        principalTable: "Albumes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "NewsComments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Comment = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    CommentedBy = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    CommentedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NewsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NewsComments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NewsComments_News_NewsId",
                        column: x => x.NewsId,
                        principalTable: "News",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PictureComments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Comment = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    CommentedBy = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    CommentedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PicturesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PictureComments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PictureComments_Pictures_PicturesId",
                        column: x => x.PicturesId,
                        principalTable: "Pictures",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "Id", "LastName", "Name", "Password", "Role", "UserName" },
                values: new object[] { 1, "Admin", "Admin", "root123", "ADMIN", "root" });

            migrationBuilder.InsertData(
                table: "Albumes",
                columns: new[] { "Id", "AlbumeDislike", "AlbumeLike", "AlbumeName", "CoverPhoto", "CreatedDate", "Description", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, null, null, "Albume 1", null, new DateTime(2024, 8, 4, 0, 44, 44, 154, DateTimeKind.Local).AddTicks(2659), null, null },
                    { 2, null, null, "Albume 2", null, new DateTime(2024, 8, 4, 0, 44, 44, 154, DateTimeKind.Local).AddTicks(2669), null, null },
                    { 3, null, null, "Albume 3", null, new DateTime(2024, 8, 4, 0, 44, 44, 154, DateTimeKind.Local).AddTicks(2670), null, null }
                });

            migrationBuilder.InsertData(
                table: "News",
                columns: new[] { "Id", "CreatedDate", "Description", "DislikeCount", "IsPinned", "LikeCount", "ReadCount", "Title", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 8, 4, 0, 44, 44, 154, DateTimeKind.Local).AddTicks(2810), "Description 1", null, false, null, null, "News 1", null },
                    { 2, new DateTime(2024, 8, 4, 0, 44, 44, 154, DateTimeKind.Local).AddTicks(2812), "Description 2", null, false, null, null, "News 2", null },
                    { 3, new DateTime(2024, 8, 4, 0, 44, 44, 154, DateTimeKind.Local).AddTicks(2813), "Description 3", null, false, null, null, "News 3", null }
                });

            migrationBuilder.InsertData(
                table: "NewsComments",
                columns: new[] { "Id", "Comment", "CommentedBy", "CommentedDate", "NewsId" },
                values: new object[,]
                {
                    { 1, "Comment 1", "User 1", new DateTime(2024, 8, 4, 0, 44, 44, 154, DateTimeKind.Local).AddTicks(2738), 1 },
                    { 2, "Comment 2", "User 2", new DateTime(2024, 8, 4, 0, 44, 44, 154, DateTimeKind.Local).AddTicks(2740), 1 },
                    { 3, "Comment 3", "User 3", new DateTime(2024, 8, 4, 0, 44, 44, 154, DateTimeKind.Local).AddTicks(2741), 2 },
                    { 4, "Comment 4", "User 4", new DateTime(2024, 8, 4, 0, 44, 44, 154, DateTimeKind.Local).AddTicks(2742), 3 }
                });

            migrationBuilder.InsertData(
                table: "Pictures",
                columns: new[] { "Id", "AlbumeId", "PictureDislike", "PictureLike", "PictureUrl" },
                values: new object[,]
                {
                    { 1, 1, null, null, "/Pictures/1" },
                    { 2, 1, null, null, "/Pictures/2" },
                    { 3, 2, null, null, "/Pictures/3" },
                    { 4, 3, null, null, "/Pictures/4" }
                });

            migrationBuilder.InsertData(
                table: "PictureComments",
                columns: new[] { "Id", "Comment", "CommentedBy", "CommentedDate", "PicturesId" },
                values: new object[,]
                {
                    { 1, "Comment 1", "User 1", new DateTime(2024, 8, 4, 0, 44, 44, 154, DateTimeKind.Local).AddTicks(2875), 1 },
                    { 2, "Comment 2", "User 2", new DateTime(2024, 8, 4, 0, 44, 44, 154, DateTimeKind.Local).AddTicks(2877), 1 },
                    { 3, "Comment 3", "User 3", new DateTime(2024, 8, 4, 0, 44, 44, 154, DateTimeKind.Local).AddTicks(2878), 2 },
                    { 4, "Comment 4", "User 4", new DateTime(2024, 8, 4, 0, 44, 44, 154, DateTimeKind.Local).AddTicks(2879), 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_NewsComments_NewsId",
                table: "NewsComments",
                column: "NewsId");

            migrationBuilder.CreateIndex(
                name: "IX_PictureComments_PicturesId",
                table: "PictureComments",
                column: "PicturesId");

            migrationBuilder.CreateIndex(
                name: "IX_Pictures_AlbumeId",
                table: "Pictures",
                column: "AlbumeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admins");

            migrationBuilder.DropTable(
                name: "NewsComments");

            migrationBuilder.DropTable(
                name: "PictureComments");

            migrationBuilder.DropTable(
                name: "News");

            migrationBuilder.DropTable(
                name: "Pictures");

            migrationBuilder.DropTable(
                name: "Albumes");
        }
    }
}

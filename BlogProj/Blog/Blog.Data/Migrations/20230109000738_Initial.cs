using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Blog.Data.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Url = table.Column<string>(type: "TEXT", nullable: false),
                    ImageUrl = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Url = table.Column<string>(type: "TEXT", nullable: false),
                    ImgUrl = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PostCategories",
                columns: table => new
                {
                    PostId = table.Column<int>(type: "INTEGER", nullable: false),
                    CategoryId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostCategories", x => new { x.PostId, x.CategoryId });
                    table.ForeignKey(
                        name: "FK_PostCategories_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PostCategories_Posts_PostId",
                        column: x => x.PostId,
                        principalTable: "Posts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "ImageUrl", "Name", "Url" },
                values: new object[,]
                {
                    { 1, "1.webp", "Topics", "topics" },
                    { 2, "2.webp", "Platforms and Communities", "platforms_and_communities" },
                    { 3, "3.webp", "Companies", "companies" },
                    { 4, "4.webp", "Inspires", "inpires" }
                });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "ImgUrl", "Name", "Url" },
                values: new object[,]
                {
                    { 1, "1.jpg", "Code Better", "code_better" },
                    { 2, "2.jpg", "A List Apart", "a_list_apart" },
                    { 3, "3.jpg", "The Steelkiwi Blog", "the_steelkiwi_blog" },
                    { 4, "4.jpg", "Coding Horror", "coding_horror" },
                    { 5, "5.jpg", "Microsoft", "microsoft" },
                    { 6, "5.jpg", "Adobe", "adobe" },
                    { 7, "6.jpg", "Twilio", "twilio" },
                    { 8, "7.jpg", "Nutanix", "nutanix" },
                    { 9, "8.jpg", "Stack Overflow", "stack_overflow" },
                    { 10, "8.jpg", "Chrome Developer Tools", "chrome_developer_tools" },
                    { 11, "9.jpg", "GitHub", "github" },
                    { 12, "10.jpg", "jQuery", "jquery" },
                    { 13, "11.jpg", "Dennis Ritchie", "dennis_ritchie" },
                    { 14, "12.jpg", "Bjarne Stroustrup", "bjarne_stroustrup" },
                    { 15, "13.jpg", "James Gosling", "james_gosling" }
                });

            migrationBuilder.InsertData(
                table: "PostCategories",
                columns: new[] { "CategoryId", "PostId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 1, 3 },
                    { 1, 4 },
                    { 3, 5 },
                    { 3, 6 },
                    { 3, 7 },
                    { 3, 8 },
                    { 2, 9 },
                    { 2, 10 },
                    { 2, 11 },
                    { 2, 12 },
                    { 4, 13 },
                    { 4, 14 },
                    { 4, 15 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_PostCategories_CategoryId",
                table: "PostCategories",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PostCategories");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Posts");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace Bookman.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    CategoryId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CategoryName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Classification",
                columns: table => new
                {
                    ClassificationId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ClassificationName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Classification", x => x.ClassificationId);
                });

            migrationBuilder.CreateTable(
                name: "Purchase",
                columns: table => new
                {
                    PurchaseId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: false),
                    AddressLine1 = table.Column<string>(nullable: false),
                    AddressLine2 = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: false),
                    State = table.Column<string>(nullable: false),
                    Zipcode = table.Column<string>(nullable: false),
                    Country = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Purchase", x => x.PurchaseId);
                });

            migrationBuilder.CreateTable(
                name: "Book",
                columns: table => new
                {
                    BookId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(nullable: false),
                    Author = table.Column<string>(nullable: false),
                    Publisher = table.Column<string>(nullable: false),
                    ISBN = table.Column<string>(nullable: false),
                    CategoryId = table.Column<int>(nullable: false),
                    ClassificationId = table.Column<int>(nullable: false),
                    Pages = table.Column<int>(nullable: false),
                    Price = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Book", x => x.BookId);
                    table.ForeignKey(
                        name: "FK_Book_Category_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Category",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Book_Classification_ClassificationId",
                        column: x => x.ClassificationId,
                        principalTable: "Classification",
                        principalColumn: "ClassificationId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CartLineItem",
                columns: table => new
                {
                    LineID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    BookId = table.Column<int>(nullable: true),
                    Quantity = table.Column<int>(nullable: false),
                    Price = table.Column<double>(nullable: false),
                    PurchaseId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartLineItem", x => x.LineID);
                    table.ForeignKey(
                        name: "FK_CartLineItem_Book_BookId",
                        column: x => x.BookId,
                        principalTable: "Book",
                        principalColumn: "BookId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CartLineItem_Purchase_PurchaseId",
                        column: x => x.PurchaseId,
                        principalTable: "Purchase",
                        principalColumn: "PurchaseId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[] { 1, "Classic" });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[] { 2, "Biography" });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[] { 3, "Historical" });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[] { 4, "Self-Help" });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[] { 5, "Business" });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[] { 6, "Thriller" });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[] { 7, "Christian" });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[] { 8, "Health" });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[] { 9, "Action" });

            migrationBuilder.InsertData(
                table: "Classification",
                columns: new[] { "ClassificationId", "ClassificationName" },
                values: new object[] { 1, "Fiction" });

            migrationBuilder.InsertData(
                table: "Classification",
                columns: new[] { "ClassificationId", "ClassificationName" },
                values: new object[] { 2, "Non-Fiction" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "Author", "CategoryId", "ClassificationId", "ISBN", "Pages", "Price", "Publisher", "Title" },
                values: new object[] { 1, "Victor Hugo", 1, 1, "978-0451419439", 1488, 9.9499999999999993, "Signet", "Les Miserables" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "Author", "CategoryId", "ClassificationId", "ISBN", "Pages", "Price", "Publisher", "Title" },
                values: new object[] { 6, "Michael Crichton", 3, 1, "978-0804171281", 288, 13.33, "Random House", "The Great Train Robbery" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "Author", "CategoryId", "ClassificationId", "ISBN", "Pages", "Price", "Publisher", "Title" },
                values: new object[] { 10, "John Grisham", 6, 1, "978-0553393613", 642, 15.029999999999999, "Batnam", "Sycamore Row" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "Author", "CategoryId", "ClassificationId", "ISBN", "Pages", "Price", "Publisher", "Title" },
                values: new object[] { 11, "Mike Rowe", 3, 1, "978-1982131470", 272, 12.300000000000001, "Gallery Books", "The Way I Heard It" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "Author", "CategoryId", "ClassificationId", "ISBN", "Pages", "Price", "Publisher", "Title" },
                values: new object[] { 13, "C.S. Lewis", 7, 1, "978-0060652937", 209, 10.27, "HarperOne", "The Screwtape Letters" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "Author", "CategoryId", "ClassificationId", "ISBN", "Pages", "Price", "Publisher", "Title" },
                values: new object[] { 16, "Tom Clancy", 9, 1, "978-0440001027", 656, 9.9900000000000002, "Berkley", "The Hunt for Red October" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "Author", "CategoryId", "ClassificationId", "ISBN", "Pages", "Price", "Publisher", "Title" },
                values: new object[] { 2, "Doris Kearns Goodwin", 2, 2, "978-0743270755", 944, 14.58, "Simon & Schuster", "Team of Rivals" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "Author", "CategoryId", "ClassificationId", "ISBN", "Pages", "Price", "Publisher", "Title" },
                values: new object[] { 3, "Alice Schroeder", 2, 2, "978-0553384611", 832, 21.539999999999999, "Bantam", "The Snowball" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "Author", "CategoryId", "ClassificationId", "ISBN", "Pages", "Price", "Publisher", "Title" },
                values: new object[] { 4, "Ronald C. White", 2, 2, "978-0812981254", 864, 11.609999999999999, "Random House", "American Ulysses" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "Author", "CategoryId", "ClassificationId", "ISBN", "Pages", "Price", "Publisher", "Title" },
                values: new object[] { 5, "Laura Hillenbrand", 3, 2, "978-0812974492", 528, 13.33, "Random House", "Unbroken" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "Author", "CategoryId", "ClassificationId", "ISBN", "Pages", "Price", "Publisher", "Title" },
                values: new object[] { 7, "Cal Newport", 4, 2, "978-1455586691", 304, 14.99, "Vintage", "Deep Work" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "Author", "CategoryId", "ClassificationId", "ISBN", "Pages", "Price", "Publisher", "Title" },
                values: new object[] { 8, "Michael Abrashoff", 4, 2, "978-1455523023", 240, 21.66, "Grand Central Publishing", "It's Your Ship" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "Author", "CategoryId", "ClassificationId", "ISBN", "Pages", "Price", "Publisher", "Title" },
                values: new object[] { 9, "Richard Branson", 5, 2, "978-1591847984", 400, 29.16, "Grand Central Publishing", "The Virgin Way" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "Author", "CategoryId", "ClassificationId", "ISBN", "Pages", "Price", "Publisher", "Title" },
                values: new object[] { 12, "Unisses S. Grant", 2, 2, "978-1481216043", 552, 19.989999999999998, "CreateSpace Independent Publishing Platform", "The Complete Personal Memoirs of Ulysses S. Grant" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "Author", "CategoryId", "ClassificationId", "ISBN", "Pages", "Price", "Publisher", "Title" },
                values: new object[] { 14, "Shawn Stevenson", 8, 2, "978-1623367398", 288, 17.59, "Rodale Books", "Sleep Smarter" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "Author", "CategoryId", "ClassificationId", "ISBN", "Pages", "Price", "Publisher", "Title" },
                values: new object[] { 15, "Ron Chernow", 2, 2, "978-1400077304", 832, 16.59, "Vintage", "Titan" });

            migrationBuilder.CreateIndex(
                name: "IX_Book_CategoryId",
                table: "Book",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Book_ClassificationId",
                table: "Book",
                column: "ClassificationId");

            migrationBuilder.CreateIndex(
                name: "IX_CartLineItem_BookId",
                table: "CartLineItem",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_CartLineItem_PurchaseId",
                table: "CartLineItem",
                column: "PurchaseId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CartLineItem");

            migrationBuilder.DropTable(
                name: "Book");

            migrationBuilder.DropTable(
                name: "Purchase");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropTable(
                name: "Classification");
        }
    }
}

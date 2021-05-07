using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace TeamNET.Migrations
{
    public partial class EditSeedingData_16_04_2021 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "NotificationEventContents",
                columns: table => new
                {
                    NotificationEventContentId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    EventContentId = table.Column<int>(type: "integer", nullable: false),
                    UserId = table.Column<string>(type: "text", nullable: true),
                    Notification = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NotificationEventContents", x => x.NotificationEventContentId);
                    table.ForeignKey(
                        name: "FK_NotificationEventContents_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_NotificationEventContents_EventContents_EventContentId",
                        column: x => x.EventContentId,
                        principalTable: "EventContents",
                        principalColumn: "EventContentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "06b12f97-bb16-434a-9982-e3d3dc1c5145",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a889d8bb-7458-453d-b000-116c9e490a89", "AQAAAAEAACcQAAAAEJQXwS8kAcgkkifYWCuDT4iBnzlce/KwhToGvO+kBMrd8pzEysLVUM8I5aHsl36VzA==", "3a0fb5ad-ea1c-418b-a3cb-36eb54a53121" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "16a69b03-3b90-49a2-9cac-4b940c91514c",
                columns: new[] { "ConcurrencyStamp", "CourseCurrentId", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "be407338-0f3c-4fab-a565-82cbe6f8d5fd", 2, "TEACHER1@GMAIL.COM", "TEACHER1@GMAIL.COM", "AQAAAAEAACcQAAAAEGiP3FV9GreaS0/BNuhhRyZPYv2fgwazsCwN4KqAnWHZCuunopPzaZxriSoO0ndmcA==", "a7b4846c-b002-498a-988f-35f9765aba7c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1efe96d9-6618-4269-a6e3-ae1e3d3eecc4",
                columns: new[] { "ConcurrencyStamp", "CourseCurrentId", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f8f3fd37-7a17-43c9-a8e4-786addd64c29", 3, "TEACHER2@GMAIL.COM", "TEACHER2@GMAIL.COM", "AQAAAAEAACcQAAAAEG38DrkxZ2FRd2lFQ1RpkSCI7GVFGtEt5RFaWurSQbCLrBq1RGSGgpijvQ6JIx8DiQ==", "1682c816-289c-4340-bd59-b0f5105ce2fd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2115c7e6-9aae-43cb-a406-d504578498ba",
                columns: new[] { "ConcurrencyStamp", "CourseCurrentId", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f96fb037-0e72-42f1-bbf4-9ec1e9af59d6", 2, "DOCTOR1@GMAIL.COM", "DOCTOR1@GMAIL.COM", "AQAAAAEAACcQAAAAEH4I9RkGSUeE7leIx5FApQNO6IvGsx4VNQdQWSE7JCbN84/omw172nSOKnK11GY/kA==", "aa13b310-51e5-4ab6-8f12-642ccdcb0085" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "29a908b8-3ac4-45ea-a8a1-1cf9946079c7",
                columns: new[] { "ConcurrencyStamp", "CourseCurrentId", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ba1d22a9-228f-45f2-800a-f58e6a75dded", 3, "DOCTOR2@GMAIL.COM", "DOCTOR2@GMAIL.COM", "AQAAAAEAACcQAAAAEGl/S/g6WpyHH7+/XPo0KQYh72MBXW/UMbgayCyywdho2jU6uGM3BfX4m6shDtd5Tg==", "13f732c8-430b-482a-95ab-8f3051a531d5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2f3baf7f-a5b4-4627-abcb-0e42e2fb33a8",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "eae6add3-b092-499b-a15b-95f46f51347e", "STUDENT1@GMAIL.COM", "STUDENT1@GMAIL.COM", "AQAAAAEAACcQAAAAEHJfgNJjyLQGfU8GzjtCGq4KmNMk1dMxsnvbSBRNgVnuQYkazdHESF4vcdr2syCvbw==", "fbc7bc30-0773-49ec-967f-ce1253fa4b00" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2f67c183-6ebf-4920-9cca-7d1a7a2b173c",
                columns: new[] { "ConcurrencyStamp", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "12d67eb5-bc3f-41be-bb76-93d0cdc16aea", "Student2", "STUDENT2@GMAIL.COM", "STUDENT2@GMAIL.COM", "AQAAAAEAACcQAAAAEEdoQzI0H1FfijBeTT+CtQJGkVBEfcdi/X77gJZT6RSiY15G+RH2N0F4s936Qt9/tw==", "8c200244-54b9-4633-a3cc-d78faa480e69" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3c592e96-f3ad-4e8b-9cbe-afb7ea745362",
                columns: new[] { "ConcurrencyStamp", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4dd026e6-63c6-4873-a444-9e4b27d7c50f", "Student3", "STUDENT3@GMAIL.COM", "STUDENT3@GMAIL.COM", "AQAAAAEAACcQAAAAEM2bRSRhibHJ6bFPpkWYjgERAs2aspHs7iBTpgh0euCKCcTcWYEqUXy29tDcjioDfg==", "74b73a75-0f47-4bb0-be8f-a2a977d7cda9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3dabf300-50ab-438b-baaa-f6890f2b260c",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1bc8bd4e-12e6-4c3e-82df-2fe61f266713", "GUARDIAN1@GMAIL.COM", "GUARDIAN1@GMAIL.COM", "AQAAAAEAACcQAAAAEKiaHRddukbvZnhwc3+/nHZkVSaSY5DsZ/TFGX4tj73GX+9lJVVZpdUR8H68t/bLlA==", "d6f5ffb3-7ed8-4f59-b7df-6717a50b57f2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "560b9a81-71e6-4987-a6c2-ecf72ecd36b5",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "72c80930-54e9-4924-a131-7eb615efb422", "GUARDIAN2@GMAIL.COM", "GUARDIAN2@GMAIL.COM", "AQAAAAEAACcQAAAAEHH5rem1iGLSVdjBP0T+i9yw/dbZ8OFfpAO1JZHqA09nJdfXBnUKQDVOml4wkpB+AQ==", "4db0edf7-014f-455b-ad35-28892d0f5c03" });

            migrationBuilder.UpdateData(
                table: "EventContents",
                keyColumn: "EventContentId",
                keyValue: 10,
                column: "CourseCurrentId",
                value: 3);

            migrationBuilder.InsertData(
                table: "NotificationEventContents",
                columns: new[] { "NotificationEventContentId", "EventContentId", "Notification", "UserId" },
                values: new object[,]
                {
                    { 39, 10, 0, "29a908b8-3ac4-45ea-a8a1-1cf9946079c7" },
                    { 27, 7, 0, "2115c7e6-9aae-43cb-a406-d504578498ba" },
                    { 37, 10, 3, "3c592e96-f3ad-4e8b-9cbe-afb7ea745362" },
                    { 36, 9, 0, "560b9a81-71e6-4987-a6c2-ecf72ecd36b5" },
                    { 35, 9, 1, "2115c7e6-9aae-43cb-a406-d504578498ba" },
                    { 34, 9, 2, "16a69b03-3b90-49a2-9cac-4b940c91514c" },
                    { 33, 9, 1, "2f67c183-6ebf-4920-9cca-7d1a7a2b173c" },
                    { 32, 8, 3, "3dabf300-50ab-438b-baaa-f6890f2b260c" },
                    { 31, 8, 0, "2115c7e6-9aae-43cb-a406-d504578498ba" },
                    { 30, 8, 2, "16a69b03-3b90-49a2-9cac-4b940c91514c" },
                    { 29, 8, 0, "2f3baf7f-a5b4-4627-abcb-0e42e2fb33a8" },
                    { 28, 7, 0, "3dabf300-50ab-438b-baaa-f6890f2b260c" },
                    { 40, 10, 2, "3dabf300-50ab-438b-baaa-f6890f2b260c" },
                    { 38, 10, 2, "1efe96d9-6618-4269-a6e3-ae1e3d3eecc4" },
                    { 26, 7, 0, "16a69b03-3b90-49a2-9cac-4b940c91514c" },
                    { 24, 6, 0, "560b9a81-71e6-4987-a6c2-ecf72ecd36b5" },
                    { 2, 1, 0, "16a69b03-3b90-49a2-9cac-4b940c91514c" },
                    { 3, 1, 0, "2115c7e6-9aae-43cb-a406-d504578498ba" },
                    { 4, 1, 0, "3dabf300-50ab-438b-baaa-f6890f2b260c" },
                    { 5, 2, 0, "2f67c183-6ebf-4920-9cca-7d1a7a2b173c" },
                    { 6, 2, 0, "16a69b03-3b90-49a2-9cac-4b940c91514c" },
                    { 7, 2, 0, "2115c7e6-9aae-43cb-a406-d504578498ba" },
                    { 8, 2, 0, "560b9a81-71e6-4987-a6c2-ecf72ecd36b5" },
                    { 9, 3, 0, "2f3baf7f-a5b4-4627-abcb-0e42e2fb33a8" },
                    { 10, 3, 0, "16a69b03-3b90-49a2-9cac-4b940c91514c" },
                    { 11, 3, 0, "2115c7e6-9aae-43cb-a406-d504578498ba" },
                    { 25, 7, 0, "2f3baf7f-a5b4-4627-abcb-0e42e2fb33a8" },
                    { 12, 3, 0, "3dabf300-50ab-438b-baaa-f6890f2b260c" },
                    { 14, 4, 0, "16a69b03-3b90-49a2-9cac-4b940c91514c" },
                    { 15, 4, 0, "2115c7e6-9aae-43cb-a406-d504578498ba" },
                    { 16, 4, 0, "3dabf300-50ab-438b-baaa-f6890f2b260c" },
                    { 17, 5, 0, "2f3baf7f-a5b4-4627-abcb-0e42e2fb33a8" },
                    { 18, 5, 0, "16a69b03-3b90-49a2-9cac-4b940c91514c" },
                    { 19, 5, 0, "2115c7e6-9aae-43cb-a406-d504578498ba" },
                    { 20, 5, 0, "3dabf300-50ab-438b-baaa-f6890f2b260c" },
                    { 21, 6, 0, "2f67c183-6ebf-4920-9cca-7d1a7a2b173c" },
                    { 22, 6, 0, "16a69b03-3b90-49a2-9cac-4b940c91514c" },
                    { 23, 6, 0, "2115c7e6-9aae-43cb-a406-d504578498ba" },
                    { 13, 4, 0, "2f3baf7f-a5b4-4627-abcb-0e42e2fb33a8" },
                    { 1, 1, 0, "2f3baf7f-a5b4-4627-abcb-0e42e2fb33a8" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_NotificationEventContents_EventContentId",
                table: "NotificationEventContents",
                column: "EventContentId");

            migrationBuilder.CreateIndex(
                name: "IX_NotificationEventContents_UserId",
                table: "NotificationEventContents",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NotificationEventContents");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "06b12f97-bb16-434a-9982-e3d3dc1c5145",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "65d56646-f913-4b68-a41d-c0be3412e5a6", "AQAAAAEAACcQAAAAEGxGshXIHWypYXShcuQDAN9KKJNGjGouuTg8a+Mi6m6jTUuWPJ/5n2fqtEOk9VRHLQ==", "d59ae6b6-2f02-48ff-abe1-273af40f4415" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "16a69b03-3b90-49a2-9cac-4b940c91514c",
                columns: new[] { "ConcurrencyStamp", "CourseCurrentId", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f8213ffd-ad09-449b-909f-c2e650bb7c19", 0, null, null, "AQAAAAEAACcQAAAAEFPGuaZ62zpnuFSXq5p+KM17NsPXC4h4vP0hyCFskLJZDHUA5uNvMyatVEPByJ+uTQ==", "edc6bb0e-2a0b-4621-ab5d-84251d826673" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1efe96d9-6618-4269-a6e3-ae1e3d3eecc4",
                columns: new[] { "ConcurrencyStamp", "CourseCurrentId", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9fb85e41-aabe-440a-952f-236b00b497be", 0, null, null, "AQAAAAEAACcQAAAAEDaU6iV47UruZOFPdKwmqt68hFUbkYHRs9KiH1hbO2MroyTRYoYMjpK2aUobhh4xOw==", "f487044e-aaca-4ef8-8e5c-3ad92fea0594" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2115c7e6-9aae-43cb-a406-d504578498ba",
                columns: new[] { "ConcurrencyStamp", "CourseCurrentId", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "08ec9959-79b2-4c43-bd47-1b4bcaf94b17", 0, null, null, "AQAAAAEAACcQAAAAEL2xuWENoRiCCxyrsDvch87CXGpyeeU6+oOlrh30vBPcFwcyqSCe9O4QVZDpfDkLYw==", "4329c1ca-747c-4e9a-bd54-67c248075eed" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "29a908b8-3ac4-45ea-a8a1-1cf9946079c7",
                columns: new[] { "ConcurrencyStamp", "CourseCurrentId", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f3f2f900-c34f-4b49-8508-a47764b97f20", 0, null, null, "AQAAAAEAACcQAAAAEGZi+RA70IJz1nJI6V2qP4zX3oGl5wEl9/j7DxlQlFWGWxUdgJfQcNtOGMM8FwBllQ==", "32070237-122f-4fcf-a9bb-1d3a16971a01" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2f3baf7f-a5b4-4627-abcb-0e42e2fb33a8",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9db08e85-235e-4f95-a6f7-1f2c058cef55", null, null, "AQAAAAEAACcQAAAAEJXot8/t2aEsGkzMB1eBSKFnfkN+wDFfwz3uEqN7qmldwP0hBUphocvC7w9HaOSumg==", "79eb114a-7a67-452d-8ded-5f4199b15b03" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2f67c183-6ebf-4920-9cca-7d1a7a2b173c",
                columns: new[] { "ConcurrencyStamp", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "45365e9d-f459-4418-9edd-e2b686552f25", "student2", null, null, "AQAAAAEAACcQAAAAEFxix0kXD0TT9Etfn2Fr38oRsECaefnxkM/coGtU6RkT+jCZ70X2Ye2YABYEjOeybA==", "d72c2a02-9376-40c2-bb39-09aefef5b3ec" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3c592e96-f3ad-4e8b-9cbe-afb7ea745362",
                columns: new[] { "ConcurrencyStamp", "FullName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ab5744c4-d712-43c2-b66f-7d0606535c9a", "student3", null, null, "AQAAAAEAACcQAAAAEAY8UGqsv+BsltKAZV97Qnw5x8SBdEJBHze6y906RlyKtBqhmkkPflvi/Uxbc1rXHA==", "f118c5df-6c1e-47fc-b5cc-2b5dce04832f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3dabf300-50ab-438b-baaa-f6890f2b260c",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7c3dd024-55ba-4275-8b9d-0796ea9d28c9", null, null, "AQAAAAEAACcQAAAAEB9+HTSAVUS6FISX50jl6IIi6ajhRbiznPNeej3Zui8QciN+gQHnEcapUF16pQVNyQ==", "1c1a9f91-f17c-4732-84b2-1113ace02000" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "560b9a81-71e6-4987-a6c2-ecf72ecd36b5",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0b7b1fac-24e5-45c4-bfb6-d4c60cc784ea", null, null, "AQAAAAEAACcQAAAAEMiwc2q+OM+1x/agbHqm1nKi/pcH0dQ0hwVjh0SN9tZQFzWty/si9yllZFJq3kQR1w==", "2d2e5526-bc6b-4729-b33a-5b0aea1f24cb" });

            migrationBuilder.UpdateData(
                table: "EventContents",
                keyColumn: "EventContentId",
                keyValue: 10,
                column: "CourseCurrentId",
                value: 2);
        }
    }
}

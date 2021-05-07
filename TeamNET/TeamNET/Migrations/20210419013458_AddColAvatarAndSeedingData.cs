using Microsoft.EntityFrameworkCore.Migrations;

namespace TeamNET.Migrations
{
    public partial class AddColAvatarAndSeedingData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AvatarName",
                table: "AspNetUsers",
                type: "character varying(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "06b12f97-bb16-434a-9982-e3d3dc1c5145",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1bc36d0c-394b-48a4-a59c-b2e63d72ad1a", "AQAAAAEAACcQAAAAEEFw/64Vv/eXtapxSkcIRhhrrxbcY1cFP7SdVYKpWZGsM6RjsxWdaGvnt0B6q7iMrw==", "0c56ef80-b7df-4cac-82c0-a86d11240124" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "16a69b03-3b90-49a2-9cac-4b940c91514c",
                columns: new[] { "AvatarName", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "teacher.png", "61cb6af8-2933-438c-8892-cf67e388240f", "AQAAAAEAACcQAAAAEOy/N9F73EV7m6f89GMYjst1XF+ZD1UjuZVmoIaVFWsL4Y0oEP3u0bPKFUL2czXwTA==", "0e02d225-f5a5-4d91-86c0-ab5a5ec7ee1e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1efe96d9-6618-4269-a6e3-ae1e3d3eecc4",
                columns: new[] { "AvatarName", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "teacher.png", "618f4d9d-f660-4e32-94de-fdb6a9725dce", "AQAAAAEAACcQAAAAEOynqsJVSoGOJtRNZyHjosaFy7y7/+1XeL1IyYZaTFykH2/a0O4BJfBUYn9uXxRTbg==", "24f64573-8a92-4189-b30c-0e3c98c71254" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2115c7e6-9aae-43cb-a406-d504578498ba",
                columns: new[] { "AvatarName", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "doctor.jpg", "b67124ea-fa08-4e39-b6df-1338c5da4b2f", "AQAAAAEAACcQAAAAECla3qbJca/Oyy3LhCvn0bkl7D4UlQaKm4pNRc/8fnWgzfWtq5YhFslH7pkcpjJ2zA==", "82e77d10-907c-44e2-83de-30751cbe70a3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "29a908b8-3ac4-45ea-a8a1-1cf9946079c7",
                columns: new[] { "AvatarName", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "doctor.jpg", "884be8ae-9ddf-44dc-8bcd-855df2b00839", "AQAAAAEAACcQAAAAEN25Y72PK4QxNBXBcAgvwIahTmtNklsrLznB577M+yhfEE7t6L1mI1QNOcB7nSZcLg==", "127b0098-372c-4c78-9e46-b6796461cae9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2f3baf7f-a5b4-4627-abcb-0e42e2fb33a8",
                columns: new[] { "AvatarName", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "student.png", "711e6fb4-a4da-46aa-a478-98878eb8f005", "AQAAAAEAACcQAAAAEG5P0yPIblhNX6b2eyZNbyUBcxvtWFM7e7ZXRi/sbDx6RunzVR0q6EDCYl35NPmVzg==", "3578db57-f17a-411d-aa5d-cb1d400f4003" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2f67c183-6ebf-4920-9cca-7d1a7a2b173c",
                columns: new[] { "AvatarName", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "student.png", "604990df-cd37-4e20-87d4-432b1a893d3e", "AQAAAAEAACcQAAAAEAYG6w8/oTNXENLivWIn5V5ZD+6qyN2qLwxNg/8+2Si7aDPlTHyoMvyXvDNC10DHGA==", "c92906b6-4b9e-450f-a165-7f3bffa9cf9d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3c592e96-f3ad-4e8b-9cbe-afb7ea745362",
                columns: new[] { "AvatarName", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "student.png", "a8c627c5-19d1-424c-8f5e-5be64ba29b83", "AQAAAAEAACcQAAAAEATevlkCJa2tGoITeOmkKFBe1hICSR90OMjVcZ9sTo3ugMa5L7Cz83h18osiZEQ6UQ==", "6089ac6a-76b1-4aaf-b022-4effb10a5a44" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3dabf300-50ab-438b-baaa-f6890f2b260c",
                columns: new[] { "AvatarName", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "guardian.png", "54cb7c5c-012c-4289-8085-2c48dcd113b3", "AQAAAAEAACcQAAAAENK1Xb0u6aQHRSrXaqtl8NnLFU5UIphm2HnBCNZvE6X72en3B3oxeJ8BftjQizpb5A==", "c8ec0ce7-c9e7-46d5-b2f5-db167e4ea6d2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "560b9a81-71e6-4987-a6c2-ecf72ecd36b5",
                columns: new[] { "AvatarName", "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "guardian.png", "a3988807-7363-444d-b37d-b4ea09d2915d", "AQAAAAEAACcQAAAAELjEf4sv/odyjMM6hoX5SRm+o42CWWE8pHmPLarO0EuxwWC8ooffzH37LDgqp643EA==", "adea5e41-a3d7-4fe9-997d-f71d64de3808" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AvatarName",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "06b12f97-bb16-434a-9982-e3d3dc1c5145",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "240cfd15-70e4-4b01-8be1-832935fa5630", "AQAAAAEAACcQAAAAEFl2n0hYUU9zwVoqknTJtuJVhYbe7qAiFoLDxa12kYPnsZHZnGHo46wrGHvt+AxVIw==", "765b4394-758f-419e-ae3d-a2836b0a3fd2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "16a69b03-3b90-49a2-9cac-4b940c91514c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1bc64bcb-d4b6-40e1-9f76-a09699d3d2c5", "AQAAAAEAACcQAAAAEI4nN1yCH7fLZXtOoYz21THAiaSn5IcWl+xTa3D4tqDEn9zPXDLZZMQ+8pz3uMh9iQ==", "e6c6fcec-d401-4534-980e-49e19e8a41e6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1efe96d9-6618-4269-a6e3-ae1e3d3eecc4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6b07a4ed-7f45-4f15-8fc4-5acc5d61667c", "AQAAAAEAACcQAAAAEF9/Ktlhjhrtoqcu412kkGwbJ2SCUstKfA2W+M9/ZCtGltPZLUlXiQB5DjgwhoQUqg==", "9014e5a7-45e4-4467-a545-03b955a85e2b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2115c7e6-9aae-43cb-a406-d504578498ba",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1221abaf-11cf-4ea5-9b68-e9585b03931b", "AQAAAAEAACcQAAAAEOoAR4AWdAdSHZJ6s9AGS6PQOu7VahhHnqjDlq5mnVRFP15JjxmIte1qelh0u9rjOQ==", "0658de8f-5926-4d49-9a55-cfb30174b74b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "29a908b8-3ac4-45ea-a8a1-1cf9946079c7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b8410950-8dc1-455a-bdd1-4f350f3914cc", "AQAAAAEAACcQAAAAEMA05DECUB+Li3EknV0Pq5/KPABdfCv7rhV6j2izpDiCVxvfltrrsFMoKfAj/LrPCA==", "b20b3c8b-664d-45a9-80cd-1a1a7ce119b8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2f3baf7f-a5b4-4627-abcb-0e42e2fb33a8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c0ff8a66-d8a4-4235-a4a2-aa33f68b9065", "AQAAAAEAACcQAAAAEMWxTRMS6r5/lXO4CsdtWZmBFrd1uv2HUryHv8jVZK7/kPOtvnknULNib1ROQaoOaQ==", "2ccff904-0040-4fa9-8433-6b27bcb63bb9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2f67c183-6ebf-4920-9cca-7d1a7a2b173c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f6723390-3401-4667-9f5e-dd08db93a3b9", "AQAAAAEAACcQAAAAEMFV8pbqcutlHLf9/mk9BYecrnICofwqu1yIBOzezE75MOKwkE1vBpcooOsX9DJdDQ==", "28020c02-fe28-4f33-8926-2940385289cd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3c592e96-f3ad-4e8b-9cbe-afb7ea745362",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0b1733f0-c953-426e-b671-13d1b5df81f3", "AQAAAAEAACcQAAAAEDO1dOrfuDD8B0Db/no2W1SMhMcKaXUXOvFiMlXOCzJGMFMjUbL/K7/4FgLxXAMFXg==", "73dc3191-4fbb-412e-9f85-9f3d4b57a4ac" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3dabf300-50ab-438b-baaa-f6890f2b260c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b1830825-b516-482d-a6bb-e5039d28528e", "AQAAAAEAACcQAAAAEJ5UlgaPOt85OZ86dA3yPMMWzOr5fhSxYO+u249gC1+PJK1uNhgUnHJC3KZyoR/cvw==", "5500f392-17a6-47ae-9995-dbd5b14628a4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "560b9a81-71e6-4987-a6c2-ecf72ecd36b5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "12f21638-1d24-4b07-bf22-c57b0803bc5c", "AQAAAAEAACcQAAAAEJ6akjwCg1+ft9xkRd7XpspRivCVd5pckcF02NsUoaZds3sUxnlckE0QlWTD+5r4cA==", "b032cce0-d3f1-4d63-a617-873f44ce9206" });
        }
    }
}

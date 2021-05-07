using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TeamNET.Migrations
{
    public partial class SeedingDatabase_16_04 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Abilities",
                columns: new[] { "AbilityId", "AbilityName", "Color" },
                values: new object[,]
                {
                    { 6, "Khả năng sáng tạo", "#efa101" },
                    { 12, "Khả năng chịu được áp lực", "#7291b6" },
                    { 11, "Có tính kỷ luật", "#a33972" },
                    { 10, "Khả năng nắm bắt tình huống", "#efaac3" },
                    { 9, "Có tính mềm dẻo, linh hoạt", "#2a9034" },
                    { 1, "Tính tự lập", "#3a2d38" },
                    { 2, "Khả năng làm việc", "#1d545b" },
                    { 3, "Khả năng thực hành", "#f4d8cd" },
                    { 4, "Khả năng giải quyết vấn đề", "#f78c3a" },
                    { 5, "Khả năng lập kế hoạch", "#d62f0a" },
                    { 8, "Khả năng thấu hiểu", "#662d9a" },
                    { 7, "Khả năng truyền đạt", "#5db1bf" }
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "291cbc7f-1345-45df-b8c2-96111d13ad60", "7f1afc1e-eb95-4455-b6b9-301e5fc46ac4", "System Admin", "SYSTEM ADMIN" },
                    { "a35c7eb1-a14a-4eed-9ec2-467127acedc1", "cd64acc6-d3ee-42f5-96a1-0518e9e94509", "Guardian", "GUARDIAN" },
                    { "f7e3b187-7743-4c11-a73f-398fe418acd1", "5836f016-3405-4b44-b692-44cf861babb0", "Doctor", "DOCTOR" },
                    { "e346ef58-52dd-485d-92a3-25a64144bdfa", "b5591e23-dda4-4788-a3b6-1fb3b1f07d04", "Teacher", "TEACHER" },
                    { "947b70ee-4b80-4299-a3e4-b03df15501c1", "ead43932-327f-411e-9313-bc399e503d22", "Student", "STUDENT" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CourseCurrentId", "Email", "EmailConfirmed", "FullName", "GuardianId", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "StudentCode", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "560b9a81-71e6-4987-a6c2-ecf72ecd36b5", 0, "12f21638-1d24-4b07-bf22-c57b0803bc5c", 0, "guardian2@gmail.com", true, "Guardian2", null, false, null, "GUARDIAN2@GMAIL.COM", "GUARDIAN2@GMAIL.COM", "AQAAAAEAACcQAAAAEJ6akjwCg1+ft9xkRd7XpspRivCVd5pckcF02NsUoaZds3sUxnlckE0QlWTD+5r4cA==", null, false, "b032cce0-d3f1-4d63-a617-873f44ce9206", null, false, "guardian2@gmail.com" },
                    { "3dabf300-50ab-438b-baaa-f6890f2b260c", 0, "b1830825-b516-482d-a6bb-e5039d28528e", 0, "guardian1@gmail.com", true, "Guardian1", null, false, null, "GUARDIAN1@GMAIL.COM", "GUARDIAN1@GMAIL.COM", "AQAAAAEAACcQAAAAEJ5UlgaPOt85OZ86dA3yPMMWzOr5fhSxYO+u249gC1+PJK1uNhgUnHJC3KZyoR/cvw==", null, false, "5500f392-17a6-47ae-9995-dbd5b14628a4", null, false, "guardian1@gmail.com" },
                    { "3c592e96-f3ad-4e8b-9cbe-afb7ea745362", 0, "0b1733f0-c953-426e-b671-13d1b5df81f3", 3, "student3@gmail.com", true, "Student3", "3dabf300-50ab-438b-baaa-f6890f2b260c", false, null, "STUDENT3@GMAIL.COM", "STUDENT3@GMAIL.COM", "AQAAAAEAACcQAAAAEDO1dOrfuDD8B0Db/no2W1SMhMcKaXUXOvFiMlXOCzJGMFMjUbL/K7/4FgLxXAMFXg==", null, false, "73dc3191-4fbb-412e-9f85-9f3d4b57a4ac", "ST00003", false, "student3@gmail.com" },
                    { "2f3baf7f-a5b4-4627-abcb-0e42e2fb33a8", 0, "c0ff8a66-d8a4-4235-a4a2-aa33f68b9065", 2, "student1@gmail.com", true, "Student1", "3dabf300-50ab-438b-baaa-f6890f2b260c", false, null, "STUDENT1@GMAIL.COM", "STUDENT1@GMAIL.COM", "AQAAAAEAACcQAAAAEMWxTRMS6r5/lXO4CsdtWZmBFrd1uv2HUryHv8jVZK7/kPOtvnknULNib1ROQaoOaQ==", null, false, "2ccff904-0040-4fa9-8433-6b27bcb63bb9", "ST00001", false, "student1@gmail.com" },
                    { "2f67c183-6ebf-4920-9cca-7d1a7a2b173c", 0, "f6723390-3401-4667-9f5e-dd08db93a3b9", 2, "student2@gmail.com", true, "Student2", "560b9a81-71e6-4987-a6c2-ecf72ecd36b5", false, null, "STUDENT2@GMAIL.COM", "STUDENT2@GMAIL.COM", "AQAAAAEAACcQAAAAEMFV8pbqcutlHLf9/mk9BYecrnICofwqu1yIBOzezE75MOKwkE1vBpcooOsX9DJdDQ==", null, false, "28020c02-fe28-4f33-8926-2940385289cd", "ST00002", false, "student2@gmail.com" },
                    { "2115c7e6-9aae-43cb-a406-d504578498ba", 0, "1221abaf-11cf-4ea5-9b68-e9585b03931b", 2, "doctor1@gmail.com", true, "Doctor1", null, false, null, "DOCTOR1@GMAIL.COM", "DOCTOR1@GMAIL.COM", "AQAAAAEAACcQAAAAEOoAR4AWdAdSHZJ6s9AGS6PQOu7VahhHnqjDlq5mnVRFP15JjxmIte1qelh0u9rjOQ==", null, false, "0658de8f-5926-4d49-9a55-cfb30174b74b", null, false, "doctor1@gmail.com" },
                    { "1efe96d9-6618-4269-a6e3-ae1e3d3eecc4", 0, "6b07a4ed-7f45-4f15-8fc4-5acc5d61667c", 3, "teacher2@gmail.com", true, "Teacher2", null, false, null, "TEACHER2@GMAIL.COM", "TEACHER2@GMAIL.COM", "AQAAAAEAACcQAAAAEF9/Ktlhjhrtoqcu412kkGwbJ2SCUstKfA2W+M9/ZCtGltPZLUlXiQB5DjgwhoQUqg==", null, false, "9014e5a7-45e4-4467-a545-03b955a85e2b", null, false, "teacher2@gmail.com" },
                    { "16a69b03-3b90-49a2-9cac-4b940c91514c", 0, "1bc64bcb-d4b6-40e1-9f76-a09699d3d2c5", 2, "teacher1@gmail.com", true, "Teacher1", null, false, null, "TEACHER1@GMAIL.COM", "TEACHER1@GMAIL.COM", "AQAAAAEAACcQAAAAEI4nN1yCH7fLZXtOoYz21THAiaSn5IcWl+xTa3D4tqDEn9zPXDLZZMQ+8pz3uMh9iQ==", null, false, "e6c6fcec-d401-4534-980e-49e19e8a41e6", null, false, "teacher1@gmail.com" },
                    { "06b12f97-bb16-434a-9982-e3d3dc1c5145", 0, "240cfd15-70e4-4b01-8be1-832935fa5630", 0, "superadmin@gmail.com", true, "TeamNET", null, false, null, "SUPERADMIN@GMAIL.COM", "SUPERADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEFl2n0hYUU9zwVoqknTJtuJVhYbe7qAiFoLDxa12kYPnsZHZnGHo46wrGHvt+AxVIw==", null, false, "765b4394-758f-419e-ae3d-a2836b0a3fd2", null, false, "superadmin@gmail.com" },
                    { "29a908b8-3ac4-45ea-a8a1-1cf9946079c7", 0, "b8410950-8dc1-455a-bdd1-4f350f3914cc", 3, "doctor2@gmail.com", true, "Doctor2", null, false, null, "DOCTOR2@GMAIL.COM", "DOCTOR2@GMAIL.COM", "AQAAAAEAACcQAAAAEMA05DECUB+Li3EknV0Pq5/KPABdfCv7rhV6j2izpDiCVxvfltrrsFMoKfAj/LrPCA==", null, false, "b20b3c8b-664d-45a9-80cd-1a1a7ce119b8", null, false, "doctor2@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "CourseName" },
                values: new object[,]
                {
                    { 12, "Class 12" },
                    { 11, "Class 11" },
                    { 10, "Class 10" },
                    { 9, "Class 9" },
                    { 7, "Class 7" },
                    { 8, "Class 8" },
                    { 5, "Class 5" },
                    { 4, "Class 4" },
                    { 3, "Class 3" },
                    { 2, "Class 2" },
                    { 1, "Class 1" },
                    { 6, "Class 6" }
                });

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "EventId", "EventName", "Icon" },
                values: new object[,]
                {
                    { 1, "Bóng đá", "fa fa-futbol-o" },
                    { 2, "Hát", "las la-microphone-alt" },
                    { 3, "Bóng chuyền", "las la-volleyball-ball" },
                    { 4, "Bóng rổ", "las la-basketball-ball" },
                    { 5, "Sách", "las la-book-reader" }
                });

            migrationBuilder.InsertData(
                table: "Wikis",
                columns: new[] { "StatusId", "TableId", "IsDeleted", "StatusName", "TableName" },
                values: new object[,]
                {
                    { 3, 1, false, "Hoàn thành", "EventContent" },
                    { 1, 1, false, "Đang xác nhận", "EventContent" },
                    { 2, 1, false, "Xác nhận", "EventContent" },
                    { 4, 1, false, "Đã xóa", "EventContent" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "291cbc7f-1345-45df-b8c2-96111d13ad60", "06b12f97-bb16-434a-9982-e3d3dc1c5145" },
                    { "e346ef58-52dd-485d-92a3-25a64144bdfa", "16a69b03-3b90-49a2-9cac-4b940c91514c" },
                    { "e346ef58-52dd-485d-92a3-25a64144bdfa", "1efe96d9-6618-4269-a6e3-ae1e3d3eecc4" },
                    { "f7e3b187-7743-4c11-a73f-398fe418acd1", "2115c7e6-9aae-43cb-a406-d504578498ba" },
                    { "f7e3b187-7743-4c11-a73f-398fe418acd1", "29a908b8-3ac4-45ea-a8a1-1cf9946079c7" },
                    { "947b70ee-4b80-4299-a3e4-b03df15501c1", "2f3baf7f-a5b4-4627-abcb-0e42e2fb33a8" },
                    { "947b70ee-4b80-4299-a3e4-b03df15501c1", "2f67c183-6ebf-4920-9cca-7d1a7a2b173c" },
                    { "947b70ee-4b80-4299-a3e4-b03df15501c1", "3c592e96-f3ad-4e8b-9cbe-afb7ea745362" },
                    { "a35c7eb1-a14a-4eed-9ec2-467127acedc1", "3dabf300-50ab-438b-baaa-f6890f2b260c" },
                    { "a35c7eb1-a14a-4eed-9ec2-467127acedc1", "560b9a81-71e6-4987-a6c2-ecf72ecd36b5" }
                });

            migrationBuilder.InsertData(
                table: "UserCourseDetails",
                columns: new[] { "CourseCurrentId", "CourseId", "DoctorId", "TeacherId" },
                values: new object[,]
                {
                    { 1, 1, "2115c7e6-9aae-43cb-a406-d504578498ba", "16a69b03-3b90-49a2-9cac-4b940c91514c" },
                    { 3, 1, "29a908b8-3ac4-45ea-a8a1-1cf9946079c7", "1efe96d9-6618-4269-a6e3-ae1e3d3eecc4" },
                    { 2, 2, "2115c7e6-9aae-43cb-a406-d504578498ba", "16a69b03-3b90-49a2-9cac-4b940c91514c" }
                });

            migrationBuilder.InsertData(
                table: "EventContents",
                columns: new[] { "EventContentId", "ActionAbility", "CommunityAbility", "CourseCurrentId", "DemonstratedAbility", "EventId", "SelfDevelopment", "StatusId", "StudentId", "ThinkingAbility" },
                values: new object[,]
                {
                    { 1, "Answer 12", "Answer 11", 1, "Answer 13", 1, "Answer 14", 3, "2f3baf7f-a5b4-4627-abcb-0e42e2fb33a8", "Answer 15" },
                    { 2, "Answer 22", "Answer 21", 1, "Answer 23", 3, "Answer 24", 3, "2f67c183-6ebf-4920-9cca-7d1a7a2b173c", "Answer 25" },
                    { 3, "Answer 112", "Answer 111", 1, "Answer 113", 4, "Answer 114", 3, "2f3baf7f-a5b4-4627-abcb-0e42e2fb33a8", "Answer 115" },
                    { 4, "Answer 1112", "Answer 1111", 1, "Answer 1113", 4, "Answer 1114", 3, "2f3baf7f-a5b4-4627-abcb-0e42e2fb33a8", "Answer 1115" },
                    { 5, "Answer 11112", "Answer 11111", 1, "Answer 11113", 5, "Answer 11114", 3, "2f3baf7f-a5b4-4627-abcb-0e42e2fb33a8", "Answer 11115" },
                    { 6, "Answer 222", "Answer 221", 1, "Answer 223", 2, "Answer 224", 3, "2f67c183-6ebf-4920-9cca-7d1a7a2b173c", "Answer 225" },
                    { 10, "Answer 32", "Answer 31", 3, "Answer 33", 3, "Answer 34", 1, "3c592e96-f3ad-4e8b-9cbe-afb7ea745362", "Answer 35" },
                    { 7, "Answer 111112", "Answer 111111", 2, "Answer 111113", 2, "Answer 111114", 1, "2f3baf7f-a5b4-4627-abcb-0e42e2fb33a8", "Answer 111115" },
                    { 8, "Answer 1111112", "Answer 1111111", 2, "Answer 1111113", 2, "Answer 1111114", 1, "2f3baf7f-a5b4-4627-abcb-0e42e2fb33a8", "Answer 1111115" },
                    { 9, "Answer 2222", "Answer 2221", 2, "Answer 2223", 5, "Answer 2224", 1, "2f67c183-6ebf-4920-9cca-7d1a7a2b173c", "Answer 2225" }
                });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "CommentId", "EventContentId", "RealTime", "Text", "UserId" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2020, 2, 12, 13, 20, 50, 0, DateTimeKind.Unspecified), "StudentComentEvent 1", "2f3baf7f-a5b4-4627-abcb-0e42e2fb33a8" },
                    { 25, 7, new DateTime(2021, 1, 25, 14, 15, 25, 0, DateTimeKind.Unspecified), "StudentComentEvent 7", "2f3baf7f-a5b4-4627-abcb-0e42e2fb33a8" },
                    { 16, 4, new DateTime(2020, 6, 25, 19, 5, 25, 0, DateTimeKind.Unspecified), "GuardianComentEvent 4", "3dabf300-50ab-438b-baaa-f6890f2b260c" },
                    { 32, 8, new DateTime(2020, 2, 2, 19, 5, 25, 0, DateTimeKind.Unspecified), "GuardianComentEvent 8", "3dabf300-50ab-438b-baaa-f6890f2b260c" },
                    { 31, 8, new DateTime(2021, 2, 2, 17, 30, 40, 0, DateTimeKind.Unspecified), "#Khả năng chịu được áp lực - DoctorComentEvent 8", "2115c7e6-9aae-43cb-a406-d504578498ba" },
                    { 30, 8, new DateTime(2021, 2, 2, 16, 20, 50, 0, DateTimeKind.Unspecified), "TeacherComentEvent 8", "16a69b03-3b90-49a2-9cac-4b940c91514c" },
                    { 29, 8, new DateTime(2021, 2, 2, 14, 15, 25, 0, DateTimeKind.Unspecified), "StudentComentEvent 8", "2f3baf7f-a5b4-4627-abcb-0e42e2fb33a8" },
                    { 17, 5, new DateTime(2020, 7, 12, 14, 15, 25, 0, DateTimeKind.Unspecified), "StudentComentEvent 5", "2f3baf7f-a5b4-4627-abcb-0e42e2fb33a8" },
                    { 18, 5, new DateTime(2020, 7, 12, 16, 20, 50, 0, DateTimeKind.Unspecified), "TeacherComentEvent 5", "16a69b03-3b90-49a2-9cac-4b940c91514c" },
                    { 19, 5, new DateTime(2020, 7, 12, 17, 30, 40, 0, DateTimeKind.Unspecified), "#Khả năng lập kế hoạch - DoctorComentEvent 5", "2115c7e6-9aae-43cb-a406-d504578498ba" },
                    { 20, 5, new DateTime(2020, 7, 12, 19, 5, 25, 0, DateTimeKind.Unspecified), "GuardianComentEvent 5", "3dabf300-50ab-438b-baaa-f6890f2b260c" },
                    { 21, 6, new DateTime(2020, 7, 20, 14, 15, 25, 0, DateTimeKind.Unspecified), "StudentComentEvent 6", "2f67c183-6ebf-4920-9cca-7d1a7a2b173c" },
                    { 22, 6, new DateTime(2020, 7, 20, 16, 20, 50, 0, DateTimeKind.Unspecified), "TeacherComentEvent 6", "16a69b03-3b90-49a2-9cac-4b940c91514c" },
                    { 23, 6, new DateTime(2020, 7, 20, 17, 30, 40, 0, DateTimeKind.Unspecified), "#Có tính mềm dẻo, linh hoạt - DoctorComentEvent 6", "2115c7e6-9aae-43cb-a406-d504578498ba" },
                    { 24, 6, new DateTime(2020, 7, 20, 19, 5, 25, 0, DateTimeKind.Unspecified), "GuardianComentEvent 6", "560b9a81-71e6-4987-a6c2-ecf72ecd36b5" },
                    { 28, 7, new DateTime(2020, 7, 25, 19, 5, 25, 0, DateTimeKind.Unspecified), "GuardianComentEvent 7", "3dabf300-50ab-438b-baaa-f6890f2b260c" },
                    { 27, 7, new DateTime(2021, 1, 25, 17, 30, 40, 0, DateTimeKind.Unspecified), "#Khả năng thực hành - Có tính mềm dẻo, linh hoạt - DoctorComentEvent 7", "2115c7e6-9aae-43cb-a406-d504578498ba" },
                    { 26, 7, new DateTime(2021, 1, 25, 16, 20, 50, 0, DateTimeKind.Unspecified), "TeacherComentEvent 7", "16a69b03-3b90-49a2-9cac-4b940c91514c" },
                    { 37, 10, new DateTime(2021, 3, 15, 14, 15, 25, 0, DateTimeKind.Unspecified), "StudentComentEvent 10", "3c592e96-f3ad-4e8b-9cbe-afb7ea745362" },
                    { 38, 10, new DateTime(2021, 3, 15, 16, 20, 50, 0, DateTimeKind.Unspecified), "TeacherComentEvent 10", "1efe96d9-6618-4269-a6e3-ae1e3d3eecc4" },
                    { 39, 10, new DateTime(2021, 3, 15, 17, 30, 40, 0, DateTimeKind.Unspecified), "#Khả năng giải quyết vấn đề #Khả năng sáng tạo - DoctorComentEvent 10", "29a908b8-3ac4-45ea-a8a1-1cf9946079c7" },
                    { 40, 10, new DateTime(2020, 3, 15, 19, 5, 25, 0, DateTimeKind.Unspecified), "GuardianComentEvent 10", "3dabf300-50ab-438b-baaa-f6890f2b260c" },
                    { 14, 4, new DateTime(2020, 6, 25, 16, 20, 50, 0, DateTimeKind.Unspecified), "TeacherComentEvent 4", "16a69b03-3b90-49a2-9cac-4b940c91514c" },
                    { 13, 4, new DateTime(2020, 6, 25, 14, 15, 25, 0, DateTimeKind.Unspecified), "StudentComentEvent 4", "2f3baf7f-a5b4-4627-abcb-0e42e2fb33a8" },
                    { 15, 4, new DateTime(2020, 6, 25, 17, 30, 40, 0, DateTimeKind.Unspecified), "#Khả năng làm việc - DoctorComentEvent 4", "2115c7e6-9aae-43cb-a406-d504578498ba" },
                    { 8, 2, new DateTime(2020, 2, 15, 19, 5, 25, 0, DateTimeKind.Unspecified), "GuardianComentEvent 2", "560b9a81-71e6-4987-a6c2-ecf72ecd36b5" },
                    { 6, 2, new DateTime(2020, 2, 15, 16, 20, 50, 0, DateTimeKind.Unspecified), "TeacherComentEvent 2", "16a69b03-3b90-49a2-9cac-4b940c91514c" },
                    { 7, 2, new DateTime(2020, 2, 15, 17, 30, 40, 0, DateTimeKind.Unspecified), "#Khả năng làm việc - DoctorComentEvent 2", "2115c7e6-9aae-43cb-a406-d504578498ba" },
                    { 5, 2, new DateTime(2020, 2, 15, 14, 15, 25, 0, DateTimeKind.Unspecified), "StudentComentEvent 2", "2f67c183-6ebf-4920-9cca-7d1a7a2b173c" },
                    { 35, 9, new DateTime(2021, 2, 10, 17, 30, 40, 0, DateTimeKind.Unspecified), "#Tính tự lập - DoctorComentEvent 9", "2115c7e6-9aae-43cb-a406-d504578498ba" },
                    { 34, 9, new DateTime(2021, 2, 10, 16, 20, 50, 0, DateTimeKind.Unspecified), "TeacherComentEvent 9", "16a69b03-3b90-49a2-9cac-4b940c91514c" },
                    { 33, 9, new DateTime(2021, 2, 10, 14, 15, 25, 0, DateTimeKind.Unspecified), "StudentComentEvent 9", "2f67c183-6ebf-4920-9cca-7d1a7a2b173c" },
                    { 4, 1, new DateTime(2020, 2, 12, 20, 15, 55, 0, DateTimeKind.Unspecified), "GuardianComentEvent 1", "3dabf300-50ab-438b-baaa-f6890f2b260c" },
                    { 2, 1, new DateTime(2020, 2, 12, 15, 10, 20, 0, DateTimeKind.Unspecified), "TeacherComentEvent 1", "16a69b03-3b90-49a2-9cac-4b940c91514c" },
                    { 9, 3, new DateTime(2020, 5, 20, 14, 15, 25, 0, DateTimeKind.Unspecified), "StudentComentEvent 3", "2f3baf7f-a5b4-4627-abcb-0e42e2fb33a8" },
                    { 10, 3, new DateTime(2020, 5, 20, 16, 20, 50, 0, DateTimeKind.Unspecified), "TeacherComentEvent 3", "16a69b03-3b90-49a2-9cac-4b940c91514c" },
                    { 11, 3, new DateTime(2020, 5, 20, 17, 30, 40, 0, DateTimeKind.Unspecified), "#Khả năng làm việc - DoctorComentEvent 3", "2115c7e6-9aae-43cb-a406-d504578498ba" },
                    { 12, 3, new DateTime(2020, 5, 20, 19, 5, 25, 0, DateTimeKind.Unspecified), "GuardianComentEvent 3", "3dabf300-50ab-438b-baaa-f6890f2b260c" },
                    { 36, 9, new DateTime(2021, 2, 10, 19, 5, 25, 0, DateTimeKind.Unspecified), "GuardianComentEvent 9", "560b9a81-71e6-4987-a6c2-ecf72ecd36b5" },
                    { 3, 1, new DateTime(2020, 2, 12, 17, 30, 40, 0, DateTimeKind.Unspecified), "#Tính tự lập #Khả năng lập kế hoạch #Có tính kỷ luật - DoctorComentEvent 1", "2115c7e6-9aae-43cb-a406-d504578498ba" }
                });

            migrationBuilder.InsertData(
                table: "EventContentAbilities",
                columns: new[] { "AbilityId", "EventContentId" },
                values: new object[,]
                {
                    { 1, 9 },
                    { 1, 1 },
                    { 5, 1 },
                    { 9, 6 },
                    { 11, 1 },
                    { 5, 5 },
                    { 3, 7 },
                    { 2, 2 },
                    { 2, 4 },
                    { 12, 8 },
                    { 4, 10 },
                    { 6, 10 },
                    { 2, 3 }
                });

            migrationBuilder.InsertData(
                table: "NotificationEventContents",
                columns: new[] { "NotificationEventContentId", "EventContentId", "Notification", "UserId" },
                values: new object[,]
                {
                    { 31, 8, 0, "2115c7e6-9aae-43cb-a406-d504578498ba" },
                    { 27, 7, 0, "2115c7e6-9aae-43cb-a406-d504578498ba" },
                    { 33, 9, 1, "2f67c183-6ebf-4920-9cca-7d1a7a2b173c" },
                    { 25, 7, 0, "2f3baf7f-a5b4-4627-abcb-0e42e2fb33a8" },
                    { 26, 7, 0, "16a69b03-3b90-49a2-9cac-4b940c91514c" },
                    { 28, 7, 0, "3dabf300-50ab-438b-baaa-f6890f2b260c" },
                    { 32, 8, 3, "3dabf300-50ab-438b-baaa-f6890f2b260c" },
                    { 29, 8, 0, "2f3baf7f-a5b4-4627-abcb-0e42e2fb33a8" },
                    { 30, 8, 2, "16a69b03-3b90-49a2-9cac-4b940c91514c" },
                    { 34, 9, 2, "16a69b03-3b90-49a2-9cac-4b940c91514c" },
                    { 40, 10, 2, "3dabf300-50ab-438b-baaa-f6890f2b260c" },
                    { 20, 5, 0, "3dabf300-50ab-438b-baaa-f6890f2b260c" },
                    { 38, 10, 2, "1efe96d9-6618-4269-a6e3-ae1e3d3eecc4" },
                    { 1, 1, 0, "2f3baf7f-a5b4-4627-abcb-0e42e2fb33a8" },
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
                    { 12, 3, 0, "3dabf300-50ab-438b-baaa-f6890f2b260c" },
                    { 13, 4, 0, "2f3baf7f-a5b4-4627-abcb-0e42e2fb33a8" },
                    { 14, 4, 0, "16a69b03-3b90-49a2-9cac-4b940c91514c" },
                    { 15, 4, 0, "2115c7e6-9aae-43cb-a406-d504578498ba" },
                    { 16, 4, 0, "3dabf300-50ab-438b-baaa-f6890f2b260c" },
                    { 17, 5, 0, "2f3baf7f-a5b4-4627-abcb-0e42e2fb33a8" },
                    { 18, 5, 0, "16a69b03-3b90-49a2-9cac-4b940c91514c" },
                    { 19, 5, 0, "2115c7e6-9aae-43cb-a406-d504578498ba" },
                    { 35, 9, 1, "2115c7e6-9aae-43cb-a406-d504578498ba" },
                    { 21, 6, 0, "2f67c183-6ebf-4920-9cca-7d1a7a2b173c" },
                    { 22, 6, 0, "16a69b03-3b90-49a2-9cac-4b940c91514c" },
                    { 23, 6, 0, "2115c7e6-9aae-43cb-a406-d504578498ba" },
                    { 24, 6, 0, "560b9a81-71e6-4987-a6c2-ecf72ecd36b5" },
                    { 37, 10, 3, "3c592e96-f3ad-4e8b-9cbe-afb7ea745362" },
                    { 39, 10, 0, "29a908b8-3ac4-45ea-a8a1-1cf9946079c7" },
                    { 36, 9, 0, "560b9a81-71e6-4987-a6c2-ecf72ecd36b5" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Abilities",
                keyColumn: "AbilityId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Abilities",
                keyColumn: "AbilityId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Abilities",
                keyColumn: "AbilityId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "291cbc7f-1345-45df-b8c2-96111d13ad60", "06b12f97-bb16-434a-9982-e3d3dc1c5145" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "e346ef58-52dd-485d-92a3-25a64144bdfa", "16a69b03-3b90-49a2-9cac-4b940c91514c" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "e346ef58-52dd-485d-92a3-25a64144bdfa", "1efe96d9-6618-4269-a6e3-ae1e3d3eecc4" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "f7e3b187-7743-4c11-a73f-398fe418acd1", "2115c7e6-9aae-43cb-a406-d504578498ba" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "f7e3b187-7743-4c11-a73f-398fe418acd1", "29a908b8-3ac4-45ea-a8a1-1cf9946079c7" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "947b70ee-4b80-4299-a3e4-b03df15501c1", "2f3baf7f-a5b4-4627-abcb-0e42e2fb33a8" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "947b70ee-4b80-4299-a3e4-b03df15501c1", "2f67c183-6ebf-4920-9cca-7d1a7a2b173c" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "947b70ee-4b80-4299-a3e4-b03df15501c1", "3c592e96-f3ad-4e8b-9cbe-afb7ea745362" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "a35c7eb1-a14a-4eed-9ec2-467127acedc1", "3dabf300-50ab-438b-baaa-f6890f2b260c" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "a35c7eb1-a14a-4eed-9ec2-467127acedc1", "560b9a81-71e6-4987-a6c2-ecf72ecd36b5" });

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "EventContentAbilities",
                keyColumns: new[] { "AbilityId", "EventContentId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "EventContentAbilities",
                keyColumns: new[] { "AbilityId", "EventContentId" },
                keyValues: new object[] { 5, 1 });

            migrationBuilder.DeleteData(
                table: "EventContentAbilities",
                keyColumns: new[] { "AbilityId", "EventContentId" },
                keyValues: new object[] { 11, 1 });

            migrationBuilder.DeleteData(
                table: "EventContentAbilities",
                keyColumns: new[] { "AbilityId", "EventContentId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "EventContentAbilities",
                keyColumns: new[] { "AbilityId", "EventContentId" },
                keyValues: new object[] { 2, 3 });

            migrationBuilder.DeleteData(
                table: "EventContentAbilities",
                keyColumns: new[] { "AbilityId", "EventContentId" },
                keyValues: new object[] { 2, 4 });

            migrationBuilder.DeleteData(
                table: "EventContentAbilities",
                keyColumns: new[] { "AbilityId", "EventContentId" },
                keyValues: new object[] { 5, 5 });

            migrationBuilder.DeleteData(
                table: "EventContentAbilities",
                keyColumns: new[] { "AbilityId", "EventContentId" },
                keyValues: new object[] { 9, 6 });

            migrationBuilder.DeleteData(
                table: "EventContentAbilities",
                keyColumns: new[] { "AbilityId", "EventContentId" },
                keyValues: new object[] { 3, 7 });

            migrationBuilder.DeleteData(
                table: "EventContentAbilities",
                keyColumns: new[] { "AbilityId", "EventContentId" },
                keyValues: new object[] { 12, 8 });

            migrationBuilder.DeleteData(
                table: "EventContentAbilities",
                keyColumns: new[] { "AbilityId", "EventContentId" },
                keyValues: new object[] { 1, 9 });

            migrationBuilder.DeleteData(
                table: "EventContentAbilities",
                keyColumns: new[] { "AbilityId", "EventContentId" },
                keyValues: new object[] { 4, 10 });

            migrationBuilder.DeleteData(
                table: "EventContentAbilities",
                keyColumns: new[] { "AbilityId", "EventContentId" },
                keyValues: new object[] { 6, 10 });

            migrationBuilder.DeleteData(
                table: "NotificationEventContents",
                keyColumn: "NotificationEventContentId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "NotificationEventContents",
                keyColumn: "NotificationEventContentId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "NotificationEventContents",
                keyColumn: "NotificationEventContentId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "NotificationEventContents",
                keyColumn: "NotificationEventContentId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "NotificationEventContents",
                keyColumn: "NotificationEventContentId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "NotificationEventContents",
                keyColumn: "NotificationEventContentId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "NotificationEventContents",
                keyColumn: "NotificationEventContentId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "NotificationEventContents",
                keyColumn: "NotificationEventContentId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "NotificationEventContents",
                keyColumn: "NotificationEventContentId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "NotificationEventContents",
                keyColumn: "NotificationEventContentId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "NotificationEventContents",
                keyColumn: "NotificationEventContentId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "NotificationEventContents",
                keyColumn: "NotificationEventContentId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "NotificationEventContents",
                keyColumn: "NotificationEventContentId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "NotificationEventContents",
                keyColumn: "NotificationEventContentId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "NotificationEventContents",
                keyColumn: "NotificationEventContentId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "NotificationEventContents",
                keyColumn: "NotificationEventContentId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "NotificationEventContents",
                keyColumn: "NotificationEventContentId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "NotificationEventContents",
                keyColumn: "NotificationEventContentId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "NotificationEventContents",
                keyColumn: "NotificationEventContentId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "NotificationEventContents",
                keyColumn: "NotificationEventContentId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "NotificationEventContents",
                keyColumn: "NotificationEventContentId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "NotificationEventContents",
                keyColumn: "NotificationEventContentId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "NotificationEventContents",
                keyColumn: "NotificationEventContentId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "NotificationEventContents",
                keyColumn: "NotificationEventContentId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "NotificationEventContents",
                keyColumn: "NotificationEventContentId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "NotificationEventContents",
                keyColumn: "NotificationEventContentId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "NotificationEventContents",
                keyColumn: "NotificationEventContentId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "NotificationEventContents",
                keyColumn: "NotificationEventContentId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "NotificationEventContents",
                keyColumn: "NotificationEventContentId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "NotificationEventContents",
                keyColumn: "NotificationEventContentId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "NotificationEventContents",
                keyColumn: "NotificationEventContentId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "NotificationEventContents",
                keyColumn: "NotificationEventContentId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "NotificationEventContents",
                keyColumn: "NotificationEventContentId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "NotificationEventContents",
                keyColumn: "NotificationEventContentId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "NotificationEventContents",
                keyColumn: "NotificationEventContentId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "NotificationEventContents",
                keyColumn: "NotificationEventContentId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "NotificationEventContents",
                keyColumn: "NotificationEventContentId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "NotificationEventContents",
                keyColumn: "NotificationEventContentId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "NotificationEventContents",
                keyColumn: "NotificationEventContentId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "NotificationEventContents",
                keyColumn: "NotificationEventContentId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Wikis",
                keyColumns: new[] { "StatusId", "TableId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "Wikis",
                keyColumns: new[] { "StatusId", "TableId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "Wikis",
                keyColumns: new[] { "StatusId", "TableId" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "Wikis",
                keyColumns: new[] { "StatusId", "TableId" },
                keyValues: new object[] { 4, 1 });

            migrationBuilder.DeleteData(
                table: "Abilities",
                keyColumn: "AbilityId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Abilities",
                keyColumn: "AbilityId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Abilities",
                keyColumn: "AbilityId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Abilities",
                keyColumn: "AbilityId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Abilities",
                keyColumn: "AbilityId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Abilities",
                keyColumn: "AbilityId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Abilities",
                keyColumn: "AbilityId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Abilities",
                keyColumn: "AbilityId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Abilities",
                keyColumn: "AbilityId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "291cbc7f-1345-45df-b8c2-96111d13ad60");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "947b70ee-4b80-4299-a3e4-b03df15501c1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a35c7eb1-a14a-4eed-9ec2-467127acedc1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e346ef58-52dd-485d-92a3-25a64144bdfa");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f7e3b187-7743-4c11-a73f-398fe418acd1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "06b12f97-bb16-434a-9982-e3d3dc1c5145");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3dabf300-50ab-438b-baaa-f6890f2b260c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "560b9a81-71e6-4987-a6c2-ecf72ecd36b5");

            migrationBuilder.DeleteData(
                table: "EventContents",
                keyColumn: "EventContentId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "EventContents",
                keyColumn: "EventContentId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "EventContents",
                keyColumn: "EventContentId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "EventContents",
                keyColumn: "EventContentId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "EventContents",
                keyColumn: "EventContentId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "EventContents",
                keyColumn: "EventContentId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "EventContents",
                keyColumn: "EventContentId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "EventContents",
                keyColumn: "EventContentId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "EventContents",
                keyColumn: "EventContentId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "EventContents",
                keyColumn: "EventContentId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2f3baf7f-a5b4-4627-abcb-0e42e2fb33a8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2f67c183-6ebf-4920-9cca-7d1a7a2b173c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3c592e96-f3ad-4e8b-9cbe-afb7ea745362");

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "EventId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "UserCourseDetails",
                keyColumn: "CourseCurrentId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "UserCourseDetails",
                keyColumn: "CourseCurrentId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "UserCourseDetails",
                keyColumn: "CourseCurrentId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "16a69b03-3b90-49a2-9cac-4b940c91514c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1efe96d9-6618-4269-a6e3-ae1e3d3eecc4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2115c7e6-9aae-43cb-a406-d504578498ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "29a908b8-3ac4-45ea-a8a1-1cf9946079c7");

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "CourseId",
                keyValue: 2);
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace TeamNET.Migrations
{
    public partial class CreateAllTableInDatabase_16_04 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comment_AspNetUsers_UserId",
                table: "Comment");

            migrationBuilder.DropForeignKey(
                name: "FK_Comment_EventContent_EventContentId",
                table: "Comment");

            migrationBuilder.DropForeignKey(
                name: "FK_EventContent_AspNetUsers_ApplicationUserId",
                table: "EventContent");

            migrationBuilder.DropForeignKey(
                name: "FK_EventContent_Event_EventId",
                table: "EventContent");

            migrationBuilder.DropForeignKey(
                name: "FK_EventContent_UserCourseDetail_CourseCurrentId",
                table: "EventContent");

            migrationBuilder.DropForeignKey(
                name: "FK_NotificationEventContent_AspNetUsers_UserId",
                table: "NotificationEventContent");

            migrationBuilder.DropForeignKey(
                name: "FK_NotificationEventContent_EventContent_EventContentId",
                table: "NotificationEventContent");

            migrationBuilder.DropForeignKey(
                name: "FK_UserCourseDetail_AspNetUsers_DoctorId",
                table: "UserCourseDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_UserCourseDetail_AspNetUsers_TeacherId",
                table: "UserCourseDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_UserCourseDetail_Course_CourseId",
                table: "UserCourseDetail");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserCourseDetail",
                table: "UserCourseDetail");

            migrationBuilder.DropPrimaryKey(
                name: "PK_NotificationEventContent",
                table: "NotificationEventContent");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EventContent",
                table: "EventContent");

            migrationBuilder.DropIndex(
                name: "IX_EventContent_ApplicationUserId",
                table: "EventContent");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Event",
                table: "Event");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Course",
                table: "Course");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Comment",
                table: "Comment");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "EventContent");

            migrationBuilder.RenameTable(
                name: "UserCourseDetail",
                newName: "UserCourseDetails");

            migrationBuilder.RenameTable(
                name: "NotificationEventContent",
                newName: "NotificationEventContents");

            migrationBuilder.RenameTable(
                name: "EventContent",
                newName: "EventContents");

            migrationBuilder.RenameTable(
                name: "Event",
                newName: "Events");

            migrationBuilder.RenameTable(
                name: "Course",
                newName: "Courses");

            migrationBuilder.RenameTable(
                name: "Comment",
                newName: "Comments");

            migrationBuilder.RenameIndex(
                name: "IX_UserCourseDetail_TeacherId",
                table: "UserCourseDetails",
                newName: "IX_UserCourseDetails_TeacherId");

            migrationBuilder.RenameIndex(
                name: "IX_UserCourseDetail_DoctorId",
                table: "UserCourseDetails",
                newName: "IX_UserCourseDetails_DoctorId");

            migrationBuilder.RenameIndex(
                name: "IX_UserCourseDetail_CourseId",
                table: "UserCourseDetails",
                newName: "IX_UserCourseDetails_CourseId");

            migrationBuilder.RenameIndex(
                name: "IX_NotificationEventContent_UserId",
                table: "NotificationEventContents",
                newName: "IX_NotificationEventContents_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_NotificationEventContent_EventContentId",
                table: "NotificationEventContents",
                newName: "IX_NotificationEventContents_EventContentId");

            migrationBuilder.RenameIndex(
                name: "IX_EventContent_EventId",
                table: "EventContents",
                newName: "IX_EventContents_EventId");

            migrationBuilder.RenameIndex(
                name: "IX_EventContent_CourseCurrentId",
                table: "EventContents",
                newName: "IX_EventContents_CourseCurrentId");

            migrationBuilder.RenameIndex(
                name: "IX_Comment_UserId",
                table: "Comments",
                newName: "IX_Comments_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Comment_EventContentId",
                table: "Comments",
                newName: "IX_Comments_EventContentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserCourseDetails",
                table: "UserCourseDetails",
                column: "CourseCurrentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_NotificationEventContents",
                table: "NotificationEventContents",
                column: "NotificationEventContentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EventContents",
                table: "EventContents",
                column: "EventContentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Events",
                table: "Events",
                column: "EventId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Courses",
                table: "Courses",
                column: "CourseId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Comments",
                table: "Comments",
                column: "CommentId");

            migrationBuilder.CreateTable(
                name: "Abilities",
                columns: table => new
                {
                    AbilityId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    AbilityName = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    Color = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Abilities", x => x.AbilityId);
                });

            migrationBuilder.CreateTable(
                name: "Wikis",
                columns: table => new
                {
                    TableId = table.Column<int>(type: "integer", nullable: false),
                    StatusId = table.Column<int>(type: "integer", nullable: false),
                    TableName = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    StatusName = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Wikis", x => new { x.TableId, x.StatusId });
                });

            migrationBuilder.CreateTable(
                name: "EventContentAbilities",
                columns: table => new
                {
                    EventContentId = table.Column<int>(type: "integer", nullable: false),
                    AbilityId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventContentAbilities", x => new { x.EventContentId, x.AbilityId });
                    table.ForeignKey(
                        name: "FK_EventContentAbilities_Abilities_AbilityId",
                        column: x => x.AbilityId,
                        principalTable: "Abilities",
                        principalColumn: "AbilityId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EventContentAbilities_EventContents_EventContentId",
                        column: x => x.EventContentId,
                        principalTable: "EventContents",
                        principalColumn: "EventContentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EventContents_StudentId",
                table: "EventContents",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_EventContentAbilities_AbilityId",
                table: "EventContentAbilities",
                column: "AbilityId");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_AspNetUsers_UserId",
                table: "Comments",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_EventContents_EventContentId",
                table: "Comments",
                column: "EventContentId",
                principalTable: "EventContents",
                principalColumn: "EventContentId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EventContents_AspNetUsers_StudentId",
                table: "EventContents",
                column: "StudentId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_EventContents_Events_EventId",
                table: "EventContents",
                column: "EventId",
                principalTable: "Events",
                principalColumn: "EventId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EventContents_UserCourseDetails_CourseCurrentId",
                table: "EventContents",
                column: "CourseCurrentId",
                principalTable: "UserCourseDetails",
                principalColumn: "CourseCurrentId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_NotificationEventContents_AspNetUsers_UserId",
                table: "NotificationEventContents",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_NotificationEventContents_EventContents_EventContentId",
                table: "NotificationEventContents",
                column: "EventContentId",
                principalTable: "EventContents",
                principalColumn: "EventContentId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserCourseDetails_AspNetUsers_DoctorId",
                table: "UserCourseDetails",
                column: "DoctorId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserCourseDetails_AspNetUsers_TeacherId",
                table: "UserCourseDetails",
                column: "TeacherId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserCourseDetails_Courses_CourseId",
                table: "UserCourseDetails",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "CourseId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_AspNetUsers_UserId",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Comments_EventContents_EventContentId",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_EventContents_AspNetUsers_StudentId",
                table: "EventContents");

            migrationBuilder.DropForeignKey(
                name: "FK_EventContents_Events_EventId",
                table: "EventContents");

            migrationBuilder.DropForeignKey(
                name: "FK_EventContents_UserCourseDetails_CourseCurrentId",
                table: "EventContents");

            migrationBuilder.DropForeignKey(
                name: "FK_NotificationEventContents_AspNetUsers_UserId",
                table: "NotificationEventContents");

            migrationBuilder.DropForeignKey(
                name: "FK_NotificationEventContents_EventContents_EventContentId",
                table: "NotificationEventContents");

            migrationBuilder.DropForeignKey(
                name: "FK_UserCourseDetails_AspNetUsers_DoctorId",
                table: "UserCourseDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_UserCourseDetails_AspNetUsers_TeacherId",
                table: "UserCourseDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_UserCourseDetails_Courses_CourseId",
                table: "UserCourseDetails");

            migrationBuilder.DropTable(
                name: "EventContentAbilities");

            migrationBuilder.DropTable(
                name: "Wikis");

            migrationBuilder.DropTable(
                name: "Abilities");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserCourseDetails",
                table: "UserCourseDetails");

            migrationBuilder.DropPrimaryKey(
                name: "PK_NotificationEventContents",
                table: "NotificationEventContents");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Events",
                table: "Events");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EventContents",
                table: "EventContents");

            migrationBuilder.DropIndex(
                name: "IX_EventContents_StudentId",
                table: "EventContents");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Courses",
                table: "Courses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Comments",
                table: "Comments");

            migrationBuilder.RenameTable(
                name: "UserCourseDetails",
                newName: "UserCourseDetail");

            migrationBuilder.RenameTable(
                name: "NotificationEventContents",
                newName: "NotificationEventContent");

            migrationBuilder.RenameTable(
                name: "Events",
                newName: "Event");

            migrationBuilder.RenameTable(
                name: "EventContents",
                newName: "EventContent");

            migrationBuilder.RenameTable(
                name: "Courses",
                newName: "Course");

            migrationBuilder.RenameTable(
                name: "Comments",
                newName: "Comment");

            migrationBuilder.RenameIndex(
                name: "IX_UserCourseDetails_TeacherId",
                table: "UserCourseDetail",
                newName: "IX_UserCourseDetail_TeacherId");

            migrationBuilder.RenameIndex(
                name: "IX_UserCourseDetails_DoctorId",
                table: "UserCourseDetail",
                newName: "IX_UserCourseDetail_DoctorId");

            migrationBuilder.RenameIndex(
                name: "IX_UserCourseDetails_CourseId",
                table: "UserCourseDetail",
                newName: "IX_UserCourseDetail_CourseId");

            migrationBuilder.RenameIndex(
                name: "IX_NotificationEventContents_UserId",
                table: "NotificationEventContent",
                newName: "IX_NotificationEventContent_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_NotificationEventContents_EventContentId",
                table: "NotificationEventContent",
                newName: "IX_NotificationEventContent_EventContentId");

            migrationBuilder.RenameIndex(
                name: "IX_EventContents_EventId",
                table: "EventContent",
                newName: "IX_EventContent_EventId");

            migrationBuilder.RenameIndex(
                name: "IX_EventContents_CourseCurrentId",
                table: "EventContent",
                newName: "IX_EventContent_CourseCurrentId");

            migrationBuilder.RenameIndex(
                name: "IX_Comments_UserId",
                table: "Comment",
                newName: "IX_Comment_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Comments_EventContentId",
                table: "Comment",
                newName: "IX_Comment_EventContentId");

            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "EventContent",
                type: "text",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserCourseDetail",
                table: "UserCourseDetail",
                column: "CourseCurrentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_NotificationEventContent",
                table: "NotificationEventContent",
                column: "NotificationEventContentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Event",
                table: "Event",
                column: "EventId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EventContent",
                table: "EventContent",
                column: "EventContentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Course",
                table: "Course",
                column: "CourseId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Comment",
                table: "Comment",
                column: "CommentId");

            migrationBuilder.CreateIndex(
                name: "IX_EventContent_ApplicationUserId",
                table: "EventContent",
                column: "ApplicationUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Comment_AspNetUsers_UserId",
                table: "Comment",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Comment_EventContent_EventContentId",
                table: "Comment",
                column: "EventContentId",
                principalTable: "EventContent",
                principalColumn: "EventContentId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EventContent_AspNetUsers_ApplicationUserId",
                table: "EventContent",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_EventContent_Event_EventId",
                table: "EventContent",
                column: "EventId",
                principalTable: "Event",
                principalColumn: "EventId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EventContent_UserCourseDetail_CourseCurrentId",
                table: "EventContent",
                column: "CourseCurrentId",
                principalTable: "UserCourseDetail",
                principalColumn: "CourseCurrentId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_NotificationEventContent_AspNetUsers_UserId",
                table: "NotificationEventContent",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_NotificationEventContent_EventContent_EventContentId",
                table: "NotificationEventContent",
                column: "EventContentId",
                principalTable: "EventContent",
                principalColumn: "EventContentId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserCourseDetail_AspNetUsers_DoctorId",
                table: "UserCourseDetail",
                column: "DoctorId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserCourseDetail_AspNetUsers_TeacherId",
                table: "UserCourseDetail",
                column: "TeacherId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_UserCourseDetail_Course_CourseId",
                table: "UserCourseDetail",
                column: "CourseId",
                principalTable: "Course",
                principalColumn: "CourseId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

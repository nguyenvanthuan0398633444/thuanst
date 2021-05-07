using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeamNET.Models.Entity;

namespace TeamNET.Models
{
    public class OJTDbContext : IdentityDbContext<ApplicationUser>
    {
        public OJTDbContext(DbContextOptions<OJTDbContext> options) : base(options)
        {

        }
        public DbSet<Wiki> Wikis { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Ability> Abilities { get; set; }
        public DbSet<EventContent> EventContents { get; set; }
        public DbSet<EventContentAbility> EventContentAbilities { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<UserCourseDetail> UserCourseDetails { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<NotificationEventContent> NotificationEventContents { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Wiki>().HasKey(wk => new { wk.TableId, wk.StatusId });

            modelBuilder.Entity<EventContentAbility>().HasKey(ecc => new { ecc.EventContentId, ecc.AbilityId });
            // ** n - 1 **
            modelBuilder.Entity<EventContent>()
                 .HasOne<ApplicationUser>(ec => ec.ApplicationUser)
                 .WithMany(s => s.EventContents)
                 .HasForeignKey(ec => ec.StudentId);


            //***************** SEEDING DATA **************************

            //---------------------- NotificationEventContent
            modelBuilder.Entity<NotificationEventContent>().HasData(new List<NotificationEventContent>
            {
                 //STUDENT 1 - EVENT 1 - USER_COURSE_DETAIL_1
                new NotificationEventContent { NotificationEventContentId = 1, EventContentId = 1, UserId = "2f3baf7f-a5b4-4627-abcb-0e42e2fb33a8", Notification = 0},
                new NotificationEventContent { NotificationEventContentId = 2, EventContentId = 1, UserId = "16a69b03-3b90-49a2-9cac-4b940c91514c", Notification = 0},
                new NotificationEventContent { NotificationEventContentId = 3, EventContentId = 1, UserId = "2115c7e6-9aae-43cb-a406-d504578498ba", Notification = 0},
                new NotificationEventContent { NotificationEventContentId = 4, EventContentId = 1, UserId = "3dabf300-50ab-438b-baaa-f6890f2b260c", Notification = 0},

                //STUDENT 2 - EVENT 2 - USER_COURSE_DETAIL_1
                new NotificationEventContent { NotificationEventContentId = 5, EventContentId = 2, UserId = "2f67c183-6ebf-4920-9cca-7d1a7a2b173c", Notification = 0},
                new NotificationEventContent { NotificationEventContentId = 6, EventContentId = 2, UserId = "16a69b03-3b90-49a2-9cac-4b940c91514c", Notification = 0},
                new NotificationEventContent { NotificationEventContentId = 7, EventContentId = 2, UserId = "2115c7e6-9aae-43cb-a406-d504578498ba", Notification = 0},
                new NotificationEventContent { NotificationEventContentId = 8, EventContentId = 2, UserId = "560b9a81-71e6-4987-a6c2-ecf72ecd36b5", Notification = 0},

                //STUDENT 1 - EVENT 3 - USER_COURSE_DETAIL_1
                new NotificationEventContent { NotificationEventContentId = 9, EventContentId = 3, UserId = "2f3baf7f-a5b4-4627-abcb-0e42e2fb33a8", Notification = 0},
                new NotificationEventContent { NotificationEventContentId = 10, EventContentId = 3, UserId = "16a69b03-3b90-49a2-9cac-4b940c91514c", Notification = 0},
                new NotificationEventContent { NotificationEventContentId = 11, EventContentId = 3, UserId = "2115c7e6-9aae-43cb-a406-d504578498ba", Notification = 0},
                new NotificationEventContent { NotificationEventContentId = 12, EventContentId = 3, UserId = "3dabf300-50ab-438b-baaa-f6890f2b260c", Notification = 0},

                //STUDENT 1 - EVENT 4 - USER_COURSE_DETAIL_1
                new NotificationEventContent { NotificationEventContentId = 13, EventContentId = 4, UserId = "2f3baf7f-a5b4-4627-abcb-0e42e2fb33a8", Notification = 0},
                new NotificationEventContent { NotificationEventContentId = 14, EventContentId = 4, UserId = "16a69b03-3b90-49a2-9cac-4b940c91514c", Notification = 0},
                new NotificationEventContent { NotificationEventContentId = 15, EventContentId = 4, UserId = "2115c7e6-9aae-43cb-a406-d504578498ba", Notification = 0},
                new NotificationEventContent { NotificationEventContentId = 16, EventContentId = 4, UserId = "3dabf300-50ab-438b-baaa-f6890f2b260c", Notification = 0},

                //STUDENT 1 - EVENT 5 - USER_COURSE_DETAIL_1
                new NotificationEventContent { NotificationEventContentId = 17, EventContentId = 5, UserId = "2f3baf7f-a5b4-4627-abcb-0e42e2fb33a8", Notification = 0},
                new NotificationEventContent { NotificationEventContentId = 18, EventContentId = 5, UserId = "16a69b03-3b90-49a2-9cac-4b940c91514c", Notification = 0},
                new NotificationEventContent { NotificationEventContentId = 19, EventContentId = 5, UserId = "2115c7e6-9aae-43cb-a406-d504578498ba", Notification = 0},
                new NotificationEventContent { NotificationEventContentId = 20, EventContentId = 5, UserId = "3dabf300-50ab-438b-baaa-f6890f2b260c", Notification = 0},

                //STUDENT 2 - EVENT 6 - USER_COURSE_DETAIL_1
                new NotificationEventContent { NotificationEventContentId = 21, EventContentId = 6, UserId = "2f67c183-6ebf-4920-9cca-7d1a7a2b173c", Notification = 0},
                new NotificationEventContent { NotificationEventContentId = 22, EventContentId = 6, UserId = "16a69b03-3b90-49a2-9cac-4b940c91514c", Notification = 0},
                new NotificationEventContent { NotificationEventContentId = 23, EventContentId = 6, UserId = "2115c7e6-9aae-43cb-a406-d504578498ba", Notification = 0},
                new NotificationEventContent { NotificationEventContentId = 24, EventContentId = 6, UserId = "560b9a81-71e6-4987-a6c2-ecf72ecd36b5", Notification = 0},

                 //STUDENT 1 - EVENT 7 - USER_COURSE_DETAIL_2
                new NotificationEventContent { NotificationEventContentId = 25, EventContentId = 7, UserId = "2f3baf7f-a5b4-4627-abcb-0e42e2fb33a8", Notification = 0},
                new NotificationEventContent { NotificationEventContentId = 26, EventContentId = 7, UserId = "16a69b03-3b90-49a2-9cac-4b940c91514c", Notification = 0},
                new NotificationEventContent { NotificationEventContentId = 27, EventContentId = 7, UserId = "2115c7e6-9aae-43cb-a406-d504578498ba", Notification = 0},
                new NotificationEventContent { NotificationEventContentId = 28, EventContentId = 7, UserId = "3dabf300-50ab-438b-baaa-f6890f2b260c", Notification = 0},

                //STUDENT 1 - EVENT 8 - - USER_COURSE_DETAIL_2
                new NotificationEventContent { NotificationEventContentId = 29, EventContentId = 8, UserId = "2f3baf7f-a5b4-4627-abcb-0e42e2fb33a8", Notification = 0},
                new NotificationEventContent { NotificationEventContentId = 30, EventContentId = 8, UserId = "16a69b03-3b90-49a2-9cac-4b940c91514c", Notification = 2},
                new NotificationEventContent { NotificationEventContentId = 31, EventContentId = 8, UserId = "2115c7e6-9aae-43cb-a406-d504578498ba", Notification = 0},
                new NotificationEventContent { NotificationEventContentId = 32, EventContentId = 8, UserId = "3dabf300-50ab-438b-baaa-f6890f2b260c", Notification = 3},

                //STUDENT 2 - EVENT 9 - USER_COURSE_DETAIL_2
                new NotificationEventContent { NotificationEventContentId = 33, EventContentId = 9, UserId = "2f67c183-6ebf-4920-9cca-7d1a7a2b173c", Notification = 1},
                new NotificationEventContent { NotificationEventContentId = 34, EventContentId = 9, UserId = "16a69b03-3b90-49a2-9cac-4b940c91514c", Notification = 2},
                new NotificationEventContent { NotificationEventContentId = 35, EventContentId = 9, UserId = "2115c7e6-9aae-43cb-a406-d504578498ba", Notification = 1},
                new NotificationEventContent { NotificationEventContentId = 36, EventContentId = 9, UserId = "560b9a81-71e6-4987-a6c2-ecf72ecd36b5", Notification = 0},

                 //STUDENT 3 - EVENT 10 - USER_COURSE_DETAIL_3
                new NotificationEventContent { NotificationEventContentId = 37, EventContentId = 10, UserId = "3c592e96-f3ad-4e8b-9cbe-afb7ea745362", Notification = 3},
                new NotificationEventContent { NotificationEventContentId = 38, EventContentId = 10, UserId = "1efe96d9-6618-4269-a6e3-ae1e3d3eecc4", Notification = 2},
                new NotificationEventContent { NotificationEventContentId = 39, EventContentId = 10, UserId = "29a908b8-3ac4-45ea-a8a1-1cf9946079c7", Notification = 0},
                new NotificationEventContent { NotificationEventContentId = 40, EventContentId = 10, UserId = "3dabf300-50ab-438b-baaa-f6890f2b260c", Notification = 2}

            });

            //---------------------- EVENT
            modelBuilder.Entity<Event>().HasData(new List<Event>
            {
                new Event { EventId = 1, EventName = "Bóng đá", Icon = "las la-futbol"},
                new Event { EventId = 2, EventName = "Hát", Icon = "las la-microphone-alt"},
                new Event { EventId = 3, EventName = "Bóng chuyền", Icon = "las la-volleyball-ball"},
                new Event { EventId = 4, EventName = "Bóng rổ", Icon = "las la-basketball-ball"},
                new Event { EventId = 5, EventName = "Sách", Icon = "las la-book-reader"}
            });

            //---------------------- COMMENT
            modelBuilder.Entity<Comment>().HasData(new List<Comment>
            {
                //STUDENT 1 - EVENT 1 - USER_COURSE_DETAIL_1
                new Comment { CommentId = 1, EventContentId = 1, UserId = "2f3baf7f-a5b4-4627-abcb-0e42e2fb33a8",
                                Text = "StudentComentEvent 1", RealTime = new DateTime(2020,02,12,13,20,50)},
                new Comment { CommentId = 2, EventContentId = 1, UserId = "16a69b03-3b90-49a2-9cac-4b940c91514c",
                                Text = "TeacherComentEvent 1", RealTime = new DateTime(2020,02,12,15,10,20)},
                new Comment { CommentId = 3, EventContentId = 1, UserId = "2115c7e6-9aae-43cb-a406-d504578498ba",
                                Text = "#Tính tự lập #Khả năng lập kế hoạch #Có tính kỷ luật - DoctorComentEvent 1", RealTime = new DateTime(2020,02,12,17,30,40)},
                new Comment { CommentId = 4, EventContentId = 1, UserId = "3dabf300-50ab-438b-baaa-f6890f2b260c",
                                Text = "GuardianComentEvent 1", RealTime = new DateTime(2020,02,12,20,15,55)},

                 //STUDENT 2 - EVENT 2 - USER_COURSE_DETAIL_1
                new Comment { CommentId = 5, EventContentId = 2, UserId = "2f67c183-6ebf-4920-9cca-7d1a7a2b173c",
                                Text = "StudentComentEvent 2", RealTime = new DateTime(2020,02,15,14,15,25)},
                new Comment { CommentId = 6, EventContentId = 2, UserId = "16a69b03-3b90-49a2-9cac-4b940c91514c",
                                Text = "TeacherComentEvent 2", RealTime = new DateTime(2020,02,15,16,20,50)},
                new Comment { CommentId = 7, EventContentId = 2, UserId = "2115c7e6-9aae-43cb-a406-d504578498ba",
                                Text = "#Khả năng làm việc - DoctorComentEvent 2", RealTime = new DateTime(2020,02,15,17,30,40)},
                new Comment { CommentId = 8, EventContentId = 2, UserId = "560b9a81-71e6-4987-a6c2-ecf72ecd36b5",
                                Text = "GuardianComentEvent 2", RealTime = new DateTime(2020,02,15,19,5,25)},

                 //STUDENT 1 - EVENT 3 - USER_COURSE_DETAIL_1
                new Comment { CommentId = 9, EventContentId = 3, UserId = "2f3baf7f-a5b4-4627-abcb-0e42e2fb33a8",
                                Text = "StudentComentEvent 3", RealTime = new DateTime(2020,05,20,14,15,25)},
                new Comment { CommentId = 10, EventContentId = 3, UserId = "16a69b03-3b90-49a2-9cac-4b940c91514c",
                                Text = "TeacherComentEvent 3", RealTime = new DateTime(2020,05,20,16,20,50)},
                new Comment { CommentId = 11, EventContentId = 3, UserId = "2115c7e6-9aae-43cb-a406-d504578498ba",
                                Text = "#Khả năng làm việc - DoctorComentEvent 3", RealTime = new DateTime(2020,05,20,17,30,40)},
                new Comment { CommentId = 12, EventContentId = 3, UserId = "3dabf300-50ab-438b-baaa-f6890f2b260c",
                                Text = "GuardianComentEvent 3", RealTime = new DateTime(2020,05,20,19,5,25)},

                //STUDENT 1 - EVENT 4 - USER_COURSE_DETAIL_1
                new Comment { CommentId = 13, EventContentId = 4, UserId = "2f3baf7f-a5b4-4627-abcb-0e42e2fb33a8",
                                Text = "StudentComentEvent 4", RealTime = new DateTime(2020,06,25,14,15,25)},
                new Comment { CommentId = 14, EventContentId = 4, UserId = "16a69b03-3b90-49a2-9cac-4b940c91514c",
                                Text = "TeacherComentEvent 4", RealTime = new DateTime(2020,06,25,16,20,50)},
                new Comment { CommentId = 15, EventContentId = 4, UserId = "2115c7e6-9aae-43cb-a406-d504578498ba",
                                Text = "#Khả năng làm việc - DoctorComentEvent 4", RealTime = new DateTime(2020,06,25,17,30,40)},
                new Comment { CommentId = 16, EventContentId = 4, UserId = "3dabf300-50ab-438b-baaa-f6890f2b260c",
                                Text = "GuardianComentEvent 4", RealTime = new DateTime(2020,06,25,19,5,25)},

                //STUDENT 1 - EVENT 5 - USER_COURSE_DETAIL_1
                new Comment { CommentId = 17, EventContentId = 5, UserId = "2f3baf7f-a5b4-4627-abcb-0e42e2fb33a8",
                                Text = "StudentComentEvent 5", RealTime = new DateTime(2020,07,12,14,15,25)},
                new Comment { CommentId = 18, EventContentId = 5, UserId = "16a69b03-3b90-49a2-9cac-4b940c91514c",
                                Text = "TeacherComentEvent 5", RealTime = new DateTime(2020,07,12,16,20,50)},
                new Comment { CommentId = 19, EventContentId = 5, UserId = "2115c7e6-9aae-43cb-a406-d504578498ba",
                                Text = "#Khả năng lập kế hoạch - DoctorComentEvent 5", RealTime = new DateTime(2020,07,12,17,30,40)},
                new Comment { CommentId = 20, EventContentId = 5, UserId = "3dabf300-50ab-438b-baaa-f6890f2b260c",
                                Text = "GuardianComentEvent 5", RealTime = new DateTime(2020,07,12,19,5,25)},

                //STUDENT 2 - EVENT 6 - USER_COURSE_DETAIL_1
                new Comment { CommentId = 21, EventContentId = 6, UserId = "2f67c183-6ebf-4920-9cca-7d1a7a2b173c",
                                Text = "StudentComentEvent 6", RealTime = new DateTime(2020,07,20,14,15,25)},
                new Comment { CommentId = 22, EventContentId = 6, UserId = "16a69b03-3b90-49a2-9cac-4b940c91514c",
                                Text = "TeacherComentEvent 6", RealTime = new DateTime(2020,07,20,16,20,50)},
                new Comment { CommentId = 23, EventContentId = 6, UserId = "2115c7e6-9aae-43cb-a406-d504578498ba",
                                Text = "#Có tính mềm dẻo, linh hoạt - DoctorComentEvent 6", RealTime = new DateTime(2020,07,20,17,30,40)},
                new Comment { CommentId = 24, EventContentId = 6, UserId = "560b9a81-71e6-4987-a6c2-ecf72ecd36b5",
                                Text = "GuardianComentEvent 6", RealTime = new DateTime(2020,07,20,19,5,25)},

                //STUDENT 1 - EVENT 7 - USER_COURSE_DETAIL_2
                new Comment { CommentId = 25, EventContentId = 7, UserId = "2f3baf7f-a5b4-4627-abcb-0e42e2fb33a8",
                                Text = "StudentComentEvent 7", RealTime = new DateTime(2021,01,25,14,15,25)},
                new Comment { CommentId = 26, EventContentId = 7, UserId = "16a69b03-3b90-49a2-9cac-4b940c91514c",
                                Text = "TeacherComentEvent 7", RealTime = new DateTime(2021,01,25,16,20,50)},
                new Comment { CommentId = 27, EventContentId = 7, UserId = "2115c7e6-9aae-43cb-a406-d504578498ba",
                                Text = "#Khả năng thực hành - #Có tính mềm dẻo, linh hoạt - DoctorComentEvent 7", RealTime = new DateTime(2021,01,25,17,30,40)},
                new Comment { CommentId = 28, EventContentId = 7, UserId = "3dabf300-50ab-438b-baaa-f6890f2b260c",
                                Text = "GuardianComentEvent 7", RealTime = new DateTime(2020,07,25,19,5,25)},

                 //STUDENT 1 - EVENT 8 - - USER_COURSE_DETAIL_2
                new Comment { CommentId = 29, EventContentId = 8, UserId = "2f3baf7f-a5b4-4627-abcb-0e42e2fb33a8",
                                Text = "StudentComentEvent 8", RealTime = new DateTime(2021,02,02,14,15,25)},
                new Comment { CommentId = 30, EventContentId = 8, UserId = "16a69b03-3b90-49a2-9cac-4b940c91514c",
                                Text = "TeacherComentEvent 8", RealTime = new DateTime(2021,02,02,16,20,50)},
                new Comment { CommentId = 31, EventContentId = 8, UserId = "2115c7e6-9aae-43cb-a406-d504578498ba",
                                Text = "#Khả năng chịu được áp lực - DoctorComentEvent 8", RealTime = new DateTime(2021,02,02,17,30,40)},
                new Comment { CommentId = 32, EventContentId = 8, UserId = "3dabf300-50ab-438b-baaa-f6890f2b260c",
                                Text = "GuardianComentEvent 8", RealTime = new DateTime(2020,02,02,19,5,25)},

                //STUDENT 2 - EVENT 9 - USER_COURSE_DETAIL_2
                new Comment { CommentId = 33, EventContentId = 9, UserId = "2f67c183-6ebf-4920-9cca-7d1a7a2b173c",
                                Text = "StudentComentEvent 9", RealTime = new DateTime(2021,02,10,14,15,25)},
                new Comment { CommentId = 34, EventContentId = 9, UserId = "16a69b03-3b90-49a2-9cac-4b940c91514c",
                                Text = "TeacherComentEvent 9", RealTime = new DateTime(2021,02,10,16,20,50)},
                new Comment { CommentId = 35, EventContentId = 9, UserId = "2115c7e6-9aae-43cb-a406-d504578498ba",
                                Text = "#Tính tự lập - DoctorComentEvent 9", RealTime = new DateTime(2021,02,10,17,30,40)},
                new Comment { CommentId = 36, EventContentId = 9, UserId = "560b9a81-71e6-4987-a6c2-ecf72ecd36b5",
                                Text = "GuardianComentEvent 9", RealTime = new DateTime(2021,02,10,19,5,25)},

                 //STUDENT 3 - EVENT 10 - USER_COURSE_DETAIL_3
                new Comment { CommentId = 37, EventContentId = 10, UserId = "3c592e96-f3ad-4e8b-9cbe-afb7ea745362",
                                Text = "StudentComentEvent 10", RealTime = new DateTime(2021,03,15,14,15,25)},
                new Comment { CommentId = 38, EventContentId = 10, UserId = "1efe96d9-6618-4269-a6e3-ae1e3d3eecc4",
                                Text = "TeacherComentEvent 10", RealTime = new DateTime(2021,03,15,16,20,50)},
                new Comment { CommentId = 39, EventContentId = 10, UserId = "29a908b8-3ac4-45ea-a8a1-1cf9946079c7",
                                Text = "#Khả năng giải quyết vấn đề #Khả năng sáng tạo - DoctorComentEvent 10", RealTime = new DateTime(2021,03,15,17,30,40)},
                new Comment { CommentId = 40, EventContentId = 10, UserId = "3dabf300-50ab-438b-baaa-f6890f2b260c",
                                Text = "GuardianComentEvent 10", RealTime = new DateTime(2020,03,15,19,5,25)}
            });

            //---------------------- EVENT CONTENT ABILITY
            modelBuilder.Entity<EventContentAbility>().HasData(new List<EventContentAbility>
            {
                new EventContentAbility{ EventContentId = 1, AbilityId = 1},
                new EventContentAbility{ EventContentId = 1, AbilityId = 5},
                new EventContentAbility{ EventContentId = 1, AbilityId = 11},
                new EventContentAbility{ EventContentId = 2, AbilityId = 2},
                new EventContentAbility{ EventContentId = 3, AbilityId = 2},
                new EventContentAbility{ EventContentId = 4, AbilityId = 2},
                new EventContentAbility{ EventContentId = 5, AbilityId = 5},
                new EventContentAbility{ EventContentId = 6, AbilityId = 9},
                new EventContentAbility{ EventContentId = 7, AbilityId = 3},
                new EventContentAbility{ EventContentId = 8, AbilityId = 12},
                new EventContentAbility{ EventContentId = 9, AbilityId = 1},
                new EventContentAbility{ EventContentId = 10, AbilityId = 4},
                new EventContentAbility{ EventContentId = 10, AbilityId = 6}
            });


            //---------------------- EVENT CONTENT

            modelBuilder.Entity<EventContent>().HasData(new List<EventContent>
            {
                new EventContent{
                    EventContentId = 1, EventId = 1 , StudentId = "2f3baf7f-a5b4-4627-abcb-0e42e2fb33a8",
                    CommunityAbility = "Answer 11", ActionAbility = "Answer 12", DemonstratedAbility = "Answer 13",
                    SelfDevelopment = "Answer 14", ThinkingAbility = "Answer 15", CourseCurrentId = 1, StatusId = 3},
                 new EventContent{
                    EventContentId = 2, EventId = 3 , StudentId = "2f67c183-6ebf-4920-9cca-7d1a7a2b173c",
                    CommunityAbility = "Answer 21", ActionAbility = "Answer 22", DemonstratedAbility = "Answer 23",
                    SelfDevelopment = "Answer 24", ThinkingAbility = "Answer 25", CourseCurrentId = 1, StatusId = 3},
                 new EventContent{
                    EventContentId = 3, EventId = 4 , StudentId = "2f3baf7f-a5b4-4627-abcb-0e42e2fb33a8",
                    CommunityAbility = "Answer 111", ActionAbility = "Answer 112", DemonstratedAbility = "Answer 113",
                    SelfDevelopment = "Answer 114", ThinkingAbility = "Answer 115", CourseCurrentId = 1, StatusId = 3},
                 new EventContent{
                    EventContentId = 4, EventId = 4 , StudentId = "2f3baf7f-a5b4-4627-abcb-0e42e2fb33a8",
                    CommunityAbility = "Answer 1111", ActionAbility = "Answer 1112", DemonstratedAbility = "Answer 1113",
                    SelfDevelopment = "Answer 1114", ThinkingAbility = "Answer 1115", CourseCurrentId = 1, StatusId = 3},
                  new EventContent{
                    EventContentId = 5, EventId = 5 , StudentId = "2f3baf7f-a5b4-4627-abcb-0e42e2fb33a8",
                    CommunityAbility = "Answer 11111", ActionAbility = "Answer 11112", DemonstratedAbility = "Answer 11113",
                    SelfDevelopment = "Answer 11114", ThinkingAbility = "Answer 11115", CourseCurrentId = 1, StatusId = 3},
                  new EventContent{
                    EventContentId = 6, EventId = 2 , StudentId = "2f67c183-6ebf-4920-9cca-7d1a7a2b173c",
                    CommunityAbility = "Answer 221", ActionAbility = "Answer 222", DemonstratedAbility = "Answer 223",
                    SelfDevelopment = "Answer 224", ThinkingAbility = "Answer 225", CourseCurrentId = 1, StatusId = 3},
                   new EventContent{
                    EventContentId = 7, EventId = 2 , StudentId = "2f3baf7f-a5b4-4627-abcb-0e42e2fb33a8",
                    CommunityAbility = "Answer 111111", ActionAbility = "Answer 111112", DemonstratedAbility = "Answer 111113",
                    SelfDevelopment = "Answer 111114", ThinkingAbility = "Answer 111115", CourseCurrentId = 2, StatusId = 1},
                   new EventContent{
                    EventContentId = 8, EventId = 2 , StudentId = "2f3baf7f-a5b4-4627-abcb-0e42e2fb33a8",
                    CommunityAbility = "Answer 1111111", ActionAbility = "Answer 1111112", DemonstratedAbility = "Answer 1111113",
                    SelfDevelopment = "Answer 1111114", ThinkingAbility = "Answer 1111115", CourseCurrentId = 2, StatusId = 1},
                   new EventContent{
                    EventContentId = 9, EventId = 5 , StudentId = "2f67c183-6ebf-4920-9cca-7d1a7a2b173c",
                    CommunityAbility = "Answer 2221", ActionAbility = "Answer 2222", DemonstratedAbility = "Answer 2223",
                    SelfDevelopment = "Answer 2224", ThinkingAbility = "Answer 2225", CourseCurrentId = 2, StatusId = 1},
                    new EventContent{
                    EventContentId = 10, EventId = 3 , StudentId = "3c592e96-f3ad-4e8b-9cbe-afb7ea745362",
                    CommunityAbility = "Answer 31", ActionAbility = "Answer 32", DemonstratedAbility = "Answer 33",
                    SelfDevelopment = "Answer 34", ThinkingAbility = "Answer 35", CourseCurrentId = 3, StatusId = 1}
            });

            //----------------------WIKI

            modelBuilder.Entity<Wiki>().HasData(new List<Wiki>
            {
               new Wiki {TableId = 1, TableName = "EventContent", StatusId = 1 , StatusName = "Đang xác nhận", IsDeleted = false},
               new Wiki {TableId = 1, TableName = "EventContent", StatusId = 2 , StatusName = "Xác nhận", IsDeleted = false},
               new Wiki {TableId = 1, TableName = "EventContent", StatusId = 3 , StatusName = "Hoàn thành", IsDeleted = false},
               new Wiki {TableId = 1, TableName = "EventContent", StatusId = 4 , StatusName = "Đã xóa", IsDeleted = false}
            });

            //----------------------COURSE

            modelBuilder.Entity<Course>().HasData(new List<Course>
            {
               new Course {CourseId = 1, CourseName = "Class 1"},
               new Course {CourseId = 2, CourseName = "Class 2"},
               new Course {CourseId = 3, CourseName = "Class 3"},
               new Course {CourseId = 4, CourseName = "Class 4"},
               new Course {CourseId = 5, CourseName = "Class 5"},
               new Course {CourseId = 6, CourseName = "Class 6"},
               new Course {CourseId = 7, CourseName = "Class 7"},
               new Course {CourseId = 8, CourseName = "Class 8"},
               new Course {CourseId = 9, CourseName = "Class 9"},
               new Course {CourseId = 10, CourseName = "Class 10"},
               new Course {CourseId = 11, CourseName = "Class 11"},
               new Course {CourseId = 12, CourseName = "Class 12"}
            });

            //----------------------USER COURSE DETAIL

            modelBuilder.Entity<UserCourseDetail>().HasData(new List<UserCourseDetail>
            {
               new UserCourseDetail
               {
                   CourseCurrentId = 1,
                   TeacherId = "16a69b03-3b90-49a2-9cac-4b940c91514c",
                   DoctorId = "2115c7e6-9aae-43cb-a406-d504578498ba",
                   CourseId = 1
               },
               new UserCourseDetail
               {
                   CourseCurrentId = 2,
                   TeacherId = "16a69b03-3b90-49a2-9cac-4b940c91514c",
                   DoctorId = "2115c7e6-9aae-43cb-a406-d504578498ba",
                   CourseId = 2
               },
                new UserCourseDetail
               {
                   CourseCurrentId = 3,
                   TeacherId = "1efe96d9-6618-4269-a6e3-ae1e3d3eecc4",
                   DoctorId = "29a908b8-3ac4-45ea-a8a1-1cf9946079c7",
                   CourseId = 1
               }
            });

            //----------------------ABILITY

            modelBuilder.Entity<Ability>().HasData(new List<Ability>
            {
               new Ability {AbilityId = 1, AbilityName = "Tính tự lập", Color = "#3a2d38"},
               new Ability {AbilityId = 2, AbilityName = "Khả năng làm việc", Color = "#1d545b"},
               new Ability {AbilityId = 3, AbilityName = "Khả năng thực hành", Color = "#f4d8cd"},
               new Ability {AbilityId = 4, AbilityName = "Khả năng giải quyết vấn đề", Color = "#f78c3a"},
               new Ability {AbilityId = 5, AbilityName = "Khả năng lập kế hoạch", Color = "#d62f0a"},
               new Ability {AbilityId = 6, AbilityName = "Khả năng sáng tạo", Color = "#efa101"},
               new Ability {AbilityId = 7, AbilityName = "Khả năng truyền đạt", Color = "#5db1bf"},
               new Ability {AbilityId = 8, AbilityName = "Khả năng thấu hiểu", Color = "#662d9a"},
               new Ability {AbilityId = 9, AbilityName = "Có tính mềm dẻo, linh hoạt", Color = "#2a9034"},
               new Ability {AbilityId = 10, AbilityName = "Khả năng nắm bắt tình huống", Color = "#efaac3"},
               new Ability {AbilityId = 11, AbilityName = "Có tính kỷ luật", Color = "#a33972"},
               new Ability {AbilityId = 12, AbilityName = "Khả năng chịu được áp lực", Color = "#7291b6"}
            });


            //----------------------ASP - USER
            // ***************ROLE
            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Name = "System Admin",
                NormalizedName = "SYSTEM ADMIN",
                Id = "291cbc7f-1345-45df-b8c2-96111d13ad60",
                ConcurrencyStamp = "7f1afc1e-eb95-4455-b6b9-301e5fc46ac4"
            });
            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Name = "Student",
                NormalizedName = "STUDENT",
                Id = "947b70ee-4b80-4299-a3e4-b03df15501c1",
                ConcurrencyStamp = "ead43932-327f-411e-9313-bc399e503d22"
            });
            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Name = "Teacher",
                NormalizedName = "TEACHER",
                Id = "e346ef58-52dd-485d-92a3-25a64144bdfa",
                ConcurrencyStamp = "b5591e23-dda4-4788-a3b6-1fb3b1f07d04"
            });
            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Name = "Doctor",
                NormalizedName = "DOCTOR",
                Id = "f7e3b187-7743-4c11-a73f-398fe418acd1",
                ConcurrencyStamp = "5836f016-3405-4b44-b692-44cf861babb0"
            });
            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Name = "Guardian",
                NormalizedName = "GUARDIAN",
                Id = "a35c7eb1-a14a-4eed-9ec2-467127acedc1",
                ConcurrencyStamp = "cd64acc6-d3ee-42f5-96a1-0518e9e94509"
            });

            // ********************************USER

            // ***************ADMIN 
            //create user
            var appUser = new ApplicationUser
            {
                Id = "06b12f97-bb16-434a-9982-e3d3dc1c5145",
                Email = "superadmin@gmail.com",
                FullName = "TeamNET",
                EmailConfirmed = true,
                UserName = "superadmin@gmail.com",
                NormalizedEmail = "SUPERADMIN@GMAIL.COM",
                NormalizedUserName = "SUPERADMIN@GMAIL.COM"
            };

            //set user password
            PasswordHasher<ApplicationUser> ph = new PasswordHasher<ApplicationUser>();
            appUser.PasswordHash = ph.HashPassword(appUser, "Asd123!");

            //seed user
            modelBuilder.Entity<ApplicationUser>().HasData(appUser);

            //set user role to admin
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = "291cbc7f-1345-45df-b8c2-96111d13ad60",
                UserId = "06b12f97-bb16-434a-9982-e3d3dc1c5145"
            });

            // ***************************** TEACHER 
            //***************TEACHER 1
            //create user
            var appUser1 = new ApplicationUser
            {
                Id = "16a69b03-3b90-49a2-9cac-4b940c91514c",
                Email = "teacher1@gmail.com",
                FullName = "Teacher1",
                EmailConfirmed = true,
                UserName = "teacher1@gmail.com",
                NormalizedEmail = "TEACHER1@GMAIL.COM",
                NormalizedUserName = "TEACHER1@GMAIL.COM",
                CourseCurrentId = 2,
                AvatarName = "teacher.png"
            };

            //set user password
            PasswordHasher<ApplicationUser> ph1 = new PasswordHasher<ApplicationUser>();
            appUser1.PasswordHash = ph1.HashPassword(appUser1, "Asd123!");

            //seed user
            modelBuilder.Entity<ApplicationUser>().HasData(appUser1);

            //set user role to admin
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = "e346ef58-52dd-485d-92a3-25a64144bdfa",
                UserId = "16a69b03-3b90-49a2-9cac-4b940c91514c"
            });

            //*******TEACHER 2
            //create user
            var appUser2 = new ApplicationUser
            {
                Id = "1efe96d9-6618-4269-a6e3-ae1e3d3eecc4",
                Email = "teacher2@gmail.com",
                FullName = "Teacher2",
                EmailConfirmed = true,
                UserName = "teacher2@gmail.com",
                NormalizedEmail = "TEACHER2@GMAIL.COM",
                NormalizedUserName = "TEACHER2@GMAIL.COM",
                CourseCurrentId = 3,
                AvatarName = "teacher.png"
            };

            //set user password
            PasswordHasher<ApplicationUser> ph2 = new PasswordHasher<ApplicationUser>();
            appUser2.PasswordHash = ph2.HashPassword(appUser2, "Asd123!");

            //seed user
            modelBuilder.Entity<ApplicationUser>().HasData(appUser2);

            //set user role to admin
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = "e346ef58-52dd-485d-92a3-25a64144bdfa",
                UserId = "1efe96d9-6618-4269-a6e3-ae1e3d3eecc4"
            });

            // ************************DOCTOR 
            //************DOCTOR 1
            //create user
            var appUser3 = new ApplicationUser
            {
                Id = "2115c7e6-9aae-43cb-a406-d504578498ba",
                Email = "doctor1@gmail.com",
                FullName = "Doctor1",
                EmailConfirmed = true,
                UserName = "doctor1@gmail.com",
                NormalizedEmail = "DOCTOR1@GMAIL.COM",
                NormalizedUserName = "DOCTOR1@GMAIL.COM",
                CourseCurrentId = 2,
                AvatarName = "doctor.jpg"
            };

            //set user password
            PasswordHasher<ApplicationUser> ph3 = new PasswordHasher<ApplicationUser>();
            appUser3.PasswordHash = ph3.HashPassword(appUser3, "Asd123!");

            //seed user
            modelBuilder.Entity<ApplicationUser>().HasData(appUser3);

            //set user role to admin
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = "f7e3b187-7743-4c11-a73f-398fe418acd1",
                UserId = "2115c7e6-9aae-43cb-a406-d504578498ba"
            });

            //****DOCTOR 2
            //create user
            var appUser4 = new ApplicationUser
            {
                Id = "29a908b8-3ac4-45ea-a8a1-1cf9946079c7",
                Email = "doctor2@gmail.com",
                FullName = "Doctor2",
                EmailConfirmed = true,
                UserName = "doctor2@gmail.com",
                NormalizedEmail = "DOCTOR2@GMAIL.COM",
                NormalizedUserName = "DOCTOR2@GMAIL.COM",
                CourseCurrentId = 3,
                AvatarName = "doctor.jpg"
            };

            //set user password
            PasswordHasher<ApplicationUser> ph4 = new PasswordHasher<ApplicationUser>();
            appUser4.PasswordHash = ph4.HashPassword(appUser4, "Asd123!");

            //seed user
            modelBuilder.Entity<ApplicationUser>().HasData(appUser4);

            //set user role to admin
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = "f7e3b187-7743-4c11-a73f-398fe418acd1",
                UserId = "29a908b8-3ac4-45ea-a8a1-1cf9946079c7"
            });

            // ************************STUDENT 
            //************STUDENT 1
            //create user
            var appUser5 = new ApplicationUser
            {
                Id = "2f3baf7f-a5b4-4627-abcb-0e42e2fb33a8",
                Email = "student1@gmail.com",
                FullName = "Student1",
                EmailConfirmed = true,
                UserName = "student1@gmail.com",
                StudentCode = "ST00001",
                GuardianId = "3dabf300-50ab-438b-baaa-f6890f2b260c",
                CourseCurrentId = 2,
                NormalizedEmail = "STUDENT1@GMAIL.COM",
                NormalizedUserName = "STUDENT1@GMAIL.COM",
                AvatarName = "student.png"
            };

            //set user password
            PasswordHasher<ApplicationUser> ph5 = new PasswordHasher<ApplicationUser>();
            appUser5.PasswordHash = ph5.HashPassword(appUser5, "Asd123!");

            //seed user
            modelBuilder.Entity<ApplicationUser>().HasData(appUser5);

            //set user role to admin
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = "947b70ee-4b80-4299-a3e4-b03df15501c1",
                UserId = "2f3baf7f-a5b4-4627-abcb-0e42e2fb33a8"
            });

            //************STUDENT 2
            //create user
            var appUser6 = new ApplicationUser
            {
                Id = "2f67c183-6ebf-4920-9cca-7d1a7a2b173c",
                Email = "student2@gmail.com",
                FullName = "Student2",
                EmailConfirmed = true,
                UserName = "student2@gmail.com",
                StudentCode = "ST00002",
                GuardianId = "560b9a81-71e6-4987-a6c2-ecf72ecd36b5",
                CourseCurrentId = 2,
                NormalizedEmail = "STUDENT2@GMAIL.COM",
                NormalizedUserName = "STUDENT2@GMAIL.COM",
                AvatarName = "student.png"
            };

            //set user password
            PasswordHasher<ApplicationUser> ph6 = new PasswordHasher<ApplicationUser>();
            appUser6.PasswordHash = ph6.HashPassword(appUser6, "Asd123!");

            //seed user
            modelBuilder.Entity<ApplicationUser>().HasData(appUser6);

            //set user role to admin
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = "947b70ee-4b80-4299-a3e4-b03df15501c1",
                UserId = "2f67c183-6ebf-4920-9cca-7d1a7a2b173c"
            });

            //************STUDENT 3
            //create user
            var appUser7 = new ApplicationUser
            {
                Id = "3c592e96-f3ad-4e8b-9cbe-afb7ea745362",
                Email = "student3@gmail.com",
                FullName = "Student3",
                EmailConfirmed = true,
                UserName = "student3@gmail.com",
                StudentCode = "ST00003",
                GuardianId = "3dabf300-50ab-438b-baaa-f6890f2b260c",
                CourseCurrentId = 3,
                NormalizedEmail = "STUDENT3@GMAIL.COM",
                NormalizedUserName = "STUDENT3@GMAIL.COM",
                AvatarName = "student.png"
            };

            //set user password
            PasswordHasher<ApplicationUser> ph7 = new PasswordHasher<ApplicationUser>();
            appUser7.PasswordHash = ph7.HashPassword(appUser7, "Asd123!");

            //seed user
            modelBuilder.Entity<ApplicationUser>().HasData(appUser7);

            //set user role to admin
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = "947b70ee-4b80-4299-a3e4-b03df15501c1",
                UserId = "3c592e96-f3ad-4e8b-9cbe-afb7ea745362"
            });

            // ************************GUARDIAN 
            //************GUARDIAN 1
            //create user
            var appUser8 = new ApplicationUser
            {
                Id = "3dabf300-50ab-438b-baaa-f6890f2b260c",
                Email = "guardian1@gmail.com",
                FullName = "Guardian1",
                EmailConfirmed = true,
                UserName = "guardian1@gmail.com",
                NormalizedEmail = "GUARDIAN1@GMAIL.COM",
                NormalizedUserName = "GUARDIAN1@GMAIL.COM",
                AvatarName = "guardian.png"
            };

            //set user password
            PasswordHasher<ApplicationUser> ph8 = new PasswordHasher<ApplicationUser>();
            appUser8.PasswordHash = ph8.HashPassword(appUser8, "Asd123!");

            //seed user
            modelBuilder.Entity<ApplicationUser>().HasData(appUser8);

            //set user role to admin
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = "a35c7eb1-a14a-4eed-9ec2-467127acedc1",
                UserId = "3dabf300-50ab-438b-baaa-f6890f2b260c"
            });

            //************GUARDIAN 2
            //create user
            var appUser9 = new ApplicationUser
            {
                Id = "560b9a81-71e6-4987-a6c2-ecf72ecd36b5",
                Email = "guardian2@gmail.com",
                FullName = "Guardian2",
                EmailConfirmed = true,
                UserName = "guardian2@gmail.com",
                NormalizedEmail = "GUARDIAN2@GMAIL.COM",
                NormalizedUserName = "GUARDIAN2@GMAIL.COM",
                AvatarName = "guardian.png"
            };

            //set user password
            PasswordHasher<ApplicationUser> ph9 = new PasswordHasher<ApplicationUser>();
            appUser9.PasswordHash = ph9.HashPassword(appUser9, "Asd123!");

            //seed user
            modelBuilder.Entity<ApplicationUser>().HasData(appUser9);

            //set user role to admin
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = "a35c7eb1-a14a-4eed-9ec2-467127acedc1",
                UserId = "560b9a81-71e6-4987-a6c2-ecf72ecd36b5"
            });


            //************GUARDIAN 3
            //create user
            //var appUser10 = new ApplicationUser
            //{
            //    Id = "5afbcc5e-955a-4614-a3a3-ebcb5283c77c",
            //    Email = "guardian3@gmail.com",
            //    FullName = "Guardian3",
            //    EmailConfirmed = true,
            //    UserName = "guardian3@gmail.com"
            //};

            ////set user password
            //PasswordHasher<ApplicationUser> ph10 = new PasswordHasher<ApplicationUser>();
            //appUser10.PasswordHash = ph.HashPassword(appUser10, "Asd123!");

            ////seed user
            //modelBuilder.Entity<ApplicationUser>().HasData(appUser10);

            ////set user role to admin
            //modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            //{
            //    RoleId = "a35c7eb1-a14a-4eed-9ec2-467127acedc1",
            //    UserId = "5afbcc5e-955a-4614-a3a3-ebcb5283c77c"
            //});
        }
    }
}

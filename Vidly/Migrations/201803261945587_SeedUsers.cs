namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'3ac6b5a5-fc46-4a1e-9139-3e97c9ad7128', N'guest@vidly.com', 1, N'AJe3ecmHjYcl+guKecw6ZRvppzeYUYDI5T8Ft2s2Hs7qok/8ZyqwnFGIier7jjPsQQ==', N'08db2ec6-c431-43a8-8ec9-c1abd690af62', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'a14d0480-096f-4996-8ffc-1f6681836573', N'admin@vidly.com', 1, N'AG6taf2NmoiquSo6YVq2BRfanLzexDDtneot0DrL3MLe0/3HREzzpT0PJ6iHigzjvw==', N'2e4d20c3-c170-42f1-9d0c-4fe2f5ab4c48', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'93e4c71f-5440-45f9-800c-8efed344e11d', N'CanManageMovie')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'a14d0480-096f-4996-8ffc-1f6681836573', N'93e4c71f-5440-45f9-800c-8efed344e11d')
");
        }
        
        public override void Down()
        {
        }
    }
}

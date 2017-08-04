namespace VidlyExample.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class seednewadminuser : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName], [DrivingLicense], [Phone]) VALUES (N'b55f2962-56a2-442e-8d2b-a47eca17ef6f', N'adminarsalon@vidly.com', 0, N'AKxRhq3wQwkfz44QtgXOb0kCxVEaqMWY9WiZEKvc4f2gEBTIyjFY2rpMNQYnBMq8wA==', N'f6020fc5-b290-4a5c-b707-2c9e22f6b0cd', NULL, 0, 0, NULL, 1, 0, N'adminarsalon@vidly.com', N'a445', N'4145526055')
INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'b41345f4-69cb-4387-86a5-7c602a5645e5', N'CanManageMovie')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'b55f2962-56a2-442e-8d2b-a47eca17ef6f', N'b41345f4-69cb-4387-86a5-7c602a5645e5')

");
        }
        
        public override void Down()
        {
        }
    }
}

namespace WebApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.VideoDatas", "chapterCode", c => c.String());
            AddColumn("dbo.VideoDatas", "classCode", c => c.String());
            AddColumn("dbo.VideoDatas", "SubjectCode", c => c.String());
            AddColumn("dbo.VideoDatas", "videoName", c => c.String());
            AddColumn("dbo.VideoDatas", "videoURL", c => c.String());
            AddColumn("dbo.VideoDatas", "videoDesc", c => c.String());
            AddColumn("dbo.VideoDatas", "videoTutor", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.VideoDatas", "videoTutor");
            DropColumn("dbo.VideoDatas", "videoDesc");
            DropColumn("dbo.VideoDatas", "videoURL");
            DropColumn("dbo.VideoDatas", "videoName");
            DropColumn("dbo.VideoDatas", "SubjectCode");
            DropColumn("dbo.VideoDatas", "classCode");
            DropColumn("dbo.VideoDatas", "chapterCode");
        }
    }
}

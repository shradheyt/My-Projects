namespace WebApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.VideoDatas", "ChapCode", c => c.String());
            DropColumn("dbo.VideoDatas", "chapterCode");
        }
        
        public override void Down()
        {
            AddColumn("dbo.VideoDatas", "chapterCode", c => c.String());
            DropColumn("dbo.VideoDatas", "ChapCode");
        }
    }
}

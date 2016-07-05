namespace WebApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Chapters",
                c => new
                    {
                        ChapterID = c.Int(nullable: false, identity: true),
                        ChapterName = c.String(),
                        ChapCode = c.String(),
                        ClassCode = c.String(),
                        SubCode = c.String(),
                    })
                .PrimaryKey(t => t.ChapterID);
            
            CreateTable(
                "dbo.VideoDatas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.VideoDatas");
            DropTable("dbo.Chapters");
        }
    }
}

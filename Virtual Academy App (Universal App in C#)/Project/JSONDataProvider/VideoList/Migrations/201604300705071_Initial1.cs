namespace VideoList.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.VideoDatas",
                c => new
                    {
                        VideoID = c.Int(nullable: false, identity: true),
                        VideoURL = c.String(),
                        ChapCode = c.String(),
                        SubCode = c.String(),
                        ClassCode = c.String(),
                        Title = c.String(),
                        Desc = c.String(),
                        Trainer = c.String(),
                    })
                .PrimaryKey(t => t.VideoID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.VideoDatas");
        }
    }
}

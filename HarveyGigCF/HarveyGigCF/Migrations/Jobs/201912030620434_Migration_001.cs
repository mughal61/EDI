namespace HarveyGigCF.Migrations.Jobs
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Migration_001 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Apps",
                c => new
                    {
                        AppId = c.Int(nullable: false, identity: true),
                        AppName = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.AppId);
            
            CreateTable(
                "dbo.Jobs",
                c => new
                    {
                        JobId = c.Int(nullable: false, identity: true),
                        Time = c.Time(precision: 7),
                        Day = c.String(),
                        Success = c.String(),
                        Files_DwUp = c.Int(),
                        Files_Sorted = c.Int(),
                        AppId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.JobId)
                .ForeignKey("dbo.Apps", t => t.AppId, cascadeDelete: true)
                .Index(t => t.AppId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Jobs", "AppId", "dbo.Apps");
            DropIndex("dbo.Jobs", new[] { "AppId" });
            DropTable("dbo.Jobs");
            DropTable("dbo.Apps");
        }
    }
}

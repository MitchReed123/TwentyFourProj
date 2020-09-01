namespace TwentyFourProj.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Test : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Post", "UserId", "dbo.User");
            DropIndex("dbo.Post", new[] { "UserId" });
        }
        
        public override void Down()
        {
            CreateIndex("dbo.Post", "UserId");
            AddForeignKey("dbo.Post", "UserId", "dbo.User", "Id", cascadeDelete: true);
        }
    }
}

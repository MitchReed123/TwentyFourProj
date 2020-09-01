namespace TwentyFourProj.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PostMigration : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Post", "Title", c => c.String());
            AlterColumn("dbo.Post", "Text", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Post", "Text", c => c.String(nullable: false));
            AlterColumn("dbo.Post", "Title", c => c.String(nullable: false));
        }
    }
}

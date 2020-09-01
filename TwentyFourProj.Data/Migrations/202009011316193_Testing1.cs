namespace TwentyFourProj.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Testing1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.User", "Name", c => c.String());
            AlterColumn("dbo.User", "Email", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.User", "Email", c => c.String(nullable: false));
            AlterColumn("dbo.User", "Name", c => c.String(nullable: false));
        }
    }
}

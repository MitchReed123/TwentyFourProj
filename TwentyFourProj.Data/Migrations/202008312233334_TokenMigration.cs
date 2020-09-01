namespace TwentyFourProj.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TokenMigration : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Post", name: "Author_Id", newName: "UserId");
            RenameIndex(table: "dbo.Post", name: "IX_Author_Id", newName: "IX_UserId");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Post", name: "IX_UserId", newName: "IX_Author_Id");
            RenameColumn(table: "dbo.Post", name: "UserId", newName: "Author_Id");
        }
    }
}

namespace TwentyFourProj.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedDbSets : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Like",
                c => new
                    {
                        LikedId = c.Int(nullable: false, identity: true),
                        LikedPost_Id = c.Int(),
                        Liker_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.LikedId)
                .ForeignKey("dbo.Post", t => t.LikedPost_Id)
                .ForeignKey("dbo.User", t => t.Liker_Id)
                .Index(t => t.LikedPost_Id)
                .Index(t => t.Liker_Id);
            
            CreateTable(
                "dbo.Comment",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Text = c.String(),
                        ReplyId = c.Int(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                        Author_Id = c.Guid(),
                        CommentPost_Id = c.Int(),
                        ReplyComment_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.User", t => t.Author_Id)
                .ForeignKey("dbo.Post", t => t.CommentPost_Id)
                .ForeignKey("dbo.Comment", t => t.ReplyComment_Id)
                .Index(t => t.Author_Id)
                .Index(t => t.CommentPost_Id)
                .Index(t => t.ReplyComment_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Comment", "ReplyComment_Id", "dbo.Comment");
            DropForeignKey("dbo.Comment", "CommentPost_Id", "dbo.Post");
            DropForeignKey("dbo.Comment", "Author_Id", "dbo.User");
            DropForeignKey("dbo.Like", "Liker_Id", "dbo.User");
            DropForeignKey("dbo.Like", "LikedPost_Id", "dbo.Post");
            DropIndex("dbo.Comment", new[] { "ReplyComment_Id" });
            DropIndex("dbo.Comment", new[] { "CommentPost_Id" });
            DropIndex("dbo.Comment", new[] { "Author_Id" });
            DropIndex("dbo.Like", new[] { "Liker_Id" });
            DropIndex("dbo.Like", new[] { "LikedPost_Id" });
            DropTable("dbo.Comment");
            DropTable("dbo.Like");
        }
    }
}

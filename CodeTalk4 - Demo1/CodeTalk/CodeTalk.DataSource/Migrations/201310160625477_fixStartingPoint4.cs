namespace CodeTalk.DataSource.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fixStartingPoint4 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Comments", "TalkId", "dbo.Talks");
            DropIndex("dbo.Comments", new[] { "TalkId" });
            AlterColumn("dbo.Comments", "Body", c => c.String());
            DropColumn("dbo.Comments", "Commentor");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Comments", "Commentor", c => c.String(nullable: false));
            AlterColumn("dbo.Comments", "Body", c => c.String(nullable: false));
            CreateIndex("dbo.Comments", "TalkId");
            AddForeignKey("dbo.Comments", "TalkId", "dbo.Talks", "Id", cascadeDelete: true);
        }
    }
}

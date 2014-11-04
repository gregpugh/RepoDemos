namespace CodeTalk.DataSource.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fixStartingPoint41 : DbMigration
    {
        public override void Up()
        {
            AddForeignKey("dbo.Comments", "TalkId", "dbo.Talks", "Id", cascadeDelete: true);
            CreateIndex("dbo.Comments", "TalkId");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Comments", new[] { "TalkId" });
            DropForeignKey("dbo.Comments", "TalkId", "dbo.Talks");
        }
    }
}

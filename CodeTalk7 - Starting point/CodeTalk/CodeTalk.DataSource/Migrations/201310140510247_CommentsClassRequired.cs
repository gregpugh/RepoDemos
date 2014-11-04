namespace CodeTalk.DataSource.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CommentsClassRequired : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Comments", "Body", c => c.String(nullable: false));
            AlterColumn("dbo.Comments", "Commentor", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Comments", "Commentor", c => c.String());
            AlterColumn("dbo.Comments", "Body", c => c.String());
        }
    }
}

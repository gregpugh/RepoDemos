namespace CodeTalk.DataSource.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CommentsClassAddCommentor : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Comments", "Commentor", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Comments", "Commentor");
        }
    }
}

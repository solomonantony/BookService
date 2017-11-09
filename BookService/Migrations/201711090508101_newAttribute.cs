namespace BookService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newAttribute : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Authors", "Year", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Authors", "Year");
        }
    }
}

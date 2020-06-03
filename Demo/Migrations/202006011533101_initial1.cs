namespace Demo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Book1", "Author", c => c.String());
            AddColumn("dbo.Book1", "Publisher", c => c.String());
            AddColumn("dbo.Book1", "Year", c => c.Long(nullable: false));
            AlterColumn("dbo.Book1", "ISBN", c => c.Long(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Book1", "ISBN", c => c.String());
            DropColumn("dbo.Book1", "Year");
            DropColumn("dbo.Book1", "Publisher");
            DropColumn("dbo.Book1", "Author");
        }
    }
}

namespace Demo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Book1",
                c => new
                    {
                        Title = c.String(nullable: false, maxLength: 128),
                        ISBN = c.String(),
                    })
                .PrimaryKey(t => t.Title);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Book1");
        }
    }
}

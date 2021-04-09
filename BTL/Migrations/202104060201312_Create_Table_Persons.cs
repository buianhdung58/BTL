namespace BTL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_Persons : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Persons",
                c => new
                    {
                        CCCD = c.String(nullable: false, maxLength: 128),
                        FullName = c.String(),
                    })
                .PrimaryKey(t => t.CCCD);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Persons");
        }
    }
}

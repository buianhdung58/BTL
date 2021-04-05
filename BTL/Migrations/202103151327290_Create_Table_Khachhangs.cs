namespace BTL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_Khachhangs : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Khachangs",
                c => new
                    {
                        TenKH = c.String(nullable: false, maxLength: 128),
                        MaKH = c.String(),
                        SdtKH = c.String(),
                        Diachi = c.String(),
                    })
                .PrimaryKey(t => t.TenKH);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Khachangs");
        }
    }
}

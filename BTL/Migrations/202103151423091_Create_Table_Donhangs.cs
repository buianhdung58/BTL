namespace BTL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_Donhangs : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Donhangs",
                c => new
                    {
                        MaDH = c.String(nullable: false, maxLength: 128),
                        GiatriDH = c.String(),
                        TinhtrangDH = c.String(),
                        Ghichu = c.String(),
                    })
                .PrimaryKey(t => t.MaDH);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Donhangs");
        }
    }
}

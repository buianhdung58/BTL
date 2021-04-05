namespace BTL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_Sanphams : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Sanphams",
                c => new
                    {
                        TenSP = c.String(nullable: false, maxLength: 128),
                        MaSP = c.String(),
                        LoaiSP = c.String(),
                        Mausac = c.String(),
                        GiaSP = c.String(),
                        Soluong = c.String(),
                    })
                .PrimaryKey(t => t.TenSP);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Sanphams");
        }
    }
}

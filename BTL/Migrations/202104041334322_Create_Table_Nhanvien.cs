namespace BTL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_Nhanvien : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Nhanviens",
                c => new
                    {
                        TenNV = c.String(nullable: false, maxLength: 128),
                        MaNV = c.String(),
                        SdtNV = c.String(),
                        email = c.String(),
                    })
                .PrimaryKey(t => t.TenNV);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Nhanviens");
        }
    }
}

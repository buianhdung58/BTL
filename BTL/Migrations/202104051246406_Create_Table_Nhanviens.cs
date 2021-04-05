namespace BTL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_Nhanviens : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Nhanviens");
            AlterColumn("dbo.Nhanviens", "TenNV", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.Nhanviens", "TenNV");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Nhanviens");
            AlterColumn("dbo.Nhanviens", "TenNV", c => c.String(nullable: false, maxLength: 20));
            AddPrimaryKey("dbo.Nhanviens", "TenNV");
        }
    }
}

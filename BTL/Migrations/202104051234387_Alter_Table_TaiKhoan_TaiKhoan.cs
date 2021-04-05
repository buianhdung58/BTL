namespace BTL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Alter_Table_TaiKhoan_TaiKhoan : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.TaiKhoans");
            AlterColumn("dbo.TaiKhoans", "Tendangnhap", c => c.String(nullable: false, maxLength: 20, fixedLength: true, unicode: false));
            AddPrimaryKey("dbo.TaiKhoans", "Tendangnhap");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.TaiKhoans");
            AlterColumn("dbo.TaiKhoans", "Tendangnhap", c => c.String(nullable: false, maxLength: 128, fixedLength: true, unicode: false));
            AddPrimaryKey("dbo.TaiKhoans", "Tendangnhap");
        }
    }
}

namespace BTL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_Nhanvien1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Persons", "NhanvienID", c => c.String());
            AddColumn("dbo.Persons", "Congty", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Persons", "Congty");
            DropColumn("dbo.Persons", "NhanvienID");
        }
    }
}

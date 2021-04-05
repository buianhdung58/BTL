namespace BTL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add_Column_Nhanviens_Vitri : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Nhanviens", "Vitri", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Nhanviens", "Vitri");
        }
    }
}

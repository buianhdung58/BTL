namespace BTL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_table_Khanhhang : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Khachangs", "Tuoi");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Khachangs", "Tuoi", c => c.Int(nullable: false));
        }
    }
}

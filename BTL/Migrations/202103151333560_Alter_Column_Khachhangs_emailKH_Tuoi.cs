namespace BTL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Alter_Column_Khachhangs_emailKH_Tuoi : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Khachangs", "Tuoi", c => c.Int(nullable: false));
            DropColumn("dbo.Khachangs", "emailKH");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Khachangs", "emailKH", c => c.String());
            DropColumn("dbo.Khachangs", "Tuoi");
        }
    }
}

namespace BTL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add_Column_Khachhangs_emailKH : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Khachangs", "emailKH", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Khachangs", "emailKH");
        }
    }
}

namespace BTL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class admn : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Accounts", "Password", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Accounts", "Password", c => c.String());
        }
    }
}

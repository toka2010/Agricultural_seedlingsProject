namespace Agricultural_seedlingsProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v32 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Volunters", "ProductName", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Volunters", "ProductName", c => c.String());
        }
    }
}

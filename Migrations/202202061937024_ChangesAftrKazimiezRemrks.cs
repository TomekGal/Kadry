namespace Kadry.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangesAftrKazimiezRemrks : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Employees", "Salary", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.Employees", "StartDate", c => c.DateTime(precision: 7, storeType: "datetime2"));
            AlterColumn("dbo.Employees", "EndDate", c => c.DateTime(precision: 7, storeType: "datetime2"));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Employees", "EndDate", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2"));
            AlterColumn("dbo.Employees", "StartDate", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2"));
            AlterColumn("dbo.Employees", "Salary", c => c.Int(nullable: false));
        }
    }
}

namespace EmployeeAdmin.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EmployeeMaritalStatusEdit : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Employees", "MarialStatus", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Employees", "MarialStatus", c => c.String(nullable: false));
        }
    }
}

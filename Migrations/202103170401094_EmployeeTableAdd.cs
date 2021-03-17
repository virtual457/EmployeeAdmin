namespace EmployeeAdmin.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EmployeeTableAdd : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        ID = c.Long(nullable: false, identity: true),
                        Salutation = c.String(nullable: false),
                        FirstName = c.String(nullable: false),
                        MiddleName = c.String(),
                        LastName = c.String(),
                        Gender = c.String(nullable: false),
                        MarialStatus = c.String(nullable: false),
                        DateOfBirth = c.DateTime(),
                        Age = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CareofGuardian = c.String(),
                        GuardianName = c.String(),
                        EmailID = c.String(),
                        CallingNumber = c.String(nullable: false, maxLength: 10),
                        WhatsappNumber = c.String(nullable: false, maxLength: 10),
                        Address = c.String(nullable: false),
                        City = c.String(nullable: false),
                        PinCode = c.String(nullable: false, maxLength: 6),
                        AadhaarID = c.String(maxLength: 13),
                        Occupation = c.String(),
                        Status = c.String(),
                        DateCreated = c.DateTime(nullable: false),
                        LastModified = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Employees");
        }
    }
}

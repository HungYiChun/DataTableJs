namespace DataTables.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitDataTableDb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        EmployeeId = c.Int(nullable: false, identity: true),
                        LastName = c.String(nullable: false, maxLength: 256),
                        FirstName = c.String(nullable: false, maxLength: 256),
                        Title = c.String(maxLength: 256),
                        TitleOfCourtesy = c.String(maxLength: 256),
                        BirthDate = c.DateTime(),
                        HireDate = c.DateTime(),
                        Address = c.String(maxLength: 256),
                        City = c.String(maxLength: 256),
                        Region = c.String(maxLength: 256),
                        PostalCode = c.String(maxLength: 256),
                        Country = c.String(maxLength: 256),
                        HomePhone = c.String(maxLength: 256),
                        Extension = c.String(maxLength: 256),
                        Notes = c.String(),
                        ReportsTo = c.Int(),
                        PhotoPath = c.String(maxLength: 256),
                    })
                .PrimaryKey(t => t.EmployeeId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Employees");
        }
    }
}

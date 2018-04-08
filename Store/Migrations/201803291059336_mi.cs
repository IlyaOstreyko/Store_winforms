namespace Store.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mi : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name_customer = c.String(),
                        Requisites_customer = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CustomerId = c.Int(),
                        Date_request = c.DateTime(nullable: false),
                        Name_production = c.String(),
                        Price_producer = c.String(),
                        Price = c.String(),
                        Payment = c.String(),
                        Date_delivery = c.DateTime(nullable: false),
                        StatusPayment = c.String(),
                        Status = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Producers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name_producer = c.String(),
                        Requisites_producer = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Producers");
            DropTable("dbo.Orders");
            DropTable("dbo.Customers");
        }
    }
}

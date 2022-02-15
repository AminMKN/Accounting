namespace Accounting.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TablesAdded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PrintBreakDowns",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Code = c.String(),
                        Name = c.String(),
                        Color = c.String(),
                        Size = c.String(),
                        Qty = c.String(),
                        PercentBreakDown = c.String(),
                        Description = c.String(),
                        Date = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Projects",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Code = c.String(),
                        Name = c.String(),
                        Customer = c.String(),
                        Date = c.String(),
                        Qty = c.String(),
                        BarCode = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.RemainingReports",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Code = c.String(),
                        Name = c.String(),
                        Color = c.String(),
                        Size = c.String(),
                        Qty = c.String(),
                        Percentage = c.String(),
                        Type = c.String(),
                        Description = c.String(),
                        Date = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SewingBreakDowns",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Code = c.String(),
                        Name = c.String(),
                        Color = c.String(),
                        Size = c.String(),
                        Qty = c.String(),
                        PercentBreakDown = c.String(),
                        Description = c.String(),
                        Date = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.SewingBreakDowns");
            DropTable("dbo.RemainingReports");
            DropTable("dbo.Projects");
            DropTable("dbo.PrintBreakDowns");
        }
    }
}

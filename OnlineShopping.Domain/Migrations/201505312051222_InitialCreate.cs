using System.Data.Entity.Migrations;

namespace OnlineShopping.Domain.Migrations
{
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ProductId = c.Int(false, true),
                        Name = c.String(),
                        Description = c.String(),
                        Price = c.Decimal(false, 18, 2),
                        Category = c.String()
                    })
                .PrimaryKey(t => t.ProductId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Products");
        }
    }
}

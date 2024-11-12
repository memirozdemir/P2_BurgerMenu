namespace P2_BurgerMenu.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig14 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Products", "ProductSold", c => c.Int(nullable: true));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Products", "ProductSold", c => c.String());
        }
    }
}

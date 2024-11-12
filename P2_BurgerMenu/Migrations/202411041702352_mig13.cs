﻿namespace P2_BurgerMenu.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig13 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "ProductSold", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "ProductSold");
        }
    }
}

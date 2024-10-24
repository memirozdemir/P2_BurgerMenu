﻿namespace P2_BurgerMenu.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig5 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "DealofTheDay", c => c.Boolean());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "DealofTheDay");
        }
    }
}

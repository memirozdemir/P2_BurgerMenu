namespace P2_BurgerMenu.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig6 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.DealOfTheDays", "DealofTheDay");
        }
        
        public override void Down()
        {
            AddColumn("dbo.DealOfTheDays", "DealofTheDay", c => c.Boolean());
        }
    }
}

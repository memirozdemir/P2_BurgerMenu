namespace P2_BurgerMenu.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig4 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.DealOfTheDays", "DealofTheDay", c => c.Boolean());
        }
        
        public override void Down()
        {
            DropColumn("dbo.DealOfTheDays", "DealofTheDay");
        }
    }
}

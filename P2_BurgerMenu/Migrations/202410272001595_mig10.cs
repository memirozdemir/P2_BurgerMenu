namespace P2_BurgerMenu.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig10 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Abouts", "PictureURL", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Abouts", "PictureURL");
        }
    }
}

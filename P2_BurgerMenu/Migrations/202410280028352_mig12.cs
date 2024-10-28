namespace P2_BurgerMenu.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig12 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CreditCards",
                c => new
                    {
                        CreditCardID = c.Int(nullable: false, identity: true),
                        CardNO = c.String(),
                        CardOwner = c.String(),
                        CardExpDate = c.String(),
                        CardCVC = c.String(),
                    })
                .PrimaryKey(t => t.CreditCardID);
            
            CreateTable(
                "dbo.SocialMedias",
                c => new
                    {
                        SocialMediaID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Icon = c.String(),
                        URL = c.String(),
                    })
                .PrimaryKey(t => t.SocialMediaID);
            
            CreateTable(
                "dbo.Subscribers",
                c => new
                    {
                        SubscriberID = c.Int(nullable: false, identity: true),
                        Gmail = c.String(),
                        SubDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.SubscriberID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Subscribers");
            DropTable("dbo.SocialMedias");
            DropTable("dbo.CreditCards");
        }
    }
}

namespace P2_BurgerMenu.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig11 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Contacts",
                c => new
                    {
                        ContactID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Email = c.String(),
                        Message = c.String(),
                        SendDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ContactID);
            
            CreateTable(
                "dbo.Galleries",
                c => new
                    {
                        GalleryID = c.Int(nullable: false, identity: true),
                        PictureURL = c.String(),
                    })
                .PrimaryKey(t => t.GalleryID);
            
            AddColumn("dbo.Abouts", "Address", c => c.String());
            AddColumn("dbo.Abouts", "Phone", c => c.String());
            AddColumn("dbo.Abouts", "Mail", c => c.String());
            AddColumn("dbo.Abouts", "LocationURL", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Abouts", "LocationURL");
            DropColumn("dbo.Abouts", "Mail");
            DropColumn("dbo.Abouts", "Phone");
            DropColumn("dbo.Abouts", "Address");
            DropTable("dbo.Galleries");
            DropTable("dbo.Contacts");
        }
    }
}

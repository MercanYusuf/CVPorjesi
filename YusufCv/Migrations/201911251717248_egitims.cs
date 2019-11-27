namespace YusufCv.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class egitims : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Eğitim Bilgiler", "Tarih");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Eğitim Bilgiler", "Tarih", c => c.DateTime(nullable: false));
        }
    }
}

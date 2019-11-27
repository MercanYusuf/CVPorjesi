namespace YusufCv.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class egitim : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Eğitim Bilgiler", "Tarih", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Eğitim Bilgiler", "Tarih");
        }
    }
}

namespace YusufCv.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class admins : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Admin",
                c => new
                    {
                        AdminId = c.Int(nullable: false, identity: true),
                        Eposta = c.String(nullable: false),
                        Sifre = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.AdminId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Admin");
        }
    }
}

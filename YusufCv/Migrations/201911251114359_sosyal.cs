namespace YusufCv.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class sosyal : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Programlama Dilleri",
                c => new
                    {
                        ProgramlamaId = c.Int(nullable: false, identity: true),
                        Programalama = c.String(),
                    })
                .PrimaryKey(t => t.ProgramlamaId);
            
            AlterColumn("dbo.Sosyal Medya", "Email", c => c.String(maxLength: 150));
            AlterColumn("dbo.Sosyal Medya", "Linked", c => c.String(maxLength: 150));
            AlterColumn("dbo.Sosyal Medya", "GitHub", c => c.String(maxLength: 150));
            AlterColumn("dbo.Sosyal Medya", "Twitter", c => c.String(maxLength: 150));
            AlterColumn("dbo.Sosyal Medya", "Facebook", c => c.String(maxLength: 150));
            AlterColumn("dbo.Sosyal Medya", "Instagram", c => c.String(maxLength: 150));
            DropTable("dbo.Kariyer");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Kariyer",
                c => new
                    {
                        KariyerId = c.Int(nullable: false, identity: true),
                        KariyerAciklama = c.String(),
                    })
                .PrimaryKey(t => t.KariyerId);
            
            AlterColumn("dbo.Sosyal Medya", "Instagram", c => c.String(maxLength: 50));
            AlterColumn("dbo.Sosyal Medya", "Facebook", c => c.String(maxLength: 50));
            AlterColumn("dbo.Sosyal Medya", "Twitter", c => c.String(maxLength: 50));
            AlterColumn("dbo.Sosyal Medya", "GitHub", c => c.String(maxLength: 50));
            AlterColumn("dbo.Sosyal Medya", "Linked", c => c.String(maxLength: 50));
            AlterColumn("dbo.Sosyal Medya", "Email", c => c.String(maxLength: 50));
            DropTable("dbo.Programlama Dilleri");
        }
    }
}

namespace YusufCv.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class deneyim : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Deneyimler", "SertifikaAciklama", c => c.String());
            AlterColumn("dbo.Deneyimler", "DeneyimAciklama", c => c.String());
            DropColumn("dbo.Deneyimler", "SertifikaAciklana");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Deneyimler", "SertifikaAciklana", c => c.String());
            AlterColumn("dbo.Deneyimler", "DeneyimAciklama", c => c.Int(nullable: false));
            DropColumn("dbo.Deneyimler", "SertifikaAciklama");
        }
    }
}

namespace YusufCv.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class deneyimad : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Deneyimler", "DeneyimAd", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Deneyimler", "DeneyimAd", c => c.Int(nullable: false));
        }
    }
}

namespace YusufCv.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class unvan : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Kişisel Kimlik", "Unvan", c => c.String(maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Kişisel Kimlik", "Unvan", c => c.String(maxLength: 20));
        }
    }
}

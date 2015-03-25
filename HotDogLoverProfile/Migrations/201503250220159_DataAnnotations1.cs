namespace HotDogLoverProfile.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DataAnnotations1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Profiles", "LastAte", c => c.String(nullable: false));
            AlterColumn("dbo.Profiles", "EatenDate", c => c.String(nullable: false));
            AlterColumn("dbo.Profiles", "PastDog1", c => c.String(nullable: false));
            AlterColumn("dbo.Profiles", "PastDog2", c => c.String(nullable: false));
            AlterColumn("dbo.Profiles", "PastDog3", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Profiles", "PastDog3", c => c.String());
            AlterColumn("dbo.Profiles", "PastDog2", c => c.String());
            AlterColumn("dbo.Profiles", "PastDog1", c => c.String());
            AlterColumn("dbo.Profiles", "EatenDate", c => c.String());
            AlterColumn("dbo.Profiles", "LastAte", c => c.String());
        }
    }
}

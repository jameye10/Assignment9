namespace HotDogLoverProfile.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DataAnnotations : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Profiles", "FavoriteDog", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Profiles", "FavoriteDog", c => c.String());
        }
    }
}

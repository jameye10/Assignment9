namespace HotDogLoverProfile.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Profiles",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        FavoriteDog = c.String(),
                        LastAte = c.String(),
                        EatenDate = c.String(),
                        PastDog1 = c.String(),
                        PastDog2 = c.String(),
                        PastDog3 = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Profiles");
        }
    }
}

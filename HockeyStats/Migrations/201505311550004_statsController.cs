namespace HockeyStats.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class statsController : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Stats",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        GamesPlayed = c.Int(nullable: false),
                        Goals = c.Int(nullable: false),
                        Wins = c.Int(nullable: false),
                        Losses = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Stats");
        }
    }
}

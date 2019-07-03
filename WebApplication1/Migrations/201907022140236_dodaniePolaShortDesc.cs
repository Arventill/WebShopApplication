namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dodaniePolaShortDesc : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Cake", "shortDesc", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Cake", "shortDesc");
        }
    }
}

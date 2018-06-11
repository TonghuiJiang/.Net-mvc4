namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Genres : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres (Id, Name) Values (1, 'Action')");
            
        }
        
        public override void Down()
        {
        }
    }
}

namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMovies1 : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT Movies ON");
            Sql("INSERT INTO Movies (Id, Name, GenreId, ReleaseDate, DateAdded, NumberInStock) VALUES (2, 'Die Hard', 2, '2005-11-06', '2012-05-04', 6)");
            Sql("INSERT INTO Movies (Id, Name, GenreId, ReleaseDate, DateAdded, NumberInStock) VALUES (3, 'The Terminator', 3, '2002-11-06', '2009-05-04', 2)");
            Sql("SET IDENTITY_INSERT Movies OFF");
        }
        
        public override void Down()
        {
        }
    }
}

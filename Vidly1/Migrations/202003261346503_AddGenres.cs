namespace Vidly1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddGenres : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT Genres ON INSERT INTO Genres (Id,Name) VALUES (1,'Romantic')");
            Sql("SET IDENTITY_INSERT Genres ON INSERT INTO Genres (Id,Name) VALUES (2,'Action')");
            Sql("SET IDENTITY_INSERT Genres ON INSERT INTO Genres (Id,Name) VALUES (3,'Comedy')");
            Sql("SET IDENTITY_INSERT Genres ON INSERT INTO Genres (Id,Name) VALUES (4,'Thriller')");
            Sql("SET IDENTITY_INSERT Genres ON INSERT INTO Genres (Id,Name) VALUES (5,'Haunted')");
        }
        
        public override void Down()
        {
        }
    }
}

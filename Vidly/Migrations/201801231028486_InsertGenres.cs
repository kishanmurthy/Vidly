namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InsertGenres : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO GENRES (NAME) VALUES('Action')");
            Sql("INSERT INTO GENRES (NAME) VALUES('Adventure')");
            Sql("INSERT INTO GENRES (NAME) VALUES('Comedy')");
            Sql("INSERT INTO GENRES (NAME) VALUES('Crime')");
            Sql("INSERT INTO GENRES (NAME) VALUES('Drama')");
            Sql("INSERT INTO GENRES (NAME) VALUES('Fantasy')");
            Sql("INSERT INTO GENRES (NAME) VALUES('Historical')");
            Sql("INSERT INTO GENRES (NAME) VALUES('Historical fiction')");
            Sql("INSERT INTO GENRES (NAME) VALUES('Horror')");
            Sql("INSERT INTO GENRES (NAME) VALUES('Magical realism')");
            Sql("INSERT INTO GENRES (NAME) VALUES('Mystery')");
            Sql("INSERT INTO GENRES (NAME) VALUES('Paranoid')");
            Sql("INSERT INTO GENRES (NAME) VALUES('Philosophical')");
            Sql("INSERT INTO GENRES (NAME) VALUES('Political')");
            Sql("INSERT INTO GENRES (NAME) VALUES('Romance')");
            Sql("INSERT INTO GENRES (NAME) VALUES('Saga')");
            Sql("INSERT INTO GENRES (NAME) VALUES('Satire')");
            Sql("INSERT INTO GENRES (NAME) VALUES('Science fiction')");
            Sql("INSERT INTO GENRES (NAME) VALUES('Slice of Life')");
            Sql("INSERT INTO GENRES (NAME) VALUES('Social')");
            Sql("INSERT INTO GENRES (NAME) VALUES('Speculative')");
            Sql("INSERT INTO GENRES (NAME) VALUES('Surreal')");
            Sql("INSERT INTO GENRES (NAME) VALUES('Thriller')");
            Sql("INSERT INTO GENRES (NAME) VALUES('Urban')");
            Sql("INSERT INTO GENRES (NAME) VALUES('Western')");


        }

        public override void Down()
        {
        }
    }
}

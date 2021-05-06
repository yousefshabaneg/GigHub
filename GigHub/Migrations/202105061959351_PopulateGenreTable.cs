namespace GigHub.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class PopulateGenreTable : DbMigration
    {
        public override void Up()
        {
            Sql("insert into genres (id, name) values (1, 'Jazz')");
            Sql("insert into genres (id, name) values (2, 'Blues')");
            Sql("insert into genres (id, name) values (3, 'Rock')");
            Sql("insert into genres (id, name) values (4, 'Country')");
        }
        
        public override void Down()
        {
            Sql("DELETE FROM genres WHERE id in (1, 2, 3, 4)");
        }
    }
}

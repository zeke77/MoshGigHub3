namespace MoshGigHub3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenresTable : DbMigration
    {
        public override void Up()
        {
            Sql("Insert Into Genres(Id,Name) Values (1,'Jazz')");
            Sql("Insert Into Genres(Id,Name) Values (2,'Blues')");
            Sql("Insert Into Genres(Id,Name) Values (3,'Rock')");
            Sql("Insert Into Genres(Id,Name) Values (4,'Country')");

        }

        public override void Down()
        {
            Sql("Delete from Genres where Id in (1,2,3,4)");
        }
    }
}

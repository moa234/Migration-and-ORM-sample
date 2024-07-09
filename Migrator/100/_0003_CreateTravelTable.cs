namespace Migrator._100;

[Migration(0003)]
public class _0003_CreateTravelTable : AutoReversingMigration
{
    public override void Up()
    {
        Create.Table("Travel")
            .WithColumn("Id").AsInt32().PrimaryKey().Identity()
            .WithColumn("UserId").AsInt32().NotNullable().ForeignKey("User", "Id")
            .WithColumn("LocationId").AsInt32().NotNullable().ForeignKey("Locations", "Id")
            .WithColumn("DepartureDate").AsDateTime().NotNullable();
    }
}
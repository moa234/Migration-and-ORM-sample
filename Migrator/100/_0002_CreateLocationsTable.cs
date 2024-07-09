namespace Migrator._100;

[Migration(0002)]
public class _0002_CreateLocationsTable : AutoReversingMigration
{
    public override void Up()
    {
        Create.Table("Locations")
            .WithColumn("Id").AsInt32().PrimaryKey().Identity()
            .WithColumn("Name").AsString(255).NotNullable()
            .WithColumn("Description").AsString(1000).Nullable()
            .WithColumn("Address").AsString(255).NotNullable()
            .WithColumn("City").AsString(255).NotNullable()
            .WithColumn("State").AsString(255).NotNullable()
            .WithColumn("Zip").AsString(10).NotNullable()
            .WithColumn("Country").AsString(255).NotNullable();
    }
}
using FluentMigrator;

namespace GSI.Migrations.DefaultDB
{
    [Migration(20171105173600)]
    public class DefaultDB_20171105_173600_Customization : AutoReversingMigration
    {
        public override void Up()
        {

            this.CreateTableWithId32("Settings", "SettingId", s => s
                .WithColumn("SettingKey").AsString(255).NotNullable()
                .WithColumn("SettingValue").AsString(255).Nullable().WithDefaultValue(null));

            Create.Index("UQ_Settings_UID_SettingKey")
                .OnTable("Settings")
                .OnColumn("SettingKey").Ascending()
                .WithOptions().Unique();
            
        }
    }
}
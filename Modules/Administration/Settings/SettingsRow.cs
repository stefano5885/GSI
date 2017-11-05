
namespace GSI.Administration.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("Default"), TableName("Settings")]
    [DisplayName("Settings"), InstanceName("Settings"), TwoLevelCached]
    [ReadPermission(PermissionKeys.Settings)]
    [ModifyPermission(PermissionKeys.Settings)]
    public sealed class SettingsRow : Row, IIdRow, INameRow
    {
        [DisplayName("Setting Id"), Identity]
        public Int32? SettingId
        {
            get { return Fields.SettingId[this]; }
            set { Fields.SettingId[this] = value; }
        }

        [DisplayName("Setting Key"), NotNull, QuickSearch]
        public String SettingKey
        {
            get { return Fields.SettingKey[this]; }
            set { Fields.SettingKey[this] = value; }
        }

        [DisplayName("Setting Value")]
        public String SettingValue
        {
            get { return Fields.SettingValue[this]; }
            set { Fields.SettingValue[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.SettingId; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.SettingKey; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public SettingsRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field SettingId;
            public StringField SettingKey;
            public StringField SettingValue;

            public RowFields()
                : base()
            {
                LocalTextPrefix = "Administration.Settings";
            }
        }
    }
}

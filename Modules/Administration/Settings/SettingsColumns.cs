
namespace GSI.Administration.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("Administration.Settings")]
    [BasedOnRow(typeof(Entities.SettingsRow))]
    public class SettingsColumns
    {
        //[EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        //public Int32 SettingId { get; set; }
        [EditLink]
        public String SettingKey { get; set; }
        public String SettingValue { get; set; }
    }
}
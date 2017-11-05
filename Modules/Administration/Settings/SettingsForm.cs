
namespace GSI.Administration.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("Administration.Settings")]
    [BasedOnRow(typeof(Entities.SettingsRow))]
    public class SettingsForm
    {
        public String SettingKey { get; set; }
        public String SettingValue { get; set; }
    }
}
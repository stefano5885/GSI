namespace GSI.Administration {
    export class SettingsForm extends Serenity.PrefixedContext {
        static formKey = 'Administration.Settings';

    }

    export interface SettingsForm {
        SettingKey: Serenity.StringEditor;
        SettingValue: Serenity.StringEditor;
    }

    [['SettingKey', () => Serenity.StringEditor], ['SettingValue', () => Serenity.StringEditor]].forEach(x => Object.defineProperty(SettingsForm.prototype, <string>x[0], { get: function () { return this.w(x[0], (x[1] as any)()); }, enumerable: true, configurable: true }));
}

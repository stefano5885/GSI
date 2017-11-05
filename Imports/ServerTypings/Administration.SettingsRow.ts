namespace GSI.Administration {
    export interface SettingsRow {
        SettingId?: number;
        SettingKey?: string;
        SettingValue?: string;
    }

    export namespace SettingsRow {
        export const idProperty = 'SettingId';
        export const nameProperty = 'SettingKey';
        export const localTextPrefix = 'Administration.Settings';

        export namespace Fields {
            export declare const SettingId: string;
            export declare const SettingKey: string;
            export declare const SettingValue: string;
        }

        [
            'SettingId', 
            'SettingKey', 
            'SettingValue'
        ].forEach(x => (<any>Fields)[x] = x);
    }
}

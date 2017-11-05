/// <reference path="../Common/Helpers/LanguageList.ts" />

namespace GSI.ScriptInitialization {
    Q.Config.responsiveDialogs = true;
    Q.Config.rootNamespaces.push('GSI');
    Serenity.EntityDialog.defaultLanguageList = LanguageList.getValue;
}
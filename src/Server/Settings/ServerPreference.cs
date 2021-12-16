﻿using System.Linq;
using JPBlazor.Shared.Constants.Localization;
using JPBlazor.Shared.Settings;

namespace JPBlazor.Server.Settings
{
    public record ServerPreference : IPreference
    {
        public string LanguageCode { get; set; } = LocalizationConstants.SupportedLanguages.FirstOrDefault()?.Code ?? "en-US";

        //TODO - add server preferences
    }
}
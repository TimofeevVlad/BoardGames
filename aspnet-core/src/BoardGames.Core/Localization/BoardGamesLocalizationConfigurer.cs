using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace BoardGames.Localization
{
    public static class BoardGamesLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(BoardGamesConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(BoardGamesLocalizationConfigurer).GetAssembly(),
                        "BoardGames.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}

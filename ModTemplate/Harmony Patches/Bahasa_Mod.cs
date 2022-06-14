using BokuMono;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace PootModHelper.Api
{
    /// <summary>
    /// Extension methods for <see cref="LocalizeTextProvider"/>.
    /// </summary>
    public static class LocalizeTextProviderExtensions
    {
        /// <summary>
        /// Returns a List containing all TextData for the provided <see cref="LocalizeTextTableType"/>.
        /// </summary>
        /// <param name="textProvider"></param>
        /// <param name="tableType"></param>
        /// <returns></returns>
        public static List<LocalizeTextData> GetLocalizeTextData(this LocalizeTextProvider textProvider, LocalizeTextTableType tableType)
        {
            var textTable = textProvider.GetTextTable(LocalizeTextTableType.ActionGuideText);
            return textTable?.list;
        }
    }
}

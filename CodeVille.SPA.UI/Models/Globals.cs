using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeVille.SPA.UI.Models
{
    public static class Globals
    {
        public enum Language
        {
            TR,
            EN
        }
        public enum VocabularyKeys
        {
            DisplayName_UserName,
            DisplayName_Password,
            DisplayName_ConfirmPassword,
            ErrorMessage_UserName,
            ErrorMessage_Password,
            ErrorMessage_ConfirmPassword
        }
        public static Dictionary<Language, Dictionary<VocabularyKeys, string>> AppVocabulary =
            new Dictionary<Language, Dictionary<VocabularyKeys, string>> 
            {
                {
                    Language.EN, 
                    new Dictionary<VocabularyKeys, string>
                    {
                        { VocabularyKeys.DisplayName_UserName, "User name" },
                        { VocabularyKeys.DisplayName_Password, "Password" },
                        { VocabularyKeys.DisplayName_ConfirmPassword, "Confirm Password" },
                        { VocabularyKeys.ErrorMessage_UserName, "Username must be at least 6 chars long" },
                        { VocabularyKeys.ErrorMessage_Password, "Password is required" },
                        { VocabularyKeys.ErrorMessage_ConfirmPassword, "Passwords do not match" }
                    }
                }
            };
    }
}
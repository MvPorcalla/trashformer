using System.Collections;
using UnityEngine;
using UnityEngine.Localization.Settings;

public class LocaleSelector : MonoBehaviour
{
    private bool _active = false;

    private const string SelectedLocaleKey = "SelectedLocale";

    private void Awake()
    {
        // Load the previously selected locale from PlayerPrefs if it exists.
        if (PlayerPrefs.HasKey(SelectedLocaleKey))
        {
            int savedLocaleID = PlayerPrefs.GetInt(SelectedLocaleKey);
            ChangeLocale(savedLocaleID);
        }
    }

    public void ChangeLocale(int localeID)
    {
        if (_active)
        {
            return;
        }

        StartCoroutine(SetLocale(localeID));
    }

    private IEnumerator SetLocale(int localeID)
    {
        _active = true;
        yield return LocalizationSettings.InitializationOperation;
        LocalizationSettings.SelectedLocale = LocalizationSettings.AvailableLocales.Locales[localeID];
        _active = false;

        // Save the selected locale ID to PlayerPrefs.
        PlayerPrefs.SetInt(SelectedLocaleKey, localeID);
        PlayerPrefs.Save();
    }
}

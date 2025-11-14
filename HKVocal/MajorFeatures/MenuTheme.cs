using UnityEngine;
using Modding;
using UnityEngine.Audio;

namespace HKVocals.MajorFeatures
{
    public class MenuTheme : MonoBehaviour
    {
        static MenuTheme()
        {
            // Non registra nulla
        }

        private static string ModHooks_LanguageGetHook(string key, string sheetTitle, string orig)
        {
            return orig;
        }

        public static (string, GameObject, int, string, string[], MenuStyles.MenuStyle.CameraCurves, AudioMixerSnapshot)
            AddTheme(MenuStyles self)
        {
            // Restituisci un tema vuoto e non usato
            return ("", null, 0, "", null, null, null);
        }

        private void OnEnable() { }
        private void OnDisable() { }
        private System.Collections.IEnumerator Start() { yield break; }
    }
}

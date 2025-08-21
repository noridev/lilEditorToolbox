using UnityEditor;

namespace moe.noridev.editortoolbox
{
    [FilePath("ProjectSettings/moe.noridev.editortoolbox.asset", FilePathAttribute.Location.ProjectFolder)]
    internal class EditorToolboxSettingsProject : ScriptableSingleton<EditorToolboxSettingsProject>
    {
        public string settingPreset;
        internal static void Save() => instance.Save(true);
    }
}

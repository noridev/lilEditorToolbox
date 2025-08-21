using System;
using UnityEditor;

namespace moe.noridev.editortoolbox
{
    internal class EditorUtilityWrap : WrapBase
    {
        private static readonly Type type = typeof(EditorUtility);
        internal static readonly Action Internal_UpdateAllMenus = GetAction(type, "Internal_UpdateAllMenus");
    }
}

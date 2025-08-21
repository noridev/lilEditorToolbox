using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace moe.noridev.editortoolbox
{
    [FilePath("./moe.noridev.editortoolbox.SelectionInventoryData.asset", FilePathAttribute.Location.ProjectFolder)]
    internal class SelectionInventoryData : ScriptableSingleton<SelectionInventoryData>
    {
        public List<Object> objects = new();
        internal void Save() => Save(true);
    }
}

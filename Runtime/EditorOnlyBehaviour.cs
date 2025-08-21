using UnityEngine;

namespace moe.noridev.editortoolbox.runtime
{
    public abstract class EditorOnlyBehaviour : MonoBehaviour
    #if LIL_VRCSDK3
    , VRC.SDKBase.IEditorOnly
    #endif
    {
    }
}

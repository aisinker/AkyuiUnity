using UnityEngine;

namespace AkyuiUnity.Generator.InternalTrigger
{
    public interface IAkyuiGenerateTrigger
    {
        Component CreateComponent(GameObject gameObject, IComponent component, IAssetLoader assetLoader);
        void OnPostprocessGameObject(GameObject gameObject);
        void OnPostprocessComponent(GameObject gameObject, IComponent component);
    }
}
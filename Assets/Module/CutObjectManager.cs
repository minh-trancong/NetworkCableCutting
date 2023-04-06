using UnityEngine;

namespace Module
{
    
    public class CutObjectManager : ICutObjectManager
    {
        public void SetActive(GameObject obj, bool isActive)
        {
            obj.SetActive(isActive);
        }

        public void SetPosition(GameObject obj, GameObject position)
        {
            obj.transform.position = position.transform.position;
            obj.transform.rotation = position.transform.rotation;
        }
    }
}

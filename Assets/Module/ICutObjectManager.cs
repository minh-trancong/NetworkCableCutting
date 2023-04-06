using UnityEngine;

public interface ICutObjectManager
{
    void SetActive(GameObject obj, bool isActive);
    void SetPosition(GameObject obj, GameObject position);
}
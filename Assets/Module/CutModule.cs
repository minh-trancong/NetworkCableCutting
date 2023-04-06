using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

namespace Module

{
    public class CutObjectInfo
    {
        public GameObject cutObject;
        public GameObject position;
        public bool isActive;
    }

    public class CutModule : MonoBehaviour
    {
        [ItemCanBeNull] public List<CutObjectInfo> listgame = new List<CutObjectInfo>();
        private readonly CutObjectManager _cutObjectManager = new CutObjectManager();
        public new string tag;
    }
    //     private void Start()
    //     {
    //         foreach (CutObjectInfo objInfo in CutObjects)
    //         {
    //             _cutObjectManager.SetActive(objInfo.cutObject, !objInfo.isActive);
    //         }
    //     }
    //
    //     private void OnTriggerStay(Collider other)
    //     {
    //         if (!other.CompareTag(tag) || !InputDevicesManagement.Instance.IsTriggerPressed()) return;
    //         foreach (var objInfo in CutObjects)
    //         {
    //             _cutObjectManager.SetPosition(objInfo.cutObject, objInfo.position);
    //             _cutObjectManager.SetActive(objInfo.cutObject, objInfo.isActive);
    //         }
    //     }
    // }
}
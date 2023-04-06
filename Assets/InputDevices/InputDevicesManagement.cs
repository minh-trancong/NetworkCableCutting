using UnityEngine;
using UnityEngine.XR;
using System.Collections.Generic;

public class InputDevicesManagement : MonoBehaviour
{
    private static InputDevicesManagement instance;
    public static InputDevicesManagement Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<InputDevicesManagement>();
                if (instance == null)
                {
                    Debug.LogError("There is no InputDevicesManagement object in the scene.");
                }
            }
            return instance;
        }
    }

    public List<InputDevice> inputDevices;
    
    void Awake()
    {
        inputDevices = new List<InputDevice>();
        InputDevices.GetDevices(inputDevices);
    }

    public bool IsTriggerPressed()
    {
        foreach (InputDevice device in inputDevices)
        {
            bool triggerValue;
            if (device.TryGetFeatureValue(CommonUsages.triggerButton, out triggerValue) && triggerValue)
            {
                return true;
            }
        }
        return false;
    }

    public float GetTriggerValue()
    {
        InputDevices.GetDevices(inputDevices);
        float leftTrigger = 0f;
        float rightTrigger = 0f;
        InputDevice leftHand = InputDevices.GetDeviceAtXRNode(XRNode.LeftHand);
        InputDevice rightHand = InputDevices.GetDeviceAtXRNode(XRNode.RightHand);
        
        leftHand.TryGetFeatureValue(CommonUsages.trigger, out leftTrigger);
        rightHand.TryGetFeatureValue(CommonUsages.trigger, out rightTrigger);
        
        if (leftTrigger > rightTrigger)
        {
            return leftTrigger;
        }
        else if (rightTrigger > leftTrigger)
        {
            return rightTrigger;
        }
        else if (leftTrigger != 0f)
        {
            return leftTrigger;
        }
        else
        {
            //TODO Tay phải đang bị không có giá trị
            return 0f;
        }
    }
    public bool isTriggerPressed;
    void Update(){
        isTriggerPressed = InputDevicesManagement.Instance.IsTriggerPressed();
    }
}

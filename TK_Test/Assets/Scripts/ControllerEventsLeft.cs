using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

[RequireComponent(typeof(SteamVR_TrackedObject))]
public class ControllerEventsLeft : NetworkBehaviour
{
    public SteamVR_TrackedObject trackedObj;
    SteamVR_Controller.Device device;

    public delegate void TriggerHold();
    public delegate void TriggerUp();
    public delegate void TriggerDown();
    public delegate void GripHold();
    public delegate void GripUp();
    public delegate void GripDown();
    public delegate void TouchpadHold();
    public delegate void TouchpadUp();
    public delegate void TouchpadDown();
    public delegate void ApplicationMenuHold();
    public delegate void ApplicationMenuUp();
    public delegate void ApplicationMenuDown();
    public delegate void TouchHold();
    public delegate void TouchUp();
    public delegate void TouchDown();

    public static event TriggerHold OnTriggerHold;
    public static event TriggerUp OnTriggerUp;
    public static event TriggerDown OnTriggerDown;

    void Awake()
    {
        trackedObj = GetComponent<SteamVR_TrackedObject>();
    }

	void FixedUpdate ()
    {
        device = SteamVR_Controller.Input((int)trackedObj.index);

        //When Trigger is being held
        if (device.GetTouch(SteamVR_Controller.ButtonMask.Trigger))
        {
            Debug.Log("Holding Trigger");
            if (OnTriggerHold != null)
            {
                OnTriggerHold();
            }
        }

        //When Trigger is let go
        if (device.GetTouchUp(SteamVR_Controller.ButtonMask.Trigger))
        {
            Debug.Log("Let go of Trigger");
            if (OnTriggerUp != null)
            {
                OnTriggerUp();
            }
        }

        //When Trigger is pressed
        if (device.GetTouchDown(SteamVR_Controller.ButtonMask.Trigger))
        {
            Debug.Log("Pressed Trigger");
            if (OnTriggerDown != null)
            {
                OnTriggerDown();
            }
        }

        //When Grip button is being held
        if (device.GetPress(SteamVR_Controller.ButtonMask.Grip))
        {
            Debug.Log("Holding Grip");
        }

        //When Grip button is let go 
        if (device.GetPressUp(SteamVR_Controller.ButtonMask.Grip))
        {
            Debug.Log("Let go of Grip");
        }

        //When Grip button is pressed
        if (device.GetPressDown(SteamVR_Controller.ButtonMask.Grip))
        {
            Debug.Log("Pressed Grip");
        }

        //When Touchpad is being held
        if (device.GetPress(SteamVR_Controller.ButtonMask.Touchpad))
        {
            Debug.Log("Holding Touchpad");
        }

        //When Touchpad is let go
        if (device.GetPressUp(SteamVR_Controller.ButtonMask.Touchpad))
        {
            Debug.Log("Let go of Touchpad");
        }

        //When Touchpad is pressed
        if (device.GetPressDown(SteamVR_Controller.ButtonMask.Touchpad))
        {
            Debug.Log("Pressed Touchpad");
        }

        //When ApplicationMenu is being held
        if (device.GetPress(SteamVR_Controller.ButtonMask.ApplicationMenu))
        {
            Debug.Log("Holding ApplicationMenu");
        }

        //When ApplicationMenu is let go
        if (device.GetPressUp(SteamVR_Controller.ButtonMask.ApplicationMenu))
        {
            Debug.Log("Let go of ApplicationMenu");
        }

        //When ApplicationMenu is pressed
        if (device.GetPressDown(SteamVR_Controller.ButtonMask.ApplicationMenu))
        {
            Debug.Log("Pressed ApplicationMenu");
        }

        //When Touch is being held
        if (device.GetTouch(SteamVR_Controller.ButtonMask.Axis0))
        {
            Debug.Log("Holding Touch");
        }

        //When Toucad is let go
        if (device.GetTouchUp(SteamVR_Controller.ButtonMask.Axis0))
        {
            Debug.Log("Let go of Touch");
        }

        //When Touchp is pressed
        if (device.GetTouchDown(SteamVR_Controller.ButtonMask.Axis0))
        {
            Debug.Log("Pressed Touch");
        }
    }
}

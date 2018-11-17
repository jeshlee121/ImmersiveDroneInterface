﻿namespace ISAACS
{
    using UnityEngine;
    using UnityEngine.UI; // <-- you need this to access UI (button in this case) functionalities
    using ROSBridgeLib.interface_msgs;
    using VRTK;

    public class LaunchButton : MonoBehaviour
    {
        Button myButton;
        bool flying;
        private GameObject controller; //needed to access pointer

        void Awake()
        {

            controller = GameObject.FindGameObjectWithTag("GameController");

            myButton = GetComponent<Button>(); // <-- you get access to the button component here

            myButton.onClick.AddListener(() => { OnClickEvent(); });  // <-- you assign a method to the button OnClick event here
            
            flying = false;
        }

        void OnClickEvent()
        {
            //if (controller.GetComponent<VRTK_Pointer>().IsPointerActive())
            //{
            //    if (WorldProperties.selectedDrone != null && !flying)
            //    {
            //        WorldProperties.worldObject.GetComponent<ROSDroneConnection>().SendServiceCall("/takeoff", "");
            //        GetComponentInChildren<Text>().text = "Land";
            //        flying = true;
            //    }

            //    else if (WorldProperties.selectedDrone != null && flying)
            //    {
            //        WorldProperties.worldObject.GetComponent<ROSDroneConnection>().SendServiceCall("/land", "");
            //        GetComponentInChildren<Text>().text = "Takeoff";
            //        flying = false;
            //    }
            //}        
        }

        void OnApplicationQuit()
        {
            //if (WorldProperties.selectedDrone != null && flying)
            //{
            //    WorldProperties.worldObject.GetComponent<ROSDroneConnection>().SendServiceCall("/land", "");
            //}
        }
    }
}
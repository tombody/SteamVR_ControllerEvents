using UnityEngine;
using System.Collections;

public class TestEventScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
        ControllerEventsLeft.OnTriggerUp += Test;
	
	}
	
	// Update is called once per frame
	void Update () {
	}

    void Test()
    {
        print("Events are working");
    }
}

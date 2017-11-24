using UnityEngine;
using System.Collections;

public class ExampleGameEventBroadcaster : MonoBehaviour {
    public GameEvent @event;

	void Update () {
        if (Input.GetMouseButton(0))
            @event.Raise();        
	}
}

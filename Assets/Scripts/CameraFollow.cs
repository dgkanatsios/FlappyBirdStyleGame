using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {

	// Use this for initialization
	void Start () {
        cameraZ = transform.position.z;
	}

    float cameraZ;


	void Update () {
        transform.position = new Vector3(Player.position.x + 0.5f, 0, cameraZ);
       
	}

    
    public Transform Player;
}

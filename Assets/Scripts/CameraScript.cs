using UnityEngine;
using System.Collections;

public class CameraScript : MonoBehaviour {

    public Transform target;

	// Use this for initialization
	void Start () {

	
	}
	
	// Update is called once per frame
	void Update () {
        Vector2 targetPos = target.transform.position;
        transform.position = new Vector3(targetPos.x, 2, -10);
	}
}

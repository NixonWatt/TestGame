using UnityEngine;
using System.Collections;

public class DeathWallScript : MonoBehaviour {

    public float speed;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        Vector2 currentPos = transform.position;
        transform.position = new Vector2(currentPos.x + speed, currentPos.y);
	}
}

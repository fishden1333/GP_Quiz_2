using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CueBall : MonoBehaviour {
    GameObject ball, cue, star;
    float rotation;
    Vector3 moveVec, ballPos;

	// Use this for initialization
	void Start () {
        ball = GameObject.Find("Ball");
        cue = GameObject.Find("Cue");
        star = GameObject.Find("Star");
    }
	
	// Update is called once per frame
	void Update () {
        rotation = -2.0f * Input.GetAxis("Mouse X");
        ballPos = ball.transform.position;
        moveVec.x = star.transform.position.x - cue.transform.position.x;
        moveVec.y = 0.0f;
        moveVec.z = star.transform.position.z - cue.transform.position.z;
        transform.RotateAround(ballPos, Vector3.up, rotation);
	}

    private void FixedUpdate()
    {
        if (Input.GetMouseButtonDown(0))
        {
            cue.SetActive(false);
            ball.GetComponent<Rigidbody>().AddForce(moveVec * 500);
        }
    }
}

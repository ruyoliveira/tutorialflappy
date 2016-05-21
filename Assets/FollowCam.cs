using UnityEngine;
using System.Collections;

public class FollowCam : MonoBehaviour
{
    public Transform bird;
    
	void Update ()
    {
        Vector3 pos = transform.position;
        pos.x = bird.position.x;
        transform.position = pos;
	}
}

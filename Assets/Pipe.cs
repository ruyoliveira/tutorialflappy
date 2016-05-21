using UnityEngine;
using System.Collections;

public class Pipe : MonoBehaviour
{
    public Transform bird;
    public float distance;

	// Update is called once per frame
	void Update ()
    {
	    if(transform.position.x - bird.position.x < distance)
        {
            GameObject.Destroy(this.gameObject);
        }
	}
}

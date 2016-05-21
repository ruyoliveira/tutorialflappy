using UnityEngine;
using System.Collections;

public class InfiniteGround : MonoBehaviour
{
    public Transform bird;
    public float correctionFactor;

	void Update ()
    {
	    if(bird.position.x-transform.position.x > 0)
        {
            transform.Translate(new Vector3(correctionFactor, 0, 0));
        }
	}
}

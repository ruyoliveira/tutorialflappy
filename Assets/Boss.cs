using UnityEngine;
using System.Collections;

public class Boss : MonoBehaviour
{
    public Transform bird;
    public GameObject pipe;
    public float distance;
    public float increment;
    public float min, max;

	void Start ()
    {
	
	}
	
	void Update ()
    {
	    if(transform.position.x - bird.position.x < distance)
        {
            Pipe p = Instantiate(pipe).GetComponent<Pipe>();
            p.bird = bird;
            p.transform.position = new Vector3(transform.position.x, Random.Range(min, max), 0);
            transform.Translate(new Vector3(increment, 0, 0));
        }
	}
}

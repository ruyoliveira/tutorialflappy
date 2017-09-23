using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Bird : MonoBehaviour
{
    public float SpeedX;
    public float SpeedFly;
    bool alive = false;
    public GameObject GameOverUI;
    public Text score;

    void OnCollisionEnter2D(Collision2D c)
    {
        Die();
        GameOverUI.SetActive(true);
    }

	void Update ()
    {
        if (alive)
        {
            GetComponent<Rigidbody2D>().gravityScale = 1;
            transform.Translate(new Vector3(SpeedX, 0, 0) * Time.deltaTime);

            if (Input.GetMouseButtonDown(0))
            {
                GetComponent<Rigidbody2D>().velocity =  new Vector2(0, SpeedFly);
            }
            score.text = ((int)transform.position.x).ToString();
        }
        else
        {
            GetComponent<Rigidbody2D>().gravityScale = 0;
            GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        }

	}

    public void Live()
    {
        alive = true;
    }


    public void Die()
    {
        alive = false;
    }

    public void Reset()
    {
        Application.LoadLevel(Application.loadedLevel);
    }
}

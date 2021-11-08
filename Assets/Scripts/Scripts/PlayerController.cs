using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 7;

    float screenHalfWidthInWorldUnits;

    // Start is called before the first frame update
    void Start()
    {
        float halfPlayerWidth = transform.localScale.x / 2f;
        screenHalfWidthInWorldUnits = Camera.main.aspect * Camera.main.orthographicSize + halfPlayerWidth;
    }

    // Update is called once per frame
    void Update()
    {
        float inputX = Input.GetAxisRaw ("Horizontal");
        float velocity = inputX * speed;
        transform.Translate (Vector2.right * velocity * Time.deltaTime);
            //left side
            if (transform.position.x < -screenHalfWidthInWorldUnits) {
                transform.position = new Vector2 (screenHalfWidthInWorldUnits,transform.position.y);
            }

            // right side
            if (transform.position.x > screenHalfWidthInWorldUnits) {
                transform.position = new Vector2 (-screenHalfWidthInWorldUnits,transform.position.y);
            }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "PlayerCude01")
        {
            PlaneManger.Instance.ChangeLife(1);
            Destroy(other.gameObject);
        }

        if (other.tag == "PlayerCude02")
        {
            PlaneManger.Instance.AddLife(1);
            Destroy(other.gameObject);
        }
    }


}

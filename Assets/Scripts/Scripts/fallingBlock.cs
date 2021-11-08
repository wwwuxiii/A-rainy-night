using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fallingBlock : MonoBehaviour
{

    float speed = 7;

    private void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (PlaneManger.Instance.HP == 0)
        {
            Destroy(this.gameObject);
        }

        transform.Translate (Vector3.down * speed * Time.deltaTime, Space.Self);
    }

 

}

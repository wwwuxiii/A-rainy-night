using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CudeCollider : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "PlayerCude01")
        {
            PlaneManger.Instance.AddScore(1);

            Destroy(other.gameObject);
        }

        if (other.tag == "PlayerCude02")
        {
          
            Destroy(other.gameObject);
        }
    }


}

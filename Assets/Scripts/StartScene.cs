using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartScene : MonoBehaviour
{

    public GameObject[] DH; 

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(DHLis(6));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator DHLis(float sec)
    {
        yield return new WaitForSeconds(sec);
        DH[0].SetActive(false);
        DH[1].SetActive(true);
        yield return new WaitForSeconds(sec);
        SceneManager.LoadScene("RoomScene01");
    }

}

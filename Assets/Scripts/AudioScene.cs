using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class AudioScene : MonoBehaviour
{

    public float TimeNum = 24;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(LoadSceneLis(TimeNum));
    }

    IEnumerator LoadSceneLis(float sec)
    {

        yield return new WaitForSeconds(sec);
        SceneManager.LoadScene("RoomScene01");
   
    }

}

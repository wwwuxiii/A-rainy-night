using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DHManger : MonoBehaviour
{

    public Button NextBtn;
    public GameObject NextGO;
    public GameObject computerUI;
    public int UINumChange = 0;

    // Start is called before the first frame update
    void Start()
    {

        NextBtn.onClick.AddListener(NextBtnLis);

        StartCoroutine(ActiveUI(0.2f));

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void NextBtnLis()
    {

        NextGO.SetActive(true);
        this.gameObject.SetActive(false);

        if (UINumChange == 1)
        {
            computerUI.SetActive(false);

            SceneManager.LoadScene("GameBirds");
        }

    }

    IEnumerator ActiveUI(float sec)
    {
        yield return new WaitForSeconds(sec);

        NextBtn.gameObject.SetActive(true);
    }


}

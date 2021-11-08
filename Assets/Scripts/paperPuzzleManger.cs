using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class paperPuzzleManger : MonoBehaviour
{

    public static paperPuzzleManger Instance;

    public GameObject wholepiece;
    public GameObject arrangedpuzzle;

    public GameObject[] paperPuzzle01;

    public int PuzzleNum = 0;

    public AudioSource PuzzleSound;

    public GameObject Canvas01;
    public GameObject MainCamera01;
    public GameObject BG02;
    public GameObject planeGameScene;

    public Button ClickBtn;
    public AudioSource DoorSound;

    // Start is called before the first frame update
    void Start()
    {
        Instance = this;

        ClickBtn.onClick.AddListener(ClickBtnLis);
    }

    // Update is called once per frame
    void Update()
    {

        ray();

    }

    void ray()
    {

        if (Input.GetMouseButtonUp(0) || Input.touchCount > 0)
        {

            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit, 10000))
            {
                if (hit.collider.gameObject.tag == "puzzle1")
                {
                    Destroy(hit.collider.gameObject);

                    paperPuzzle01[0].SetActive(true);
                    PuzzleSound.Play();

                    PuzzleNum++;
                }
                if (hit.collider.gameObject.tag == "puzzle2")
                {
                    Destroy(hit.collider.gameObject);

                    paperPuzzle01[1].SetActive(true);
                    PuzzleSound.Play();

                    PuzzleNum++;
                }
                if (hit.collider.gameObject.tag == "puzzle3")
                {
                    Destroy(hit.collider.gameObject);

                    paperPuzzle01[2].SetActive(true);
                    PuzzleSound.Play();

                    PuzzleNum++;
                }
                if (hit.collider.gameObject.tag == "puzzle4")
                {
                    Destroy(hit.collider.gameObject);

                    paperPuzzle01[3].SetActive(true);
                    PuzzleSound.Play();

                    PuzzleNum++;
                }
                if (hit.collider.gameObject.tag == "puzzle5")
                {
                    Destroy(hit.collider.gameObject);

                    paperPuzzle01[4].SetActive(true);
                    PuzzleSound.Play();

                    PuzzleNum++;
                }
                if (hit.collider.gameObject.tag == "puzzle6")
                {
                    Destroy(hit.collider.gameObject);

                    paperPuzzle01[5].SetActive(true);
                    PuzzleSound.Play();

                    PuzzleNum++;
                }
                if (hit.collider.gameObject.tag == "puzzle7")
                {
                    Destroy(hit.collider.gameObject);

                    paperPuzzle01[6].SetActive(true);
                    PuzzleSound.Play();

                    PuzzleNum++;
                }
                if (hit.collider.gameObject.tag == "puzzle8")
                {
                    Destroy(hit.collider.gameObject);

                    paperPuzzle01[7].SetActive(true);
                    PuzzleSound.Play();

                    PuzzleNum++;
                }
                if (hit.collider.gameObject.tag == "puzzle9")
                {
                    Destroy(hit.collider.gameObject);

                    paperPuzzle01[8].SetActive(true);
                    PuzzleSound.Play();

                    PuzzleNum++;
                }

                if (hit.collider.gameObject.tag == "arrangedpuzzle")
                {
                    if (PuzzleNum == 9)
                    {
                        for (int n = 0;n<9;n++)
                        {
                            paperPuzzle01[8].SetActive(false);
                        }

                        arrangedpuzzle.SetActive(false);
                        wholepiece.SetActive(true);
                    }
                }

                if (hit.collider.gameObject.tag == "planeGame")
                {
                    Canvas01.SetActive(false);
                    MainCamera01.SetActive(false);
                    BG02.SetActive(false);
                    planeGameScene.SetActive(true);
                }
                
                if (hit.collider.gameObject.tag == "doorLock")
                {

                    DoorSound.Play();
                    Time.timeScale = 1;
                    StartCoroutine(OpenDoorLis(1));
                  
                }

            }
        }
    }

    public void ClickBtnLis()
    {
        Canvas01.SetActive(true);
        MainCamera01.SetActive(true);
        BG02.SetActive(true);
        planeGameScene.SetActive(false);
}


    IEnumerator OpenDoorLis(float sec)
    {
        yield return new WaitForSeconds(sec);
 
        SceneManager.LoadScene("RoomScene03");
    }

}


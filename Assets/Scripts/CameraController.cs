using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CameraController : MonoBehaviour
{

    public GameObject dollUI;
    public GameObject dollUI02;

    public GameObject drawer011;
    public GameObject drawer021;
    public GameObject drawer021UI;

    public GameObject drawer031;

    public AudioSource dollSound;
    public AudioSource drawerSound;
    public AudioSource clueSound;
    public AudioSource DoorSound;

    public GameObject mancalaUI;
    public GameObject chessUI;
    public GameObject sportsUI;

    public GameObject DoorUI01;
    public GameObject DoorUI02;

    // Start is called before the first frame update
    void Start()
    {
       
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
                if (hit.collider.gameObject.tag == "doll")
                {
                    if (BackpackManger.Instance.Isclue[0] == true)
                    {
                        dollUI02.SetActive(true);
                        clueSound.Play();

                        BackpackManger.Instance.Clickclue02();
                    }
                    else
                    {
                        dollUI.SetActive(true);
                        dollSound.Play();
                    }
                }

                if (hit.collider.gameObject.tag == "dollUI")
                {
                    dollUI.SetActive(false);
                    dollUI02.SetActive(false);
                  //  dollSound.Play();
                }

                if (hit.collider.gameObject.tag == "drawer01")
                {
                    drawer011.SetActive(true);
                    drawerSound.Play();
                }

                if (hit.collider.gameObject.tag == "drawer011")
                {
                    drawer011.SetActive(false);
                    drawerSound.Play();
                }

                if (hit.collider.gameObject.tag == "drawer02")
                {
                    if (BackpackManger.Instance.Isclue[0] == true)
                    {
                        drawer021.SetActive(true);
                        drawerSound.Play();

                        BackpackManger.Instance.Clickclue04();
                    }
                    else
                    {
                        drawer021UI.SetActive(true);
                    }           
                }

                if (hit.collider.gameObject.tag == "drawer021")
                {
                    drawer021.SetActive(false);
                    drawer021UI.SetActive(false);
                    drawerSound.Play();
                }

                if (hit.collider.gameObject.tag == "drawer03")
                {
                    drawer031.SetActive(true);
                    drawerSound.Play();
                }

                if (hit.collider.gameObject.tag == "drawer031")
                {
                    drawer031.SetActive(false);
                    drawerSound.Play();
                }

                if (hit.collider.gameObject.tag == "mancala01")
                {
                    mancalaUI.SetActive(true);
                    clueSound.Play();

                    BackpackManger.Instance.Clickclue01();
                }
                if (hit.collider.gameObject.tag == "mancala011")
                {
                    mancalaUI.SetActive(false);
                    clueSound.Play();
                }

                if (hit.collider.gameObject.tag == "chess01")
                {
                    chessUI.SetActive(true);
                    clueSound.Play();

                    BackpackManger.Instance.Clickclue01();
                }
                if (hit.collider.gameObject.tag == "chess011")
                {
                    chessUI.SetActive(false);
                    clueSound.Play();
                }

                if (hit.collider.gameObject.tag == "sports01")
                {
                    sportsUI.SetActive(true);
                    clueSound.Play();

                    BackpackManger.Instance.Clickclue01();
                }
                if (hit.collider.gameObject.tag == "sports011")
                {
                    sportsUI.SetActive(false);
                    clueSound.Play();
                }

                if (hit.collider.gameObject.tag == "Door01")
                {
                    if (BackpackManger.Instance.Isclue[1] == true)
                    {
                        DoorUI02.SetActive(true);
                        DoorSound.Play();             
                    }
                    else
                    {
                        DoorUI01.SetActive(true);
                        DoorSound.Play();
                    }
                }

                if (hit.collider.gameObject.tag == "Door011")
                {
                    if (BackpackManger.Instance.Isclue[1] == true)
                    {
                       // DoorUI02.SetActive(true);
                        DoorSound.Play();

                        SceneManager.LoadScene("RoomScene02");
                    }
                    else
                    {
                        DoorUI01.SetActive(false);
                        DoorUI02.SetActive(false);
                        DoorSound.Play();
                    }         
                }

            }

        }
    }

 


}

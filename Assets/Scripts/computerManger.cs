using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class computerManger : MonoBehaviour
{

    public static computerManger Instance;

    public bool IsComputer = false;
    public GameObject computerUI;

    public GameObject ClickUI;
    public GameObject GuiUI;

    // Start is called before the first frame update
    void Start()
    {
        Instance = this;


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
                if (hit.collider.gameObject.tag == "computer" && IsComputer == false)
                {
                    ClickUI.SetActive(false);
                    GuiUI.SetActive(true);

                }

                if (hit.collider.gameObject.tag == "GUI" && IsComputer == false)
                {
                    GuiUI.SetActive(false);
                    IsComputer = true;
                    computerUI.SetActive(true);

                }

            }
        }
    }
}
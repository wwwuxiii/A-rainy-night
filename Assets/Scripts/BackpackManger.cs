using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class BackpackManger : MonoBehaviour
{

    public static BackpackManger Instance;

    public Button ButtonbackpackClick;
    public bool IsClickBackpack = false;
    public GameObject backpack;

    public GameObject[] clue;
    public bool[] Isclue;

    // Start is called before the first frame update
    void Start()
    {
        Instance = this;

        ButtonbackpackClick.onClick.AddListener(ButtonbackpackClickLis);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ButtonbackpackClickLis()
    {

        if (IsClickBackpack == false)
        {
            backpack.SetActive(true);
            IsClickBackpack = true;
        }
        else
        {
            backpack.SetActive(false);
            IsClickBackpack = false;
        }
    }


    public void Clickclue01()
    {
        Isclue[0] = true;
        clue[0].SetActive(true);
    }

    public void Clickclue02()
    {
        Isclue[1] = true;
        clue[1].SetActive(true);
    }

    public void Clickclue03()
    {
        Isclue[2] = true;
        clue[2].SetActive(true);
    }

    public void Clickclue04()
    {
        Isclue[3] = true;
        clue[3].SetActive(true);
    }


}

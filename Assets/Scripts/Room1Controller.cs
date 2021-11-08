using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Room1Controller : MonoBehaviour
{

    public Button LeftBtnClick;
    public Button RightBtnClick;

    public GameObject[] Room;
    public int RoomNum = 0;

    public Button NextSceneBtnClick;
    public string NextScene;

    // Start is called before the first frame update
    void Start()
    {
        LeftBtnClick.onClick.AddListener(LeftBtnClickLis);
        RightBtnClick.onClick.AddListener(RightBtnClickLis);

        NextSceneBtnClick.onClick.AddListener(NextSceneBtnClickLis);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void LeftBtnClickLis()
    {
        RoomNum--;
        if (RoomNum == -1)
        {
            RoomNum = 3;
        }
        CloseRoom();
        Room[RoomNum].SetActive(true);
    }

    public void RightBtnClickLis()
    {
        RoomNum++;
        if (RoomNum == 4)
        {
            RoomNum = 0;
        }
        CloseRoom();
        Room[RoomNum].SetActive(true);
    
    }

    public void CloseRoom()
    {
        for (int n = 0; n < 4; n++)
        {
            Room[n].SetActive(false);
        }
    }


    public void NextSceneBtnClickLis()
    {
        SceneManager.LoadScene(NextScene);
    }



}

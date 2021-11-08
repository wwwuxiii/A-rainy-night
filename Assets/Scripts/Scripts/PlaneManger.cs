using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlaneManger : MonoBehaviour
{

    public static PlaneManger Instance;

    public int m_score = 0;
    public int HP = 3;

    public Text m_scoreText;
    public Text m_scoreText02;
    public Text HPText;

    public GameObject ScenePanel;
    public GameObject GameOverPlane;

    public GameObject Player;
    public GameObject PlayPoint;
    public GameObject Ins;


    // Start is called before the first frame update
    void Start()
    {
        Instance = this;

        m_scoreText.text = m_score.ToString("0");
        HPText.text = HP.ToString("0");
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.Space))
        {
            HP = 0;
            m_score = 0;
            m_scoreText.text = m_score.ToString("0");
            HPText.text = HP.ToString("0");
            m_scoreText02.text = m_score.ToString("0");
            Time.timeScale = 1;
            StartCoroutine(Againlis(1)); 
          //  SceneManager.LoadScene("planeGameScene");
        }

    }

    IEnumerator Againlis(float sec)
    {

        yield return new WaitForSeconds(sec);  
        HP = 3;
        m_score = 0;
        m_scoreText.text = m_score.ToString("0");
        HPText.text = HP.ToString("0");
        m_scoreText02.text = m_score.ToString("0");

        ScenePanel.SetActive(true);
        GameOverPlane.SetActive(false);
        Ins.SetActive(true);
        Player.transform.position = PlayPoint.transform.position;

    }

    public void AddScore(int point)
    {
        m_score += point;
        m_scoreText.text = m_score.ToString("0");
        m_scoreText02.text = m_score.ToString("0");
    }

    public void ChangeLife(int life)
    {
        HP--;
        HPText.text = HP.ToString();

        if (HP <= 0)
        {
            Time.timeScale = 0;
            Ins.SetActive(false);
            ScenePanel.SetActive(false);
            GameOverPlane.SetActive(true);
        }
    }

    public void AddLife(int life)
    {
        HP++;
        HPText.text = HP.ToString();
    }

}

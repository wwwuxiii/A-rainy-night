using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BirdController : MonoBehaviour {

	public ParticleSystem jetpack; 

	public Transform groundCheckTransform;

	private bool grounded;

	public LayerMask groundCheckLayerMask;

	Animator animator; 

	public float forwardMovementSpeed = 3.0f;

	public float jetpackForce = 75.0f;

    public Button LoseButton;     
    private int Scores = 0;  
    public Text ScoreText;   
    public GameObject  GamLoseObj;

    public Button WinButton;
    public GameObject GamWinbj;

    void Start ()
    {
		animator = GetComponent<Animator>();
      
        LoseButton.onClick.AddListener(AgainClickListener);
        WinButton.onClick.AddListener(WinClickListener);

    }

	void UpdateGroundedStatus()
	{
		grounded = Physics2D.OverlapCircle(groundCheckTransform.position, 0.1f, groundCheckLayerMask);
		animator.SetBool("grounded", grounded);
	}

	private bool dead = false;
	void OnTriggerEnter2D(Collider2D collider)
	{
		if (collider.gameObject.CompareTag("Coins"))
			CollectCoin(collider);
		else
			HitByLaser(collider);
	}
	void HitByLaser(Collider2D laserCollider)
	{
		if (!dead)
			laserCollider.gameObject.GetComponent<AudioSource>().Play();
		dead = true;
		animator.SetBool("dead", true);
        GamLoseObj.SetActive(true);
	}

	void CollectCoin(Collider2D coinCollider)
	{
        Scores= Scores + 1;
		Destroy(coinCollider.gameObject);
		AudioSource.PlayClipAtPoint(coinCollectSound, transform.position);
        ScoreText.text = string.Format("{0:0}", Scores);

        if (Scores == 20)
        {
            Time.timeScale = 0;
            dead = true;
            animator.SetBool("dead", true);
            GamWinbj.SetActive(true);
        }

	}

	public AudioClip coinCollectSound;

	void FixedUpdate () 
	{
		bool jetpackActive = Input.GetButton("Fire1");

		jetpackActive = jetpackActive && !dead;

		if (jetpackActive)
		{
			GetComponent< Rigidbody2D>().AddForce(new Vector2(0, jetpackForce));
		}

		if (!dead)
		{
			Vector2 newVelocity =GetComponent< Rigidbody2D>().velocity;
			newVelocity.x = forwardMovementSpeed;
			GetComponent< Rigidbody2D>().velocity = newVelocity;
		}

		UpdateGroundedStatus();
	
	}

  
    public void AgainClickListener()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("GameBirds");
    }

    public void WinClickListener()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("RoomScene03");
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody rigidbody;
    /*public float speed;

    public float speedMultiplier;
    public float speedIncreasesMileStones;
    private float speeedMilestoneCount;
    public Vector3 change;
    public float horizontalMultipler = 2;
    public float horizontalInput;
    [SerializeField] float horizontalSpeed = 3;
    private bool isGameStarted = false;

    private float ScreenWidth;
 
    public static bool gameOver;
    public GameObject gameOverPanel;

    // Start is called before the first frame update
    void Start()
    {
        gameOver = false;

        Time.timeScale = 1;

        body = GetComponent<Rigidbody>();

        speeedMilestoneCount = speedIncreasesMileStones;

        ScreenWidth = Screen.width;
    }
    // Update is called once per frame
    void Update()
    {
        Movement();
    }

    private void FixedUpdate()
    {
        if (transform.position.z > speeedMilestoneCount)
        {

            speeedMilestoneCount += speedIncreasesMileStones;
            speedIncreasesMileStones = speedIncreasesMileStones * speedMultiplier;
            horizontalSpeed = horizontalSpeed * speedMultiplier;

        }

        transform.Translate(Vector3.forward * Time.deltaTime * horizontalSpeed, Space.World);

    }
   
    void Movement()
    {
        if (Input.GetKey(KeyCode.A) || (Input.GetKey(KeyCode.LeftArrow)))
        {
            if (this.gameObject.transform.position.x > Boundary.BInstance.leftSide)
            {
                transform.Translate(Vector3.left * Time.deltaTime * speed);
            }
        }

        if (Input.GetKey(KeyCode.D) || (Input.GetKey(KeyCode.RightArrow)))
        {
            if (this.gameObject.transform.position.x < Boundary.BInstance.rightSide)
            {
                transform.Translate(Vector3.right * Time.deltaTime * speed);
            }
        }

        int i = 0;
		//loop over every touch found
		while (i < Input.touchCount) {
			if (Input.GetTouch (i).position.x > ScreenWidth / 2) {
				 if (this.gameObject.transform.position.x < Boundary.BInstance.rightSide)
                    {
                       transform.Translate(Vector3.right * Time.deltaTime * speed);
                    }
			}
			if (Input.GetTouch (i).position.x < ScreenWidth / 2) {
				  if (this.gameObject.transform.position.x > Boundary.BInstance.leftSide)
                     {
                        transform.Translate(Vector3.left * Time.deltaTime * speed);
                     }
			}
			++i;
		}
    }

    public void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Obstacle")) 
        {
           gameOver = true;
           Time.timeScale = 0;
           gameOverPanel.SetActive(true);
        }
    }

    public void StartRunning()
    {
        isGameStarted = true;
    }
    */

    public int Direction;

    void Update()
    {
        Analyze();
        if (Input.GetKeyDown(KeyCode.A))
        {
            print("left");
            if (Direction == 0 || Direction == 1)
            {
                Direction--;
            }
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            print("right");
            if (Direction == 0 || Direction == -1)
            {
                Direction++;
            }
        }
    }

    void Analyze()
    {
        transform.position = Vector3.Lerp(transform.position, new Vector3(0, 0, 3 * Direction), 0.1f);
    }
}
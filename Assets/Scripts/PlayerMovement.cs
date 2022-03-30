using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityStandardAssets.CrossPlatformInput;
public class PlayerMovement : MonoBehaviour
{
    Rigidbody body;
    public float speed;

    public float speedMultiplier;
    public float speedIncreasesMileStones;
    private float speeedMilestoneCount;
    public Vector3 change;
    public float horizontalMultipler = 2;
    public float horizontalInput;
    [SerializeField] float horizontalSpeed = 3;
    private bool isGameStarted = false;

 
    public static bool gameOver;
    public GameObject gameOverPanel;

    // Start is called before the first frame update
    void Start()
    {
        gameOver = false;

        Time.timeScale = 1;

        body = GetComponent<Rigidbody>();

        speeedMilestoneCount = speedIncreasesMileStones;
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
        if (CrossPlatformInputManager.GetButtonDown("leftButton"))//(Input.GetKey(KeyCode.A) || (Input.GetKey(KeyCode.LeftArrow)))
        {
            if (this.gameObject.transform.position.x > Boundary.BInstance.leftSide)
            {
                transform.Translate(Vector3.left * Time.deltaTime * speed);
            }
        }

        if (CrossPlatformInputManager.GetButtonDown("rightButton"))//(Input.GetKey(KeyCode.D) || (Input.GetKey(KeyCode.RightArrow)))
        {
            if (this.gameObject.transform.position.x < Boundary.BInstance.rightSide)
            {
                transform.Translate(Vector3.right * Time.deltaTime * speed);
            }
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

}

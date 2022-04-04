using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Movement : MonoBehaviour
{
    private CharacterController charController;
    private Vector3 direction;
    public float forwardSpeed;

    
    public float speedMultiplier;
    public float speedIncreasesMileStones;
    private float speeedMilestoneCount;

    [SerializeField] float horizontalSpeed = 3;

    private int desireLane = 1;
    public float laneDistance;

    public static bool gameOver;
    public GameObject gameOverPanel;

    void Start() 
    {
        gameOver = false;

        Time.timeScale = 1;

        charController = GetComponent<CharacterController>();

    }
 
     void Update () {
 
         direction.z = forwardSpeed;

         if (SwipeManager.swipeRight) {
             desireLane++;
             if(desireLane == 3)
                desireLane = 2;
         }
 
        if (SwipeManager.swipeLeft) {
             desireLane--;
             if(desireLane == -1)
                desireLane = 0;
         }

         Vector3 targetPosition = transform.position.z * transform.forward + transform.position.y * transform.up;

        if (desireLane == 0)
        {
            targetPosition += Vector3.left * laneDistance;
        } 
        else if (desireLane == 2)
        {
            targetPosition += Vector3.right * laneDistance;
        }

        transform.position = targetPosition;

        
        //  int i = 0;
		// //loop over every touch found
		// while (i < Input.touchCount) {
		// 	if (Input.GetTouch (i).position.x > ScreenWidth / 3) {
		// 		 desireLane++;
        //          if(desireLane == 3)
        //          desireLane = 2;
		// 	}
		// 	if (Input.GetTouch (i).position.x < ScreenWidth / 3) {
		// 		   desireLane--;
        //            if(desireLane == -1)
        //            desireLane = 0;
		// 	}
		// 	++i;
		// }

     }

    private void FixedUpdate()
    {
        charController.Move(direction * Time.fixedDeltaTime);

         if (transform.position.z > speeedMilestoneCount)
        {

            speeedMilestoneCount += speedIncreasesMileStones;
            speedIncreasesMileStones = speedIncreasesMileStones * speedMultiplier;
            horizontalSpeed = horizontalSpeed * speedMultiplier;

        }

        transform.Translate(Vector3.forward * Time.deltaTime * horizontalSpeed, Space.World);
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

}

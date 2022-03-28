using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody body;
    public float speed;
    public Vector3 change;
    public float horizontalMultipler = 2;
    public float horizontalInput;
    [SerializeField] float horizontalSpeed = 3;
    private bool isGameStarted =false;
    
    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody>();
       
       
    }
    // Update is called once per frame
    void Update()
    {
        
       
        Movement();
    }
    private void FixedUpdate()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * horizontalSpeed, Space.World);
    }

    void Movement()
    {
        if(Input.GetKey(KeyCode.A) ||(Input.GetKey(KeyCode.LeftArrow)))
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
                transform.Translate(Vector3.right * Time.deltaTime * speed );
            }
        }
    }


    public void StartRunning()
    {
        isGameStarted = true;
    }

}

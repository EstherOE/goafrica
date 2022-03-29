using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boundary : MonoBehaviour
{
    public static Boundary BInstance;

    public float leftSide = -11.17f;
    public  float rightSide = -3.49f;
     float internalLeft;
    float internalRight;

    private void Awake()
    {
        BInstance= this;
    }
    public float BoundaryLeft()
    {
        int left = PlatformGenerator.pInstance.displayRandom;
        Debug.Log(leftSide);
        return leftSide = PlatformGenerator.pInstance.thePlatforms[left].transform.position.x;
        

       
    }

    public float BoundaryRight()
    {

        int right = PlatformGenerator.pInstance.displayRandom;
        Debug.Log(rightSide);
        return rightSide = PlatformGenerator.pInstance.thePlatforms[right].transform.position.x;
       
    }

    // Start is called before the first frame update
    void Start()
    {
        internalLeft = leftSide;
        internalRight = rightSide;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

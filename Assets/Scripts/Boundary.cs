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

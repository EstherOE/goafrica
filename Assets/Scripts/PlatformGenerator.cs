using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformGenerator : MonoBehaviour
{
    //   [SerializeField] GameObject  tilePrefab;
    public Transform generatingposition;
    public float distanceBetween;


    public float distanceBetweenMin, distanceBetweenMax;


    public GameObject[] thePlatforms;
    private int platformSelector;
    private float[] platformWidths;
    public static PlatformGenerator pInstance;
    public int displayRandom;
    private void Awake()
    {
        pInstance = this;
    }



    private void Start()
    {

        // platformWidth = tilePrefab.GetComponent<BoxCollider>().size.z;


        platformWidths = new float[thePlatforms.Length];
        for (int i = 0; i < thePlatforms.Length; i++)
        {
            platformWidths[i] = thePlatforms[i].GetComponent<BoxCollider>().size.y;
        }
    }






    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < generatingposition.position.z)
        {
            distanceBetween = Random.Range(distanceBetweenMin, distanceBetweenMax);
            platformSelector = Random.Range(0, thePlatforms.Length);
            displayRandom = platformSelector;
            transform.position = new Vector3(transform.position.x, transform.position.y,
                transform.position.z + platformWidths[platformSelector] + distanceBetween);



            Instantiate(thePlatforms[platformSelector], transform.position, transform.rotation);
        }

        // Instantiate(tilePrefab, tposition.position, transform.rotation);
    }
}

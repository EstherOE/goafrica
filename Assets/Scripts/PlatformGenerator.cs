using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformGenerator : MonoBehaviour
{
    [SerializeField] GameObject[] section;
    public float zpos = -28.4f;

    public bool creatingSection = false;

    private void Start()
    {
        
    }


    private void Update()
    {
        if(creatingSection== false)

        {
            creatingSection = true;

            //StartCourtine(GenearteSectio());
            StartCoroutine(GenearteSectio());
        }
    }

    public int newZpos;
    public int sectNum;
    private IEnumerator GenearteSectio()
    {

        sectNum = UnityEngine.Random.Range(0, section.Length);
        Instantiate(section[sectNum], new Vector3(0, 0, zpos), Quaternion.identity);
        zpos += newZpos ;

        yield return new WaitForSeconds(0);
        creatingSection = false;
    }
        
}

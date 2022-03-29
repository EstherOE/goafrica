using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCoinScript : MonoBehaviour
{
    [SerializeField] GameObject coins;
    [SerializeField] Transform position;
    [SerializeField] int numbertoSpawn;
    public float radius = 5f;


    // Start is called before the first frame update
    void Start()
    {
        for(int x=0; x<numbertoSpawn; x++)
        {

            float angle = x * Mathf.PI * 2 / numbertoSpawn;
            float xfirst = Mathf.Cos(angle) * radius;
            float xsecond = Mathf.Sin(angle) * radius;
            Vector3 pos = position.position + new Vector3(xfirst, 0, xsecond);

            float angleDegrees = -angle * Mathf.Rad2Deg;
            Quaternion rot = Quaternion.Euler(0, angleDegrees, 0);
            Instantiate(coins,pos,rot);
        }

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoutBoatScript : MonoBehaviour
{
    Animation anim;
    private float animSpeed = 0.6f;
    private void Start()
    {
        anim = GetComponent<Animation>();
    }
    private void Update()
    {


        anim["ScoutBoat"].speed = .5f;
    }
}

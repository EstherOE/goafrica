using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterBox : MonoBehaviour
{

    public GameObject[] characters;
    private int selectedCharacter = 2;
    // Start is called before the first frame update

    public static characterBox gameInstance;

    private void Awake()
    {
        gameInstance = this;
    }
    void Start()
    {
        foreach(GameObject ch in characters)
        {
            ch.SetActive(false);
        }
        characters[selectedCharacter].SetActive(true);

    }


    public void ChangeCharacter(int newCharacter)
    {    // Update is called once per frame
        characters[selectedCharacter].SetActive(false);
        characters[newCharacter].SetActive(true);
        selectedCharacter = newCharacter;
    
        
    }
}

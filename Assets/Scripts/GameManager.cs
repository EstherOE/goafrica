using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class GameManager : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI scoreText;
    [SerializeField] TextMeshProUGUI coinText;
    public static GameManager gameInstance;
    int scores;
    int coins;
    [SerializeField] int publicScore;
    [SerializeField] float publicTimer;
    float timer;
    // Start is called before the first frame update


    private void Awake()
    {
        gameInstance = this;
    }
    void Start()
    {
        scores = 0;
        coins = 0;
        scoreText.text = " " + scores+ " m";
        coinText.text = " " + coins;
        timer = publicTimer;
    }

    // Update is called once per frame
    void Update()
    {

        DisplayTimer();
       
    }

    void DisplayTimer()

    {
        timer -= Time.deltaTime;
        if (timer < 0)
        {
            scores += publicScore;
            scoreText.text = " " + scores + " m";
            timer = publicTimer;

        }
    }


    public void Display(int coinScore)
    {

        coins += coinScore;

        coinText.text = " " + coins;
    }

}

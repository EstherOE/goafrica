using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] TextMeshProUGUI scoreText;
   // [SerializeField] TextMeshProUGUI highScoreText;
    [SerializeField] TextMeshProUGUI coinText;
   // [SerializeField] TextMeshProUGUI shoppingText;
    public static GameManager gameInstance;
    int scores;
    [SerializeField] private int coins;
    public int highScores;
    [SerializeField] int publicScore;
    [SerializeField] float publicTimer;
    float timer;
    // Start is called before the first frame update


    private void Awake()
    {
        gameInstance = this;
        coins += PlayerPrefs.GetInt(prefMoney);

    }
    void Start()
    {
        scores = 0;

        noMoney.SetActive(false);

        scoreText.text = " " + scores + " m";
        coinText.text = " " + coins;
        timer = publicTimer;
     //   shoppingText.text = " " + coins;
    }
    public GameObject noMoney;
    public IEnumerator newCoin()
    {

        yield return new WaitForSeconds(2);
        noMoney.SetActive(false);


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
           // CheckHighScore();

            timer = publicTimer;

        }


    }

    public void CheckHighScore()
    {
        if (scores > PlayerPrefs.GetInt("HighScore"))
        {
            //highScoreText.text = " " + scores;

            PlayerPrefs.SetFloat("HighScore", scores);

        }

    }

    public const string prefMoney = "prefMoney";

    public void Display(int coinScore)
    {

        coins += coinScore;
        PlayerPrefs.SetInt(prefMoney, coins);
        coinText.text = " " + coins;
      //  shoppingText.text = " " + coins;
        if (coins <= 0)
        {
            coins = 0;
            noMoney.SetActive(true);
            StartCoroutine(newCoin());
            noMoney.SetActive(false);
        }
    }
    public int ReturnCurrent()
    {
        return coins;
    }

    public void SaveCoin()
    {
        PlayerPrefs.SetInt(prefMoney, coins);
    }
}

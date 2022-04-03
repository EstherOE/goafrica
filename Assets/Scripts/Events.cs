using UnityEngine.SceneManagement;
using UnityEngine;

public class Events : MonoBehaviour
{
    public GameObject noMoney;
    
    // Start is called before the first frame update
    public void ReplayGame(int amountRemoved)
    {
        int coins = GameManager.gameInstance.coins;

        

        if (GameManager.gameInstance.coins <= amountRemoved)
        {
            noMoney.SetActive(true);

            GameManager.gameInstance.DisplayCoin(coins);
            SceneManager.LoadScene("StartScene");

        }
       
        else
        {
            GameManager.gameInstance.Display(-amountRemoved);
            SceneManager.LoadScene("GameScene");
        }
    }

    // Update is called once per frame
    public void QuitGame()
    {
        Application.Quit();
    }
}

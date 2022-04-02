using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Events : MonoBehaviour
{
    public GameObject noMoney;
    
    // Start is called before the first frame update
    public void ReplayGame(int amountRemoved)
    {

        GameManager.gameInstance.Display(-amountRemoved);
        SceneManager.LoadScene("GameScene");

        if(GameManager.gameInstance.coins <=amountRemoved)
        {
            noMoney.SetActive(true);
            SceneManager.LoadScene("StartScene");

        }

        
    }

    // Update is called once per frame
    public void QuitGame()
    {
        SceneManager.LoadScene(0);
    }
}

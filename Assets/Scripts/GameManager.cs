using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class GameManager : MonoBehaviour {

    static bool isPlayerDead;
    static bool hasWon;
    public GameObject loseScreen;
    public GameObject winScreen;
    // Use this for initialization
    void Start () {
        isPlayerDead = false;
        loseScreen.SetActive(false);
        //winScreen.SetActive(false);
    }

    // Update is called once per frame
    void Update() {
        if (isPlayerDead)
        {
            loseScreen.SetActive(true);
        }
        else if (hasWon)
        {
            winScreen.SetActive(true);
        }

    }
  
    public static void playerDead()
    {
        isPlayerDead = true;
    }

    public static void winGame()
    {
        hasWon = true;
    }

    public void restart()
    {
        SceneManager.LoadScene(0);
    }
}


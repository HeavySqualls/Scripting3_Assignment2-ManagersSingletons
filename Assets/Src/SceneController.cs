using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    private int currentScene; 
    private int sceneToLoad;

    private int endGameScene = 5;

    private bool gameStarted = false;

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Return) && !gameStarted)
        {
            gameStarted = true;
            Toolbox.GetInstance().GetTimer().StartTimer();
            LoadNextScene();
        }

        if (Input.GetKeyUp(KeyCode.Escape))
        {
            gameStarted = false;
            LoadMainMenu();
        }
    }

    public void LoadNextScene()
    {
        currentScene = SceneManager.GetActiveScene().buildIndex;
        sceneToLoad = currentScene + 1;

        if (sceneToLoad == endGameScene)
        {
            Toolbox.GetInstance().GetTimer().StopTimer();
            SceneManager.LoadScene(sceneToLoad);
        }
        else
        {
            SceneManager.LoadScene(sceneToLoad);
        }
    }

    public void LoadSameScene()
    {
        SceneManager.LoadScene(currentScene);
    }

    public void LoadMainMenu()
    {
        Toolbox.GetInstance().GetPlayerManager().GameReset();
        SceneManager.LoadScene(0);
    }

}

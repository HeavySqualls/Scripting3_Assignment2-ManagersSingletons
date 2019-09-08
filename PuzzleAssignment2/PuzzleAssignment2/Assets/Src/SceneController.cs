using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    private int currentScene; 
    private int sceneToLoad;

    private int startGameScene = 0;
    private int endGameScene = 5;

    private bool gameStarted = false;

    private static SceneController instance;
    void Awake()
    {
        if (instance != null)
        {
            Destroy(this);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(this);
        }
    }

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

        if (sceneToLoad == endGameScene) // if next scene is the score scene
        {
            Toolbox.GetInstance().GetTimer().StopTimer();
            SceneManager.LoadScene(sceneToLoad);
        }
        if (sceneToLoad == startGameScene)
        {
            Toolbox.GetInstance().GetPlayerManager().GameReset();
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
        SceneManager.LoadScene(0);
    }

}

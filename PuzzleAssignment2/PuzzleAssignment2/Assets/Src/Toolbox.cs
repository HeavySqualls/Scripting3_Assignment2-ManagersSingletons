using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Toolbox : MonoBehaviour
{
    private static Toolbox _instance;

    public static Toolbox GetInstance()
    {
        if (Toolbox._instance == null)
        {
            var go = new GameObject("Toolbox");
            DontDestroyOnLoad(go);
            Toolbox._instance = go.AddComponent<Toolbox>();
        }
        return Toolbox._instance;
    }

    // Managers

    private SceneController sceneManager;
    private PlayerManager playerManager;

    void Awake()
    {
        DontDestroyOnLoad(this);

        if (Toolbox._instance)
        {
            Destroy(this);
            return;
        }

        var go = new GameObject("SceneManager");
        this.sceneManager = go.AddComponent<SceneController>();

        var go2 = new GameObject("PlayerManager");
        this.playerManager = go2.AddComponent<PlayerManager>();
    }

    public SceneController GetSceneManager()
    {
        return this.sceneManager;
    }

    public PlayerManager GetPlayerManager()
    {
        return this.playerManager;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    static PlayerManager instance;

    void Awake()
    {
        if (instance != null)
        {
            Destroy(this.gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(this);
        }
    }

    public int playerScore = 0;
    public int totalMoves = 0;
    public int timesDied = 0;
    // Game time tracked by TimerManager instance

    public int TotalScore(int value)
    {
        this.playerScore += value;
        Debug.Log("Score increased");
        return this.playerScore;
    }

    public void TotalMoves()
    {
        totalMoves += 1;
    }

    public void TotalDeaths()
    {
        timesDied += 1;
    }

    public void GameReset()
    {
        Debug.Log("Game Reset!");
        playerScore = 0;
        totalMoves = 0;
        timesDied = 0;
        Toolbox.GetInstance().GetTimer().ResetTimer();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public int playerScore = 0;
    public int totalMoves = 0;
    public int timesDied = 0;

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

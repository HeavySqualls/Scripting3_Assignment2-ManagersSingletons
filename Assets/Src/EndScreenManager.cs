using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndScreenManager : MonoBehaviour
{
    public Text totalScore;
    public Text totalTurns;
    public Text totalDeaths;
    public Text totalTime;

    void Update()
    {
        totalScore.text = "Score: " + Toolbox.GetInstance().GetPlayerManager().playerScore.ToString();
        totalTurns.text = "Turns: " +Toolbox.GetInstance().GetPlayerManager().totalMoves.ToString();
        totalDeaths.text = "Deaths: " + Toolbox.GetInstance().GetPlayerManager().timesDied.ToString();
        totalTime.text = "Time: " + Toolbox.GetInstance().GetTimer().minutes.ToString() + ":" + Toolbox.GetInstance().GetTimer().seconds.ToString();
    }
}

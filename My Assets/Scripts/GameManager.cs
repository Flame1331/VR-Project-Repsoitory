using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    //Tablet Text
    public TextMeshProUGUI Score1;
    public TextMeshProUGUI Score2;
    public TextMeshProUGUI Points;

    public TextMeshProUGUI exitPoints;
    public TextMeshProUGUI Range2Points;

    //Pistol Text
    public TextMeshProUGUI pistolAmmo;

    //variables
    private float Scores1;
    private float Scores2;
    public float tPoints;


    public void updateScore1(float score1)
    {
        Score1.text = "1: " + score1;
        Scores1 = score1;
    }

    public void updateScore2(float score2)
    {
        Score2.text = "2: " + score2;
        Scores2 = score2;
    }

    private void Update()
    {
        tPoints = Scores1 + Scores2;
    }

    public void updatePoints(float points)
    {
        Points.text = "Points: " + tPoints;
        Range2Points.text = "Current Points: " + tPoints;
        exitPoints.text = "Current Points: " + tPoints;

    }

    public void updateAmmo(int ammo)
    {
        pistolAmmo.text = "Ammo: " + ammo + "/10";
    }

    public void RESETS()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }


}

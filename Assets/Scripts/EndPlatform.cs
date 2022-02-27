using System;
using UnityEngine;
using UnityEngine.UI;

public class EndPlatform : MonoBehaviour
{
    [SerializeField]
    GameObject winScreen;

    [SerializeField]
    GameObject playerGO;

    [SerializeField]
    Text ScoreText;

    [SerializeField]
    Text FinalTime;

    public TimeSpan timer;

    private bool gameOver = false;

    private void OnCollisionEnter(Collision collision)
    {
        gameOver = true;
        winScreen.SetActive(true);
        Rigidbody playerRB = playerGO.GetComponent<Rigidbody>();
        playerRB.isKinematic = true;
        //.SetActive(false);
        FinalTime.text = "Your Time: " + timer.ToString("mm':'ss':'ff");
    }

    private void Update()
    {
        if (!gameOver)
        {
            timer += System.TimeSpan.FromSeconds(Time.deltaTime);
            ScoreText.text = "Time: " + timer.ToString("mm':'ss':'ff");
        }
    }
}

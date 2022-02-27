using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    [SerializeField]
     Text ScoreText;
    public TimeSpan timer;

    void Update () {

    timer += System.TimeSpan.FromSeconds(Time.deltaTime);
    ScoreText.text = "Time: "+ timer.ToString("mm':'ss':'ff");
 //ScoreText.text = "Time:"+ timer;
    
}
}

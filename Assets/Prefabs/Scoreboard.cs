using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Scoreboard : MonoBehaviour
{
	public Referee Referee;
	
	public int score;
	public TextMeshProUGUI TextMeshProUGUI;

	public void Start()
	{
		// Listen/Subscribe to event
		// Note, there's are no (). WHY? Because we're not actually
		// RUNNING the function. We're just recording what WILL run
		// later on.
		Referee.SawGoalEvent += AddOneScore;
	}

	public void AddOneScore()
    {
	    score = score + 1;
		TextMeshProUGUI.text = score.ToString();
    }
}

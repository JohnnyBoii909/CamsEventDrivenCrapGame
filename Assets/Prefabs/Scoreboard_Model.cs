using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Scoreboard_Model : MonoBehaviour
{
	public Referee referee;
	
	public int score;

	public delegate void SimpleDelegate(int score);
	public event SimpleDelegate ScoreUpdatedEvent;

	public void OnEnable()
	{
		// Listen/Subscribe to event
		// Note, there's are no (). WHY? Because we're not actually
		// RUNNING the function. We're just recording what WILL run
		// later on.
		referee.SawGoalEvent += AddOneScore;
	}

	private void OnDisable()
	{
		referee.SawGoalEvent -= AddOneScore;
	}

	public void AddOneScore(int teamIndex)
    {
	    score = score + 1;
	    
	    // Note: There's no UI code here at all! No TextMesh stuff, no tweening, no sounds.
	    // You should probably totally separate your UI from gameplay logic (View vs Model)
	    ScoreUpdatedEvent?.Invoke(score);
    }
}

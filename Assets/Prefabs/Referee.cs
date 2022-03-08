using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Referee : MonoBehaviour
{
	public Goal goal;
	public bool paidEnoughToThrowGame = false;

	// Minimal event definition. "Action" is just a predefined 'delegate'
	public event Action SawGoalEvent;
	
	public void Start()
	{
		// Listen/Subscribe to event
		// Note, there's are no (). WHY? Because we're not actually
		// RUNNING the function. We're just recording what WILL run
		// later on.
		goal.GoalEvent += SawGoal;
	}

	public void SawGoal()
    {
	    Debug.Log("I saw a goal. Am I getting paid enough??");
	    if (!paidEnoughToThrowGame)
	    {
		    SawGoalEvent?.Invoke();
	    }
    }
}

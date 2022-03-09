using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Commentator : MonoBehaviour
{
	public Referee referee;
	
	private void OnEnable()
	{
		// Listen/Subscribe to event
		// Note, there's are no (). WHY? Because we're not actually
		// RUNNING the function. We're just recording what WILL run
		// later on.
		referee.SawGoalEvent += SayGOOOOOOAAALLLL;
	}

	private void OnDisable()
	{
		referee.SawGoalEvent -= SayGOOOOOOAAALLLL;
	}

	public void SayGOOOOOOAAALLLL(int teamIndex)
    {
	    Debug.Log("Commentator: GOGOGOOGOOAOOAOAOOALAALALLALL");
    }
}

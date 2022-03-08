using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Commentator : MonoBehaviour
{
	public Referee Referee;
	
	private void Start()
	{
		// Listen/Subscribe to event
		// Note, there's are no (). WHY? Because we're not actually
		// RUNNING the function. We're just recording what WILL run
		// later on.
		Referee.SawGoalEvent += SayGOOOOOOAAALLLL;
	}

	public void SayGOOOOOOAAALLLL()
    {
	    Debug.Log("Commentator: GOGOGOOGOOAOOAOAOOALAALALLALL");
    }
}

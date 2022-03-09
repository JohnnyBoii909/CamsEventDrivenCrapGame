using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Referee : MonoBehaviour
{
	public Goal goal;
	public bool paidEnoughToThrowGame = false;

	// UH OH, in this case we want to send through a variable!
	// If this was a normal function we'd set up the definition with that variable type
	// Events can't do that in advance, because the destination function MIGHT NOT EXIST
	// 'Delegate' basically define what parameters get sent and received
	// The 'Signature'
	// Exactly like normal function definitions
	public delegate void SimpleDelegate(int teamIndex);

	// Minimal event definition. "Action" is just a predefined 'delegate'
	public event SimpleDelegate SawGoalEvent;
	
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
		    // TODO: There's only one goal at the moment
		    SawGoalEvent?.Invoke(0);
		    
		    // Alternative way to call event
		    // if(SawGoalEvent != null)
			    // SawGoalEvent(0);
	    }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudienceMember : MonoBehaviour
{
	public Referee Referee;
	
    void Start()
    {
	    // Listen/Subscribe to event
	    // Note, there's are no (). WHY? Because we're not actually
	    // RUNNING the function. We're just recording what WILL run
	    // later on.
	    Referee.SawGoalEvent += RefereeOnSawGoalEvent;
    }

    private void RefereeOnSawGoalEvent()
    {
	    Debug.Log("AudienceMember: YAY BALL WENT INTO A BOX!");
    }

}

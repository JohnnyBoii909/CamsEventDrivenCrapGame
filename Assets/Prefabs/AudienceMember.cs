using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudienceMember : MonoBehaviour
{
	public Referee referee;
	
    public void OnEnable()
    {
	    // Listen/Subscribe to event
	    // Note, there's are no (). WHY? Because we're not actually
	    // RUNNING the function. We're just recording what WILL run
	    // later on.
	    referee.SawGoalEvent += RefereeOnSawGoalEvent;
    }
    
    public void OnDisable()
    {
	    referee.SawGoalEvent -= RefereeOnSawGoalEvent;
    }

    private void RefereeOnSawGoalEvent(int teamIndex)
    {
	    Debug.Log("AudienceMember: YAY BALL WENT INTO A BOX!");
    }

}

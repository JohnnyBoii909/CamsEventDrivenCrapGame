using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
	// Minimal event definition. "Action" is just a predefined 'delegate'
	public event Action GoalEvent;
	
	private void OnTriggerEnter(Collider other)
	{
		if (other.GetComponent<Ball>())
		{
			// Tell anyone WHO'S LISTENING/SUBSCRIBED that something happened
			// The ? is a shortcut for a null check
			GoalEvent?.Invoke();
		}
	}
}

using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreBoard_View : MonoBehaviour
{
	public Scoreboard_Model scoreboardModel;

	public TextMeshProUGUI textMeshProUGUI;
	
	private void OnEnable()
	{
		scoreboardModel.ScoreUpdatedEvent += OnScoreUpdated;
	}

	private void OnDisable()
	{
		scoreboardModel.ScoreUpdatedEvent -= OnScoreUpdated;
	}

	private void OnScoreUpdated(int score)
	{
		// Here the UI designer can go nuts with hacky code to make it look cool.
		// No one depends on this code, because it's NOT PART OF THE GAMEPLAY.
		textMeshProUGUI.text = "Score : "+score.ToString();
	}
}

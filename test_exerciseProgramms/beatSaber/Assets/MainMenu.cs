using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
	
    public void StartGame()
	{
		SceneManager.LoadScene("Game");
	}
	
	public void QuitGame()
	{
		UnityEditor.EditorApplication.isPlaying = false;		// Um im Editor zu schließen, kann auskommentiert werden
		Application.Quit();
	}
}

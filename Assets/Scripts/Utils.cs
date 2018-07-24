using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public static class Utils  {

	public static void LoadNextScene(){

		int myIndex = SceneManager.GetActiveScene().buildIndex;
        int nextIndex = (myIndex+1) % SceneManager.sceneCountInBuildSettings;

        // SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        SceneManager.LoadScene(nextIndex);
	}

	public static void LoadCurrentScene(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
	}
}

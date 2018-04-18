using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Retry : MonoBehaviour {
    string sceneSelection;
	public void Restart()
    {
        SceneManager.LoadScene(sceneSelection);
    }
    public void CharacterSelection()
    {
        SceneManager.LoadScene("Selection");
    }
    private void Start()
    {
        sceneSelection = PlayerPrefs.GetString("Scene Selection");
    }
    // Update is called once per frame
    void Update () {
		
	}
}

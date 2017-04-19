using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIMgr : MonoBehaviour {

	public void OnClickStartBtn()
	{
		Debug.Log ("Click Button");
		SceneManager.LoadScene ("scLevel01");
		SceneManager.LoadScene ("scPlay", LoadSceneMode.Additive);
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class SplashVideo : MonoBehaviour {

	VideoPlayer video;
	public float timeToScene = 0.0f;

	// Use this for initialization
	void Start () {

		video = this.gameObject.GetComponent<VideoPlayer> ();
		video.loopPointReached += EndReached;
	}
	
	// Update is called once per frame
	void Update () {

	}

	void EndReached(VideoPlayer vp)
	{
		StartCoroutine (DelayedLoad());	
	}

	IEnumerator DelayedLoad()
	{
		yield return new WaitForSeconds (timeToScene);
		SceneManager.LoadScene ("main");
	}
}

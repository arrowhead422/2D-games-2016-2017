using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {

	public GameObject currenCheckPoint;

	private PlayerController player;

	// Use this for initialization
	void Start () {
		player = FindObjectOfType<PlayerController> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void RespawnPlayer(){
		Debug.Log ("Player Respawn");
		player.transform.position = currenCheckPoint.transform.position;
	}
}

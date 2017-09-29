using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player : MonoBehaviour {
	public HUD hud;
	public string username;
	public bool human;

public WorldObject SelectedObject { get; set; }
	

	// Use this for initialization
	void Start () {
		hud = GetComponentInChildren< HUD >();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

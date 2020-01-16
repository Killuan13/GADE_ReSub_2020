using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wizards : Unit {

	// Use this for initialization
	void Start () {
        hp = 20;
        maxHp = hp;
        atk = 4;
        range = 2;
        spd = 1;
        team = 3;
        GetComponent<MeshRenderer>().material = mat[team - 1];
        gameObject.tag = "team 3";
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

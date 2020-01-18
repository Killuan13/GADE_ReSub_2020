using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WizardUnit : Unit {

	// Use this for initialization
	void Start () {
        hp = 10;
        maxHp = hp;
        atk = 2;
        range = 1;
        spd = 1;
        team = 3;
        gameObject.tag = "team 3";
        GetComponent<MeshRenderer>().material = mat[team];
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}

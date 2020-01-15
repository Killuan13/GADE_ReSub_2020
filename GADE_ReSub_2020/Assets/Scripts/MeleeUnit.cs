using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeleeUnit : Unit {

	// Use this for initialization
	void Start () {
        hp = 10;
        maxHp = hp;
        atk = 2;
        range = 1;
        spd = 1;
        team = Random.Range(1, 3);
        GetComponent<MeshRenderer>().material = mat[team - 1];
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

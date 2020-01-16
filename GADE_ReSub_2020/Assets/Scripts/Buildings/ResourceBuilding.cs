﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourceBuilding : Building {

	// Use this for initialization
	void Start () {
        hp = 40;
        maxHp = hp;
        team = Random.Range(1, 3);
        GetComponent<MeshRenderer>().material = mat[team - 1];
        switch (team)
        {
            case 1:
                gameObject.tag = "team 1";
                break;
            case 2:
                gameObject.tag = "team 2";
                break;
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}

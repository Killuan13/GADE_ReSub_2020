using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEngine : MonoBehaviour {
    [SerializeField] GameObject[] options = new GameObject[5];
    [SerializeField] static int MIN_X = -10, MAX_X = 10, MIN_Z = -10, MAX_Z = 10, UNITS = 6;
	// Use this for initialization
	void Start () {
		for (int i = 0; i < UNITS; i++)
        {
            CreateUnit();
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void CreateUnit()
    {
        GameObject unit = Instantiate(options[Random.Range(0, 5)]);
        unit.transform.position = new Vector3(Random.Range(MIN_X, MAX_X - 1), 0, Random.Range(MIN_Z, MAX_Z - 1));

    }
}

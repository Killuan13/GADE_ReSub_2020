using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resource : MonoBehaviour {
    [SerializeField] protected int resource;

    public int numResource
    {
        get
        {
            return numResource;
        }
    }

    // Use this for initialization
    void Start () {
        resource = Random.Range(0, 101);
	}
	
	// Update is called once per frame
	void Update ()
    {
        int resourceTotal = 0;
        GameObject[] resources = GameObject.FindGameObjectsWithTag("Resource");
        foreach (GameObject o in resources)
        {
            resourceTotal += o.GetComponent<Resource>().numResource;
        }

	}
}

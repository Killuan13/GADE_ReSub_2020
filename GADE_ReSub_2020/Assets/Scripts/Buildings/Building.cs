using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Building : MonoBehaviour {
    [SerializeField] protected int hp;
    [SerializeField] protected int maxHp;
    [SerializeField] protected int team;
    [SerializeField] protected Material[] mat;

    public int Hp
    {
        get
        {
            return hp;
        }
        set
        {
            hp = value;
        }
    }
    public int MaxHp
    {
        get
        {
            return maxHp;
        }
    }
    public int Team
    {
        get
        {
            return team;
        }
    }
    public Material[] Mat
    {
        get
        {
            return mat;
        }
    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

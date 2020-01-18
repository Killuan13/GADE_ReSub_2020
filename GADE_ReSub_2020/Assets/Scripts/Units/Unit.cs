using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public abstract class Unit : MonoBehaviour {
    [SerializeField] protected int hp;
    [SerializeField] protected int maxHp;
    [SerializeField] protected int atk;
    [SerializeField] protected float spd;
    [SerializeField] protected int range;
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
    public int Atk
    {
        get
        {
            return atk;
        }
    }
    public float Spd
    {
        get
        {
            return spd;
        }
    }
    public int Range
    {
        get
        {
            return range;
        }
        set
        {
            range = value;
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
       if (!IsInRange(GetClosestUnit()))
        {
            transform.position = Vector3.MoveTowards(transform.position, GetClosestUnit().transform.position, spd * Time.deltaTime);
        }
    }

    protected bool IsInRange(GameObject Enemy)
    {
        bool returnVal = false;
        if (Vector3.Distance(transform.position, Enemy.transform.position) <= range)
        {
            return true;
        }
        else return returnVal;
    }

    protected GameObject GetClosestUnit()
    {
        GameObject unit = null;
        GameObject[] units = null;
        GameObject[] wizards = null;
        switch (team)
        {
            case 1:
                units = GameObject.FindGameObjectsWithTag("team 2");
                wizards = GameObject.FindGameObjectsWithTag("team 3");
                int tempSize = units.Length;
                Array.Resize(ref units, units.Length + wizards.Length);
                for (int i = tempSize; i < units.Length; i++)
                {
                    units[i] = wizards[i - tempSize];
                }
                break;
            case 2:
                units = GameObject.FindGameObjectsWithTag("team 1");
                wizards = GameObject.FindGameObjectsWithTag("team 3");
                tempSize = units.Length;
                Array.Resize(ref units, units.Length + wizards.Length);
                for (int i = tempSize; i < units.Length; i++)
                {
                    units[i] = wizards[i - tempSize];
                }
                break;
            case 3:
                units = GameObject.FindGameObjectsWithTag("team 1");
                wizards = GameObject.FindGameObjectsWithTag("team 2");
                tempSize = units.Length;
                Array.Resize(ref units, units.Length + wizards.Length);
                for (int i = tempSize; i < units.Length; i++)
                {
                    units[i] = wizards[i - tempSize];
                }
                break;
        }
        float distance = 9999;
        foreach (GameObject temp in units)
        {
            float tempDist = Vector3.Distance(transform.position, temp.transform.position);
            if (tempDist <= distance)
            {
                distance = tempDist;
                unit = temp;
            }
        }
        return unit;
    }
}

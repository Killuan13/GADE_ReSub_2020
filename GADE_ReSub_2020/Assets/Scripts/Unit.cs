using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour {

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
            returnVal = true;
        }
        else
        {
            returnVal = false;
        }
        return returnVal;
    }

    protected GameObject GetClosestUnit()
    {
        GameObject unit = null;
        GameObject[] units = null;
        switch (team)
        {
            case 1:
                GameObject.FindGameObjectsWithTag("team 2");
                break;
            case 2:
                GameObject.FindGameObjectsWithTag("team 1");
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

    protected int Attack()
    {
        hp -= atk;
        if (hp <= 0)
        {
            Destroy(gameObject);
        }
        return atk;
    }
}

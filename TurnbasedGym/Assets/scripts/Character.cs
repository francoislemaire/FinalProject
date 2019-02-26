using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public int maxHP;
    public int currentHP;
    public int maxAP;
    public int currentAP;
    public AttackType attackType;

    public float AttackRange;

    public int armor;
    public AttackType[] immunities;
    public AttackType[] vulnerabilities;

    public float accuracy;

    public int initiative;

    public bool flying;






    // Start is called before the first frame update
    void Start()
    {
        currentHP = maxHP;
        currentAP = maxAP;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

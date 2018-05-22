using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class HPScript : MonoBehaviour {

    public Text textHP;
    public static int HP;

    public int maxHP;
    // Use this for initialization
    void Start()
    {
        HP = maxHP;
    }

    // Update is called once per frame
    void Update()
    {
        textHP.text = "HP:" + HP;

        if (HP >= maxHP)
        {
            HP = maxHP;
        }
        if (HP < 0)
        {
            HP = 0;
        }
    }
}

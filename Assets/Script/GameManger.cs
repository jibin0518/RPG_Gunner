using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManger : MonoBehaviour
{
    public Image mod;
    public Weapon player_weapon;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(player_weapon.Handgunmod)
        {
            mod.color = Color.blue;
            Debug.Log("2");
        }
        if (player_weapon.ShotGun == true)
        {
            mod.color = Color.red;
        }
        if (player_weapon.Rifle == true)
        {
            mod.color = Color.blue;
        }
    }
}

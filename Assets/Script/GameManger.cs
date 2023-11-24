using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManger : MonoBehaviour
{
    public Image mod_up;
    public Image mod_Down;
    public Image mod_Right;
    public Image mod_Left;
    public Weapon player_weapon;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(player_weapon.Handgunmod)
        {
            mod_up.color = Color.blue;
            mod_Down.color = Color.blue;
            mod_Left.color = Color.blue;
            mod_Right.color = Color.blue;
            Debug.Log("2");
        }
        if (player_weapon.ShotGun == true)
        {
            mod_up.color = Color.blue;
            mod_Down.color = Color.blue;
            mod_Left.color = Color.blue;
            mod_Right.color = Color.blue;
        }
        if (player_weapon.Rifle == true)
        {
            mod_up.color = Color.blue;
            mod_Down.color = Color.blue;
            mod_Left.color = Color.blue;
            mod_Right.color = Color.blue;
        }
    }
}

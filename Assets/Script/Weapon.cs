using StarterAssets;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    Animator anim;

    private bool HandGunAim;
    public int HandAImCnt = 0;

    public bool Handgun;
    public bool Rifle;
    public bool ShotGun;

    private StarterAssetsInputs inputsystem;

    void Start()
    {
        inputsystem = GetComponent<StarterAssetsInputs>();
        anim = GetComponent<Animator>();
    }
    void Update()
    {
        HandAImCnt = HandAImCnt  % 2;

        if (Input.GetKeyDown(KeyCode.E))
        {
            anim.SetTrigger("HandSkill");
        }
        
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            Handgun = true;
            Rifle = false;
            anim.SetBool("ShotGunmod", false);
            ShotGun = false;
            anim.SetBool("Riflemod", false);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            ShotGun = true;
            anim.SetBool("ShotGunmod", true);
            Handgun = false;
            anim.SetBool("Handmod", false);
            Rifle = false;
            anim.SetBool("Riflemod", false);
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            Rifle = true;
            anim.SetBool("Riflemod", true);
            Handgun = false;
            anim.SetBool("Handmod", false);
            ShotGun = false;
            anim.SetBool("ShotGunmod", false);
        }

        if (Input.GetKeyDown(KeyCode.X))
        {
            Rifle = false;
            anim.SetBool("Riflemod", false);
            Handgun = false;
            anim.SetBool("Handmod", false);
            ShotGun = false;
            anim.SetBool("ShotGunmod", false);
        }

        if (Input.GetMouseButtonUp(1) && Handgun)
        {
            anim.SetBool("HandGunAim", false);
            HandGunAim = true;
        }

        if (Input.GetMouseButtonDown(1) && Handgun)
        {
            anim.SetBool("HandGunAim",true);
            HandGunAim = true;
        }
        if (Input.GetMouseButtonDown(0) && HandGunAim)
        {
            anim.SetTrigger("Fire");
        }

        if (inputsystem.aim)
        {

        }
    }
}

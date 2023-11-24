using StarterAssets;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Weapon : MonoBehaviour
{
    Animator anim;

    private bool HandGunAim;
    public int HandAImCnt = 0;
    private bool handAiming=false;

    public bool Handgunmod;
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
        
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            Handgunmod = true;
            Debug.Log("1");
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            anim.SetTrigger("HandSkill");
        }

        if (Input.GetKeyDown(KeyCode.X))
        {
            Rifle = false;
            anim.SetBool("Riflemod", false);
            Handgunmod = false;
            anim.SetBool("Handmod", false);
            ShotGun = false;
            anim.SetBool("ShotGunmod", false);
        }
        if (Input.GetMouseButtonDown(0) && HandGunAim)
        {
            anim.SetTrigger("Fire");
        }

        Aiming();
    }

    void Aiming()
    {
        if (inputsystem.aim && Handgunmod && !handAiming)
        {
            anim.SetBool("HandGunAim", true);
            HandGunAim = true;
            handAiming = true;
        }
        if (inputsystem.aim && Handgunmod && handAiming)
        {
            anim.SetBool("HandGunAim", false);
            HandGunAim = false;
            handAiming = false;
        }
    }
}

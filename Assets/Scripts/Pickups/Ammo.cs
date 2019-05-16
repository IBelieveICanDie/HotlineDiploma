﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ammo : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        PlayerControl player = other.gameObject.GetComponent<PlayerControl>();
        if (player)
        {
            player.CurrentWeapon.ammo = player.CurrentWeapon.maxAmmo;
            Destroy(gameObject);
        }
    }
}
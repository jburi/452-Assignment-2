/*
 * Jake Buri
 * ElementalBehavior.cs
 * Assignment 2
 * Changes Weapon in the first slot to look like the weapon is changing type
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour, ElementalBehavior
{
	public void Element()
	{
        PlayerWeaponsManager Player = GetComponentInParent<PlayerWeaponsManager>();
        WeaponController activeWeapon = Player.GetActiveWeapon();
        WeaponController AirWeapon = Resources.Load("Prefabs/Weapons/Weapon_Blaster_Air") as WeaponController;
        Player.RemoveWeapon(activeWeapon);
        Player.AddWeapon(AirWeapon);
    }
}
public class Water : MonoBehaviour, ElementalBehavior
{
	public void Element()
	{
        PlayerWeaponsManager Player = GetComponentInParent<PlayerWeaponsManager>();
        WeaponController activeWeapon = Player.GetActiveWeapon();
        WeaponController AirWeapon = Resources.Load("Prefabs/Weapons/Weapon_Blaster_Air") as WeaponController;
        Player.RemoveWeapon(activeWeapon);
        Player.AddWeapon(AirWeapon);
    }
}
public class Earth : MonoBehaviour, ElementalBehavior
{
	public void Element()
	{
        PlayerWeaponsManager Player = GetComponentInParent<PlayerWeaponsManager>();
        WeaponController activeWeapon = Player.GetActiveWeapon();
        WeaponController AirWeapon = Resources.Load("Prefabs/Weapons/Weapon_Blaster_Air") as WeaponController;
        Player.RemoveWeapon(activeWeapon);
        Player.AddWeapon(AirWeapon);
    }
}

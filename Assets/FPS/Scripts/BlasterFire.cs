/*
 * Jake Buri
 * BlasterFire.cs
 * Assignment 2
 * Changes weapon behavior to fire
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlasterFire : WeaponController
{
    public ElementalBehavior element;

    public void Awake()
	{
		//Change behavior to fire element
		element = new Fire();
	}
}

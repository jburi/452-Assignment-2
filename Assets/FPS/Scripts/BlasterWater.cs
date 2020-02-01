/*
 * Jake Buri
 * BlasterWater.cs
 * Assignment 2
 * Changes weapon behavior to water
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlasterWater : WeaponController
{
    public ElementalBehavior element;

    public void Awake()
	{
		//Change behavior to water element
		element = new Water();
	}
}

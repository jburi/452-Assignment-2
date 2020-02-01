/*
 * Jake Buri
 * BlasterEarth.cs
 * Assignment 2
 * Changes weapon behavior to earth
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlasterEarth : WeaponController
{
    public ElementalBehavior element;

    public void Awake()
	{
		//Change behavior to earth element
		element = new Earth();
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlasterEarth : WeaponController
{
	public void Awake()
	{
		//Change behavior to earth element
		element = new Earth();
	}
}

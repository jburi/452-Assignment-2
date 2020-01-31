using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlasterFire : WeaponController
{
	public void Awake()
	{
		//Change behavior to fire element
		element = new Fire();
	}
}

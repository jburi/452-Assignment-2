using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlasterWater : WeaponController
{
	public void Awake()
	{
		//Change behavior to water element
		element = new Water();
	}
}

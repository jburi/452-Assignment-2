using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlasterAir : WeaponController
{
	
	public void Awake()
	{
		//Change behavior to air element
		element = new Air();
	}
}

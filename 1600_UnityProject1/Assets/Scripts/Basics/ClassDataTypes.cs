using UnityEngine;
using System.Collections;

public class ClassDataTypes : MonoBehaviour 
{
	public class Bag
	{
		public int weapons;
		public Color weaponColor;
	
		public Bag()
		{
			weapons = 4;
			weaponColor = Color.magenta;
		}	
		
		public Bag(int _weapons, Color _weaponColor)
		{
			weapons = _weapons;
			weaponColor = _weaponColor;
		}
		
	}
	
	void Start()
	{
		int num1 = 3;
		int num2 = num1;
		
		num2 = 5;
		
		Bag backpack = new Bag(4, Color.magenta);
		Bag backpack2 = backpack;
		
		backpack2.weapons = 10;
		backpack2.weaponColor = Color.blue;
	}
}	
using UnityEngine;
using System.Collections;

public static class ExtensionMethods {

	public static void ChangeAlpha(this Material mat, float alpha)
	{
		Color oldColor = mat.color;
		Color newColor = new Color(oldColor.r, oldColor.b, oldColor.g, alpha);          
		mat.SetColor("_Color", newColor);               
	}
}

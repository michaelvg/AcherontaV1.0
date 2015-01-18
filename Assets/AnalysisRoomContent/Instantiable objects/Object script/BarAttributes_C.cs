using UnityEngine;
using System.Collections;

public class BarAttributes_C : MonoBehaviour {
	
	public int isType; 
	public int colorMin  = 0; 
	public int colorMax  = 6; 
	public float Hspeed = 2.0f; 
	public int partnerID; 
	public int salesVolume;
	public float salesVolumeC; 
	public string risk; 
	public string potential; 
	public int location; 
	
	// Use this for initialization
	void Start () {
			switch (risk) {
			case "High": 
				gameObject.renderer.material.color = Color.red;
				break;
			case "Medium": 
				gameObject.renderer.material.color = Color.gray;
				break;
			case "Low":
				gameObject.renderer.material.color = Color.green;
				break;
			}
		if (salesVolumeC != 0) {			
			gameObject.transform.localScale = new Vector3(gameObject.transform.localScale.x,salesVolumeC,gameObject.transform.localScale.z); 
			//gameObject.transform.position.y = 0f; 
		}  
	}
	
	// Update is called once per frame
	void Update () {
		// Trigger the destruction of all objects
		if(Input.GetKeyDown ("w")){
			Destroy(gameObject);
		} 	
	}
}


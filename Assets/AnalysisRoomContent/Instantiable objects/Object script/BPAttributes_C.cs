using UnityEngine;
using System.Collections;

public class BPAttributes_C : MonoBehaviour {

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
		if (string.IsNullOrEmpty(risk)) {
						isType = Random.Range (colorMin, colorMax); 
						switch (isType) {
						case 1:
								gameObject.renderer.material.color = Color.gray;
								break; 
						case 2:
								gameObject.renderer.material.color = Color.black;
								break;
						case 3:
								gameObject.renderer.material.color = Color.blue;
								break;
						case 4:
								gameObject.renderer.material.color = Color.gray;
								break;
						case 5:
								gameObject.renderer.material.color = Color.cyan;
								break;
						}
				} 
		else {
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
			}

		if (salesVolumeC != 0) {			
			gameObject.transform.localScale += Vector3.one * salesVolumeC;
			}  
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey ("z")){
			if(isType == 3){
				gameObject.transform.Translate(Vector2.right*Hspeed*Time.deltaTime);
			}
		} 
		if(Input.GetKey ("e")){
			if(isType == 1){
				gameObject.transform.Translate(Vector3.left*Hspeed*Time.deltaTime);
			}
		}  
		// Trigger the destruction of all objects
		if(Input.GetKeyDown ("w")){
			Destroy(gameObject);
		} 	
	}
}

using LitJson;
using UnityEngine;
using System.Collections;
using System;

public class LoadingScriptBub : MonoBehaviour {
	
	public GameObject myInstBall; 
	public BPAttributes_C MyScript; 
  
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		// Instantiate based on external data 
		if(Input.GetKeyDown ("l")){ 
			StartCoroutine("LoadData");
		}
		// Trigger the destruction of all objects
		if(Input.GetKeyDown ("w")){
			Destroy(gameObject);
		}  
	}
	
	IEnumerator LoadData() {
		//Load JSON data from a URL
		string url = "file://c:/test/BPData";
		WWW BPdata = new WWW(url);

		//Load the data and yield (wait) till it's ready before we continue executing the rest of this method.
		yield return BPdata;
		if (BPdata.error == null)
		{
			//Sucessfully loaded the JSON string
			Debug.Log("Loaded following JSON string" + BPdata.text);
			//Process the data in JSON file
			ProcessData(BPdata.text);
		}
		else
		{
			Debug.Log("ERROR: " + BPdata.error);
		}
	}
	
	private void ProcessData(String JsonString)
		{

		JsonData BpString= JsonMapper.ToObject(JsonString);
		Debug.Log (BpString["d"]["results"].Count);
		float minVolume = 0; 
		float maxVolume = 0; 
		for (int i = 0; i<BpString["d"]["results"].Count; i++) 
		{ if ( minVolume == 0)
			{ minVolume = float.Parse(BpString["d"]["results"][i]["Salesvolume"].ToString());}
		  if ( int.Parse(BpString["d"]["results"][i]["Salesvolume"].ToString()) < minVolume )
			{ minVolume = float.Parse(BpString["d"]["results"][i]["Salesvolume"].ToString());}
		  if ( int.Parse(BpString["d"]["results"][i]["Salesvolume"].ToString()) > maxVolume )
			{ maxVolume = float.Parse(BpString["d"]["results"][i]["Salesvolume"].ToString());}
		}

		for(int i = 0; i<BpString["d"]["results"].Count; i++)
			{
			Vector3 pos = new Vector3(UnityEngine.Random.Range(-6.00F,6.00F),UnityEngine.Random.Range(0.50F,3.50F),UnityEngine.Random.Range(-6.00F,6.00F)); 
			GameObject ball = Instantiate(myInstBall, pos, Quaternion.identity) as GameObject;
			ball.name = "Ball" + i; 
			MyScript = ball.GetComponent<BPAttributes_C>();
			MyScript.partnerID = int.Parse(BpString["d"]["results"][i]["Partner"].ToString());
			MyScript.salesVolume = int.Parse(BpString["d"]["results"][i]["Salesvolume"].ToString());
			MyScript.salesVolumeC = (float.Parse(BpString["d"]["results"][i]["Salesvolume"].ToString())/ maxVolume )*0.2f;
			MyScript.risk = BpString["d"]["results"][i]["Risk"].ToString();
			MyScript.potential = BpString["d"]["results"][i]["Potential"].ToString();
			MyScript.location = int.Parse(BpString["d"]["results"][i]["Location"].ToString());
		} 
	}
	
}
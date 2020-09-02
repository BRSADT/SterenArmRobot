using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {
public GameObject motor1;
	// Use this for initialization
	public int x,y,z;
void OnClick(){
	Debug.Log("hola");
	z=z+1;
	Debug.Log(x);
   motor1.transform.Rotate(x,y,z, Space.Self);


}


	void Start () {
	Debug.Log("INICIO");
		x=0;
		y=0;
		z=0;

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

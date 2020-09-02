using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_ratio : MonoBehaviour {
    //Script que establece la relacion de aspecto de la camara
    public Camera cam;

    float vol;

	void Start ()
    {
        //Si no se establece un valor fijo, el valor sera calculado de manera automatica segun el tamaño de la ventana causando que no siempre se cubra el mismo rango de vision
        cam.aspect = 2.3f;
        //Cambiar el volumen al iniciar
        vol = PlayerPrefs.GetFloat("vol", vol);
        AudioListener.volume = vol;
    }
	

}

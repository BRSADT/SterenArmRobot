using System.Collections;
using System.Collections.Generic;
using System.IO.Ports;
using UnityEngine;

public class Botones : MonoBehaviour {
	
  SerialPort serialPort = new SerialPort("COM9",9600);

	bool join1=false;
		public GameObject brazo;
	public GameObject cuerpoMovMotor1;
		public GameObject cuerpoMovMotor2;
			public GameObject cuerpoMovMotor3;
public GameObject camara;
public GameObject motor2;
public GameObject cuerpomotor2;
public GameObject tornillo2;
public GameObject caja2;
public GameObject tornillo3;
public GameObject motor3;
public GameObject brazoizq;
public GameObject brazoder;
public GameObject cuerpomotor3;
public GameObject caja3;
public GameObject base3;
public GameObject manoder;
public GameObject manoizq;
public GameObject motor1; 
	public int x,y,z;
public void Moverizq1()
{
motor2.transform.parent=null;
cuerpomotor2.transform.parent=null;
tornillo2.transform.parent=null;
caja2.transform.parent=null;
tornillo3.transform.parent=null;
motor3.transform.parent=null;
brazoizq.transform.parent=null;
brazoder.transform.parent=null;
cuerpomotor3.transform.parent=null;
caja3.transform.parent=null;
base3.transform.parent=null;
manoder.transform.parent=null;
manoizq.transform.parent=null;
motor1.transform.parent=null;
cuerpoMovMotor2.transform.parent=null;
cuerpoMovMotor3.transform.parent=null;

cuerpoMovMotor2.transform.parent=cuerpoMovMotor1.transform;
cuerpoMovMotor3.transform.parent=cuerpoMovMotor1.transform;
motor2.transform.parent=cuerpoMovMotor1.transform;
cuerpomotor2.transform.parent=cuerpoMovMotor1.transform;
tornillo2.transform.parent=cuerpoMovMotor1.transform;
caja2.transform.parent=cuerpoMovMotor1.transform;
tornillo3.transform.parent=cuerpoMovMotor1.transform;
motor3.transform.parent=cuerpoMovMotor1.transform;
brazoizq.transform.parent=cuerpoMovMotor1.transform;
brazoder.transform.parent=cuerpoMovMotor1.transform;
cuerpomotor3.transform.parent=cuerpoMovMotor1.transform;
caja3.transform.parent=cuerpoMovMotor1.transform;
base3.transform.parent=cuerpoMovMotor1.transform;
manoder.transform.parent=cuerpoMovMotor1.transform;
manoizq.transform.parent=cuerpoMovMotor1.transform;
motor1.transform.parent=cuerpoMovMotor1.transform;
z--;
cuerpoMovMotor1.transform.Rotate(0,0,-10, Space.Self);
serialPort.Write("izq1");
Debug.Log("izq1");
}
public void Moverder1()
{
motor2.transform.parent=null;
cuerpomotor2.transform.parent=null;
tornillo2.transform.parent=null;
caja2.transform.parent=null;
tornillo3.transform.parent=null;
motor3.transform.parent=null;
brazoizq.transform.parent=null;
brazoder.transform.parent=null;
cuerpomotor3.transform.parent=null;
caja3.transform.parent=null;
base3.transform.parent=null;
manoder.transform.parent=null;
manoizq.transform.parent=null;
motor1.transform.parent=null;
cuerpoMovMotor2.transform.parent=null;
cuerpoMovMotor3.transform.parent=null;

cuerpoMovMotor2.transform.parent=cuerpoMovMotor1.transform;
cuerpoMovMotor3.transform.parent=cuerpoMovMotor1.transform;
motor2.transform.parent=cuerpoMovMotor1.transform;
cuerpomotor2.transform.parent=cuerpoMovMotor1.transform;
tornillo2.transform.parent=cuerpoMovMotor1.transform;
caja2.transform.parent=cuerpoMovMotor1.transform;
tornillo3.transform.parent=cuerpoMovMotor1.transform;
motor3.transform.parent=cuerpoMovMotor1.transform;
brazoizq.transform.parent=cuerpoMovMotor1.transform;
brazoder.transform.parent=cuerpoMovMotor1.transform;
cuerpomotor3.transform.parent=cuerpoMovMotor1.transform;
caja3.transform.parent=cuerpoMovMotor1.transform;
base3.transform.parent=cuerpoMovMotor1.transform;
manoder.transform.parent=cuerpoMovMotor1.transform;
manoizq.transform.parent=cuerpoMovMotor1.transform;
motor1.transform.parent=cuerpoMovMotor1.transform;
z++;
cuerpoMovMotor1.transform.Rotate(0,0,10, Space.Self);
serialPort.Write("der1");
Debug.Log("der1");
}



public void MoverArriba2()

{
		cuerpoMovMotor2.transform.parent=brazo.transform;
	cuerpoMovMotor3.transform.parent=brazo.transform;
	motor2.transform.parent=null;
cuerpomotor2.transform.parent=null;
tornillo2.transform.parent=null;
caja2.transform.parent=null;
tornillo3.transform.parent=null;
motor3.transform.parent=null;
brazoizq.transform.parent=null;
brazoder.transform.parent=null;
cuerpomotor3.transform.parent=null;
caja3.transform.parent=null;
base3.transform.parent=null;
manoder.transform.parent=null;
manoizq.transform.parent=null;
motor1.transform.parent=null;


cuerpoMovMotor3.transform.parent=cuerpoMovMotor2.transform;
motor2.transform.parent=cuerpoMovMotor2.transform;

tornillo2.transform.parent=cuerpoMovMotor2.transform;

tornillo3.transform.parent=cuerpoMovMotor2.transform;
motor3.transform.parent=cuerpoMovMotor2.transform;
brazoizq.transform.parent=cuerpoMovMotor2.transform;
brazoder.transform.parent=cuerpoMovMotor2.transform;
cuerpomotor3.transform.parent=cuerpoMovMotor2.transform;
caja3.transform.parent=cuerpoMovMotor2.transform;
base3.transform.parent=cuerpoMovMotor2.transform;
manoder.transform.parent=cuerpoMovMotor2.transform;
manoizq.transform.parent=cuerpoMovMotor2.transform;


x=x+1;

cuerpoMovMotor2.transform.Rotate(x,0,0, Space.Self);
serialPort.Write("2");



}

public void MoverArribaMot3()
{
motor2.transform.parent=null;
cuerpomotor2.transform.parent=null;
tornillo2.transform.parent=null;
caja2.transform.parent=null;
tornillo3.transform.parent=null;
motor3.transform.parent=null;
brazoizq.transform.parent=null;
brazoder.transform.parent=null;
cuerpomotor3.transform.parent=null;
caja3.transform.parent=null;
base3.transform.parent=null;
manoder.transform.parent=null;
manoizq.transform.parent=null;
motor1.transform.parent=null;



tornillo3.transform.parent=cuerpoMovMotor3.transform;
motor3.transform.parent=cuerpoMovMotor3.transform;
manoder.transform.parent=cuerpoMovMotor3.transform;
manoizq.transform.parent=cuerpoMovMotor3.transform;
cuerpomotor3.transform.parent=cuerpoMovMotor3.transform;
caja3.transform.parent=cuerpoMovMotor3.transform;
base3.transform.parent=cuerpoMovMotor3.transform;



x=x+1;

cuerpoMovMotor3.transform.Rotate(x,0,0, Space.Self);
serialPort.Write("3");
Debug.Log(x);

}
	// Use this for initialization
	void Start () {
		serialPort.Open();
	x=0;
		y=0;
		z=0;		

         
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

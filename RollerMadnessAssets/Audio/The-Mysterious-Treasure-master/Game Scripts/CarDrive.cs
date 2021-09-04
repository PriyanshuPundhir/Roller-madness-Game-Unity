using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;

public class CarDrive : MonoBehaviour {

	public GameObject PlayerCamera,CarCamera;
	public Transform PlayerTransform;
	public Transform CarTransform;
	public GameObject player;
	public GameObject car;
	public GameObject MiniMap;
	public bool CarActive;

	void Start()
	{
		CarActive = false;
		car.SetActive (false);
	}

	void Update()
	{
		if(CarActive == true)
		{
			PlayerTransform.position = CarTransform.position;
		}
		if(Input.GetButtonDown("Vehicle") && CarActive == false)
		{
			
			CarActive = true;
			CarTransform.position = PlayerTransform.position;
			car.SetActive (true);
			CarCamera.SetActive (true);
			PlayerCamera.SetActive (false);
			player.SetActive (false);
		}
		else if(Input.GetButtonDown("Vehicle") && CarActive == true)
		{
			CarActive = false;
			PlayerTransform.position = CarTransform.position;
			car.SetActive (false);
			CarCamera.SetActive (false);
			PlayerCamera.SetActive (true);
			player.SetActive (true);
		}
	}
}

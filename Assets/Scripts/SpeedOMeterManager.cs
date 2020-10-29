using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using VehicleBehaviour;

public class SpeedOMeterManager : MonoBehaviour
{
    
    public GameObject SpeedLabel;
    public GameObject BoostLabel;
    public GameObject Car;
    
    // Update is called once per frame
    void Update()
    {
      SpeedLabel.GetComponent<Text>().text = "" + (uint) Car.GetComponent<CarControllerRacing>().kmh + " km/h";// WheelVehicle.Speed.get;
      BoostLabel.GetComponent<Text>().text = "" + (int)((float) Car.GetComponent<CarControllerRacing>().nitro) + "%";// WheelVehicle.Speed.get;
    }
}

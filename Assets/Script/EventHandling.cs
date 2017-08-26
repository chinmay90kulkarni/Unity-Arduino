using UnityEngine;
using System.Collections;
using System.IO.Ports;

public class EventHandling : MonoBehaviour {
	SerialPort sp = new SerialPort("COM3", 9600);

	void Start()
	{
		sp.Open ();
	}

	public void hit()
	{
		sp.Write ("A");
	}
	public void miss()
	{
		sp.Write ("B");

	}

}
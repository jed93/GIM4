using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerController : MonoBehaviour {

	void OnTriggerEnter(Collider other)
	{
		if (other.GetComponent<Collider>().CompareTag("Player"))
		{
			AudioSource sound = other.GetComponent<AudioSource>();
			sound.Play();
		}
	}
}
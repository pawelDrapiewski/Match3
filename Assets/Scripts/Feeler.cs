using UnityEngine;
using System.Collections;

public class Feeler : MonoBehaviour {

public Gem owner;

	void OnTriggerEnter(Collider c)
	{
		if (c.tag == "Gem")
		{
			owner.AddNeighbour(c.GetComponent<Gem>());
		}
	}

	void OnTriggerExit(Collider c)
	{
		if (c.tag == "Gem")
		{
			owner.RemoveNeighbour(c.GetComponent<Gem>());
		}
	}
}

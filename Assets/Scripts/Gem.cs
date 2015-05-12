using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Gem : MonoBehaviour {

	public GameObject sphere;
	public GameObject selector;
	private Material color;
	public Material[] gemMats;
	public List<Gem> Neighbours = new List<Gem>();
	public bool isSelected = false;



	// Use this for initialization
	void Start () 
	{
		CreateGem();
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}

	public void ToggleSelector()
	{
		isSelected = !isSelected;

		selector.SetActive(isSelected);
	}

	void OnMouseDown()
	{
		ToggleSelector();
	}

	public void AddNeighbour(Gem g)
	{
		if (!Neighbours.Contains(g))
		{
			Neighbours.Add(g);
		}
	}

	public void RemoveNeighbour(Gem g)
	{
		Neighbours.Remove(g);
	}

	public void CreateGem()
	{
		color = gemMats[Random.Range(0,gemMats.Length)];
		sphere.GetComponent<Renderer>().material = color;
	}
}

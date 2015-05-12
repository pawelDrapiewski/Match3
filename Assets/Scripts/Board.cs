using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Board : MonoBehaviour {

	public List<Gem> gems = new List<Gem>();
	public int gridWidth;
	public int gridHeight;
	public GameObject gemPrefab;

	// Use this for initialization
	void Start () {

		// Board drawing
		for (int y = 0; y < gridHeight; y++)
		{
			for (int x = 0; x < gridWidth; x++)
			{
				Gem g = Instantiate(gemPrefab,new Vector3(x, y + 2, 0f), Quaternion.identity) as Gem;
				gems.Add(g);
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

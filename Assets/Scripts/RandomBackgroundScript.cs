using UnityEngine;
using System.Collections;

public class RandomBackgroundScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
        (GetComponent<Renderer>() as SpriteRenderer).sprite = Backgrounds[Random.Range(0, Backgrounds.Length)];
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public Sprite[] Backgrounds;
}

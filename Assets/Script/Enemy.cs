using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {
	public Sprite otherSprite;
	private SpriteRenderer ren;
	// Use this for initialization
	IEnumerator Start () {
		ren = transform.GetComponent<SpriteRenderer>();
		yield return new WaitForSeconds(2);
		//print(3222);
		ren.enabled = false;
		yield return new WaitForSeconds(2);
		ren.enabled = true;
		ren.sprite = otherSprite;

	}
	
	// Update is called once per frame
	void Update () {
		if( Input.GetMouseButtonDown(1) ){
			flip ();
		}

		if( Input.GetMouseButtonDown(0) ){
			flip ();
		}
	}

	void flip(){
		Vector3 enemyScale = transform.localScale;
		enemyScale.x *= -1;
		transform.localScale = enemyScale;
	}

}

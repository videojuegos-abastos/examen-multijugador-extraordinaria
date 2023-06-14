using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using TMPro;

class Player : MonoBehaviour
{
	void Start()
	{

	}

	void Update()
	{
		ManageMovement();
	}

	void ManageMovement()
	{
		const float SPEED = 6f;
		float h = Input.GetAxis("Horizontal");
		float v = Input.GetAxis("Vertical");

		transform.position += new Vector3(-h, 0, -v) * SPEED * Time.deltaTime;
	}


	IEnumerator Cooldown()
	{
		const int COOLDOWN_TIME = 3; 
		yield return new WaitForSeconds(COOLDOWN_TIME);

		
	}
}
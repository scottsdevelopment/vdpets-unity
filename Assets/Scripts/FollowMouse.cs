using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowMouse : MonoBehaviour
{
	void Update()
	{
		Vector3 mousePos = GetComponent<Camera>().ScreenToWorldPoint(Input.mousePosition);
		transform.position = mousePos;
	}
}

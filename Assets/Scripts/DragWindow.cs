using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragWindow : MonoBehaviour
{
	
	/// <summary>
	/// Simple click-and-drag, but moves the actual window (if not fullscreen)
	/// </summary>
	
	protected bool draggingWindow = false;

	void Update()
	{
		if (!Input.GetMouseButton(0))
		{
			draggingWindow = false;
			return;
		}

		if (Input.GetMouseButtonDown(0))
		{
			Vector2 pos = TransparentWindow.Camera.ScreenToWorldPoint(Input.mousePosition);

			var overlapCollider = Physics2D.OverlapPoint(pos);
			if (!overlapCollider)
			{
				draggingWindow = false;
				return;
			}

			if (overlapCollider == GetComponent<Collider2D>())
			{
				draggingWindow = true;
			}
		}

		if (draggingWindow)
		{
			TransparentWindow.DragWindow();
		}
	}
}
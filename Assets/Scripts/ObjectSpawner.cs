using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
	[Tooltip("Prefab to spawn on click")] [SerializeField]
	protected GameObject prefab = null;

	[Tooltip("If enabled, SystemInput will allow clicks to be detected even without window focus")] [SerializeField]
	protected bool useSystemInputIfAvailable = false;

	void Update()
	{
		if (useSystemInputIfAvailable)
		{
			if (SystemInput.GetMouseButtonDown(1))
			{
				InstantiatePrefab();
			}

			return;
		}

		if (Input.GetMouseButtonDown(1))
		{
			InstantiatePrefab();
		}
	}

	void InstantiatePrefab()
	{
		Vector3 pos = TransparentWindow.Camera.ScreenToWorldPoint(Input.mousePosition);
		Instantiate(prefab, pos, Quaternion.identity);
	}
}
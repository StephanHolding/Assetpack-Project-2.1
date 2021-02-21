using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraChooser : MonoBehaviour
{

	public Camera[] allCameras;

	private void Awake()
	{
		DisableAllCameras();
	}

	private void Update()
	{
		GetInput();
	}

	private void DisableAllCameras()
	{
		for (int i = 0; i < allCameras.Length; i++)
		{
			allCameras[i].enabled = false;
		}
	}

	private void ToggleCamera(int index, bool toggle)
	{
		DisableAllCameras();

		if (index < allCameras.Length)
			allCameras[index].enabled = toggle;
	}

	private void GetInput()
	{
		if (Input.GetKeyDown(KeyCode.Alpha1))
			ToggleCamera(0, true);

		if (Input.GetKeyDown(KeyCode.Alpha2))
			ToggleCamera(1, true);

		if (Input.GetKeyDown(KeyCode.Alpha3))
			ToggleCamera(2, true);

		if (Input.GetKeyDown(KeyCode.Alpha4))
			ToggleCamera(3, true);

		if (Input.GetKeyDown(KeyCode.Alpha5))
			ToggleCamera(4, true);

		if (Input.GetKeyDown(KeyCode.Alpha6))
			ToggleCamera(5, true);

		if (Input.GetKeyDown(KeyCode.Alpha7))
			ToggleCamera(6, true);
	}

}

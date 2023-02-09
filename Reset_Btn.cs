using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Reset_Btn : MonoBehaviour
{
	public void ClickEvent()
	{
		SceneManager.LoadScene("Main");
	}
}

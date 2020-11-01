using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
	public GameObject Menu;
	
	void Update(){
		if (Input.GetKey(KeyCode.Escape)) {
			if (Menu.isActiveAndEnabled == false) {
				Menu.SetActive(true);
				Time.timeScale = 0;
			} else {
				Menu.SetActive(false);
				Time.timeScale = 1;
			}
		}
	}

	public void RestartClick(){
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}

	public void ReturnClick(){
		Menu.SetActive(false);
		Time.timeScale = 1;
	}	
}

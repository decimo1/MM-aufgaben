using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
	public GameObject Menu;
	int counter;
	
	void Update(){
		if (Input.GetKeyDown(KeyCode.Escape)) {
			counter++;
			if (counter%2==1) {
				Menu.SetActive(true);
				Time.timeScale = 0;
			} else {
				Menu.SetActive(false);
				Time.timeScale = 1;
			}
		}
	}

	public void RestartClick(){
		Time.timeScale = 1;
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}

	public void ReturnClick(){
		Menu.SetActive(false);
		Time.timeScale = 1;
		counter++;
	}	
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Mainmenu : MonoBehaviour {

	public GameObject optionsMenu;
	public GameObject mainMenu;

	public void startrtryGame()
	{
		Time.timeScale = 1;
		SceneManager.LoadScene("Bounce");
	}
	public void Menu()
	{
		SceneManager.LoadScene("Start");
	}
	public void resumeGame()
	{
		Time.timeScale = 1;
		GameObject.Find("Escape").SetActive(false);
	}
	public void menutoOptions()
	{
		mainMenu.SetActive(false);
		optionsMenu.SetActive(true);
	}

	public void fullScreen(bool isFullscreen)
	{
		Screen.fullScreen = isFullscreen;
		Screen.SetResolution(1366, 768, isFullscreen);
	}
	public void backtoMenu()
	{
		optionsMenu.SetActive(false);
		mainMenu.SetActive(true);
	}

	public void quitGame()
	{
		Application.Quit();
	}
}

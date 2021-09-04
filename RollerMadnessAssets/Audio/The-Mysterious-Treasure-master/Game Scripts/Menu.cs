using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {

	public GameObject QuitMenu;
	public GameObject MainMenu;
	public GameObject MapMenu;
	public GameObject Credits;
	public GameObject About;
	public GameObject ControlsImage;
	public GameObject AboutImage;
	public GameObject CreditsImage;
	public AudioSource click;

	public void NewGame()
	{
		click.Play ();
		MainMenu.SetActive (false);
		MapMenu.SetActive (true);
	}

	public void ForestMap()
	{
		click.Play ();
		SceneManager.LoadScene (1);
	}

	public void CityMap()
	{
		click.Play ();
		SceneManager.LoadScene (2);
	}

	public void VillageMap()
	{
		click.Play ();
		SceneManager.LoadScene (3);
	}
		
	public void GoBack()
	{
		click.Play ();
		AboutImage.SetActive (false);
		ControlsImage.SetActive (false);
		CreditsImage.SetActive (false);
		MapMenu.SetActive (false);
		MainMenu.SetActive (true);
	}

	public void OnControls()
	{
		click.Play ();
		MainMenu.SetActive (false);
		ControlsImage.SetActive (true);
	}

	public void OnAbout()
	{
		click.Play ();
		MainMenu.SetActive (false);
		AboutImage.SetActive (true);
	}

	public void OnCredits()
	{
		click.Play ();
		MainMenu.SetActive (false);
		CreditsImage.SetActive (true);
	}

	public void QuitGame()
	{
		click.Play ();
		Application.Quit ();
	}
}

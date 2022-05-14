using UnityEngine;
using UnityEngine.SceneManagement;

public class ToTitleScene : MonoBehaviour
{
	void Update()
	{
		if (Input.GetKeyDown(KeyCode.Return))
		{
			SceneManager.LoadScene("TitleScene");
		}
	}
	public void OnClick()
	{
		SceneManager.LoadScene("TitleScene");
	}

}
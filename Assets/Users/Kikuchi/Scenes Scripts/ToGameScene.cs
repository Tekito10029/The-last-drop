using UnityEngine;
using UnityEngine.SceneManagement;

public class ToGameScene : MonoBehaviour
{
	void Update()
	{
		if (Input.GetKeyDown(KeyCode.Return))
		{
			SceneManager.LoadScene("SampleScene");
		}
	}
	public void OnClick()
	{
		SceneManager.LoadScene("SampleScene");
	}

}
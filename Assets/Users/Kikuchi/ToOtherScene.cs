using UnityEngine;
using UnityEngine.SceneManagement;

public class ToOtherScene : MonoBehaviour
{

	void Start()
	{

	}

	void Update()
	{

		if (Input.GetKeyDown("g"))
		{
			SceneManager.LoadScene("SampleScene");
		}

		if (Input.GetKeyDown("h"))
		{
			SceneManager.LoadScene("GameOverScene");
		}
	}
}
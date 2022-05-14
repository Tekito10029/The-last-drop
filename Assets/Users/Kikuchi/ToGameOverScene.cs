using UnityEngine;
using UnityEngine.SceneManagement;

public class ToGameOverScene : MonoBehaviour
{

	void Start()
	{

	}

	void Update()
	{
		if (Input.GetKeyDown("h"))
		{
			SceneManager.LoadScene("GameOverScene");
		}
	}
}
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToGameScene : MonoBehaviour
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

	}
}
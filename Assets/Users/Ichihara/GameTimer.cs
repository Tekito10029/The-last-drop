using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameTimer : MonoBehaviour
{
    //�^�C�}�[
    float _timeCountUp = 0.0f;
    //_timeCountUp�̒l��\��
    [SerializeField]
    Text Timer;

    // Start is called before the first frame update
    void Start()
    {
        _timeCountUp = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        _timeCountUp += Time.deltaTime;
        Timer.text = _timeCountUp.ToString("f2");
        Debug.Log(_timeCountUp);
    }
}

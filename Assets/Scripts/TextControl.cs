using System.Collections;
using System.Collections.Generic;
using SnowBoarder.Characters;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TextControl : MonoBehaviour
{
    [SerializeField] public TMP_Text _levelText;
    [SerializeField] public TMP_Text _scoreText;

    LevelControl _control;
    // Start is called before the first frame update
    void Start()
    {
        _levelText = FindObjectOfType<TMP_Text>();
        _scoreText = FindObjectOfType<TMP_Text>();
        _control = FindObjectOfType<LevelControl>();
    }

    // Update is called once per frame
    void Update()
    {
        _levelText.text = _control.level.ToString();
        _scoreText.text = _control.currentLevelxp.ToString();
    }
}

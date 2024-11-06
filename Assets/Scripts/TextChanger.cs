using DG.Tweening;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class TextChanger : MonoBehaviour
{
    [SerializeField] private Text _text;
    [SerializeField] private float _duration;
    [SerializeField] private float _wait;

    private string _newText1 = "Замененный текст";
    private string _newText2 = "Дополненный текст";
    private string _newText3 = "Заменен перебором";

    private int _waitIncreaser = 2;

    private void Start()
    {
        ChangeText();
        Invoke("ChangeTextRelative", _wait);
        Invoke("ChangeTextEnumeration", _wait * _waitIncreaser);
    }

    private void ChangeText()
        => _text.DOText(_newText1, _duration);

    private void ChangeTextRelative()
    => _text.DOText(_newText2, _duration).SetRelative();

    private void ChangeTextEnumeration()
    => _text.DOText(_newText3, _duration, true, ScrambleMode.All);

}

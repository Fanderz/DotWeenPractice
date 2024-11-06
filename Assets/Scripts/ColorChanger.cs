using DG.Tweening;
using UnityEngine;

public class ColorChanger : BaseData
{
    [SerializeField] private SpriteRenderer _renederer;
    [SerializeField] private Color _color;

    private void Start()
    {
        _renederer.DOColor(_color, Duration).SetLoops(Repeats, Loop);
    }
}

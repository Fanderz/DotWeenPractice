using DG.Tweening;
using UnityEngine;

public class Scaler : BaseData
{
    [SerializeField] private Vector3 _scale;

    private void Start()
    {
        transform.DOScale(_scale, Duration).SetLoops(Repeats, Loop);
    }
}

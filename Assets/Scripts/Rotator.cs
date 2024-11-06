using DG.Tweening;
using UnityEngine;

public class Rotator : BaseData
{
    [SerializeField] private Vector3 _rotation;

    private void Start()
    {
        transform.DORotate(_rotation, Duration).SetLoops(Repeats, Loop);
    }
}

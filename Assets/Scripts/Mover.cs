using DG.Tweening;
using UnityEngine;

public class Mover : BaseData
{
    [SerializeField] private Vector3 _position;

    private void Start()
    {
        transform.DOMove(_position, Duration).SetLoops(Repeats,Loop);
    }
}

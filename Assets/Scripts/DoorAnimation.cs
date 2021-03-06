using UnityEngine;

[RequireComponent(typeof(Animator))]

public class DoorAnimation : MonoBehaviour
{
    private const string Open = "Open";

    private Animator _animator;    

    private void Start()
    {
        _animator = GetComponent<Animator>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent<Thief>(out Thief thief))
        {
            _animator.SetTrigger(Open);
        }
    }
}

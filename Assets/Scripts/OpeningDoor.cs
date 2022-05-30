using UnityEngine;

[RequireComponent(typeof(Animator))]

public class OpeningDoor : MonoBehaviour
{
    private Animator _animator;
    private const string _open = "Open";

    private void Start()
    {
        _animator = GetComponent<Animator>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent<Thief>(out Thief thief))
        {
            _animator.SetTrigger(_open);
        }
    }
}

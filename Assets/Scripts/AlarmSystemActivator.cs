using UnityEngine;

public class AlarmSystemActivator : MonoBehaviour
{
    [SerializeField] private AlarmSystem _alarmSystem;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent<Thief>(out Thief thief))
        {
            _alarmSystem.ActivateAlarm();
        }
    }
}

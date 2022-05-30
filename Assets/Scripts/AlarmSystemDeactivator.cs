using UnityEngine;

public class AlarmSystemDeactivator : MonoBehaviour
{
    [SerializeField] private AlarmSystem _alarmSystem;    

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.TryGetComponent<Thief>(out Thief thief))
        {
            if (_alarmSystem.TryGetComponent<AlarmSystem>(out AlarmSystem alarmSystem))
                alarmSystem.DeactivateAlarm();
        }
    }
}

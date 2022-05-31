using UnityEngine;

public class AlarmDeactivator : MonoBehaviour
{
    [SerializeField] private Alarm _alarm;    

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.TryGetComponent<Thief>(out Thief thief))
        {
            _alarm.Deactivate();
        }
    }
}

using UnityEngine;

public class WaypointMovement : MonoBehaviour
{
    [SerializeField] private float _speed;   
    [SerializeField] private Transform[] _points;

    private int _currentPoint;    
   
    private void Update()
    {
        Transform target = _points[_currentPoint];
        transform.position = Vector3.MoveTowards(transform.position, target.position, _speed * Time.deltaTime);

        if(transform.position == target.position)
        {
            _currentPoint++;

            if (_currentPoint >= _points.Length)
            {
                _currentPoint = _points.Length - 1;
            }
        }
    }        
}

using System.Collections;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]

public class Alarm : MonoBehaviour
{
    private AudioSource _audioSource;
    private readonly float _minVolumeValue = 0f;
    private readonly float _maxVolumeValue = 1f;    
    private Coroutine _changeVolumeCoroutine;

    private void Start()
    {
        _audioSource = GetComponent<AudioSource>();
        _audioSource.volume = 0f;        
    }

    public void Activate()
    {
        _audioSource.Play();

        if (_changeVolumeCoroutine != null)
        {
            StopCoroutine(_changeVolumeCoroutine);
        }
        _changeVolumeCoroutine = StartCoroutine(ChangeVolume(_maxVolumeValue));
    }

    public void Deactivate()
    {
        if (_changeVolumeCoroutine != null)
        {
            StopCoroutine(_changeVolumeCoroutine);
        }
        _changeVolumeCoroutine = StartCoroutine(ChangeVolume(_minVolumeValue));

        if (_audioSource.volume == 0f)
        {
            _audioSource.Stop();
        }
    }

    private IEnumerator ChangeVolume(float targetVolumeValue)
    {
        float changeStep = 0.0005f;

        while (_audioSource.volume != targetVolumeValue)
        {
            _audioSource.volume = Mathf.MoveTowards(_audioSource.volume, targetVolumeValue, changeStep);
            yield return null;
        }
    }
}

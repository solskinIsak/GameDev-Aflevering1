using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swing : MonoBehaviour
{
    // Start is called before the first frame update

    Quaternion _start, _end;
    [SerializeField, Range(-90.0f,90.0f)] private float _angle = 90.0f;
    [SerializeField] private float _speed = 2.0f;

    [SerializeField, Range(0.0f, 1.0f)] private float _startTime = 0.0f;
    private void Start()
    {
        _start = SwingRotation(_angle);
        _end = SwingRotation(-_angle);
    }

    // Update is called once per frame
    void Update()
    {
        _startTime += Time.deltaTime;
        transform.rotation = Quaternion.Lerp(_start, _end, (Mathf.Sin(_startTime * _speed + Mathf.PI / 2) + 1.0f) / 2.0f);
    }


    void ResetTimer()
    {
        _startTime = 0.0f;
    }

    Quaternion SwingRotation(float angle)
    {
        var swingRotation = transform.rotation;
        var angleX = swingRotation.eulerAngles.x + angle;

        if (angleX > 180)
        {
            angleX -= 360;
        }
        else if (angleX < -180)
        {
            angleX += 360;
        }
        
        swingRotation.eulerAngles = new Vector3(angleX, swingRotation.eulerAngles.y, swingRotation.eulerAngles.z);
        return swingRotation;
    }
}

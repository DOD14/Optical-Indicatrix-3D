using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Indicatrix : MonoBehaviour
{

    public float[] RIs = { 1, 2, 3 };
    public float rotationSpeed = 1f;

    private Transform _transform;

    private void OnEnable()
    {



        // give the indicatrix its shape. y and z are swapped in unity!
        _transform = this.GetComponent<Transform>();
        transform.localScale = new Vector3(RIs[0], RIs[2], RIs[1]);
    }

    // adapted from http://gyanendushekhar.com/2018/01/11/rotate-gameobject-using-mouse-drag-or-touch-unity-tutorial/
    void OnMouseDrag()
    {
        float XaxisRotation = Input.GetAxis("Mouse X") * rotationSpeed;
        float YaxisRotation = Input.GetAxis("Mouse Y") * rotationSpeed;
        _transform.Rotate(Vector3.down * XaxisRotation, Space.World);
        _transform.Rotate(Vector3.right * YaxisRotation, Space.World);
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}

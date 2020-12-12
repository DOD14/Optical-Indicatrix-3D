using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RI : MonoBehaviour
{
    public Vector3 _direction = new Vector3(1, 0, 0);
    private LineRenderer _lineRenderer;
    private float _RI;
   

    private void OnEnable()
    {
        _lineRenderer = this.GetComponent<LineRenderer>();
    }

    private void SetLineRendererPoints()
    {
        Vector3 arrowHead = _direction * _RI;
        _lineRenderer.SetPosition(1, arrowHead);
    }

    public void SetRI(float RI)
    {
        _RI = RI;
    }
}

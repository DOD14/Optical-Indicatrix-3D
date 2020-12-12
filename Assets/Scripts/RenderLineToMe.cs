using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RenderLineToMe : MonoBehaviour
{
    public Vector3 origin = Vector3.zero;
    private LineRenderer _lineRenderer;

    private void OnEnable()
    {
        _lineRenderer = this.GetComponent<LineRenderer>();
        _lineRenderer.SetPosition(0, origin);
        _lineRenderer.SetPosition(1, this.transform.position);

    }
}

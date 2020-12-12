using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Indicatrix : MonoBehaviour
{

    public float alpha = 1;
    public float beta = 2;
    public float gamma = 3;

    private Transform _transform;

    private void OnEnable()
    {

// enforce alpha <= beta <= gamma
        if (alpha > beta)
        {
            float temp = alpha;
            alpha = beta;
            beta = temp;
        }

        if(gamma < beta)
        { float temp = beta;
            beta = gamma;
            gamma = temp;
        }

// give the indicatrix its shape
        _transform = this.GetComponent<Transform>();
        transform.localScale = new Vector3(alpha, beta, gamma);

    }

    void 

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}

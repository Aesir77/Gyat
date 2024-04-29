using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class SolutiontoDetector : MonoBehaviour
{
    public Transform ptB;
    int radius;
    

    private void OnDrawGizmos()
    {
        Vector2 origin = transform.position;
        Vector2 ptBTransform = ptB.position;
        Vector2 displacement = origin - ptBTransform;
        float distSQ = displacement.sqrMagnitude;

        bool isInside = distSQ < radius * radius;
        Handles.color = isInside ? Color.red : Color.green; 
        Handles.DrawWireDisc(origin, new Vector3(0,0,1), radius);

    }
}

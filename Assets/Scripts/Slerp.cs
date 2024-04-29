using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Slerp : MonoBehaviour
{
    public Transform startpoint, endpoint, center;
    public int count;
    public float radius; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        foreach (var point in EvaluateSlerpPoints(startpoint.position,  endpoint.position,  center.position,  count))
        {
            Gizmos.DrawSphere(point, radius);
        }
        Gizmos.color = Color.red;
        Gizmos.DrawSphere(center.position, radius * 2);
    } 
    IEnumerable<Vector3> EvaluateSlerpPoints(Vector3 start, Vector3 end, Vector3 center, int count)
    {
        var startRelativeCenter = start - center;
        var endRelativeCenter = end - center;

        var f = 1f / count;
            for (float i = 0; i < 1+f; i+=f)
        {
            yield return Vector3.Slerp(startRelativeCenter, endRelativeCenter, i) + center;
        }
    }
}

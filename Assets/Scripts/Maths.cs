using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Maths : MonoBehaviour
{
    public float Magnitude, speed;
    public Vector3 startpos;
    // Start is called before the first frame update
    void Start()
    {
        startpos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(0, PingPongAmount(), 0);
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(startpos, 0.21f);
    }

    public float PingPongAmount()
    {
        return Mathf.PingPong(Time.time * speed, Magnitude);

    }
        public float SineAmount()
        {
            return Mathf.Sin(Time.time * speed);
        }
    
}
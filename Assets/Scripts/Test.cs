using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Test : MonoBehaviour
{
    float hp;

    public Slider lerpSlider;
    public Slider MoveTowards;
    public Slider pingPong;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Update()
    {
        lerpSlider.value = Mathf.Lerp(lerpSlider.value, lerpSlider.maxValue, speed*Time.deltaTime);
        MoveTowards.value = Mathf.MoveTowards(lerpSlider.value, lerpSlider.maxValue, speed * Time.deltaTime);
        pingPong.value = Mathf.PingPong(speed*Time.time, pingPong.maxValue);


    }


    private void OnValidate()
    {

        float absolute = Mathf.Abs(-8.5f);
        Debug.Log(absolute);
        float roundtoint = Mathf.RoundToInt(8.5f);
            Debug.Log(roundtoint);
        float CeiltoInt = Mathf.CeilToInt(8.4f);
        Debug.Log("Your CeilToInt is "+ CeiltoInt);

        float FloortoInt = Mathf.FloorToInt(8.9f);
        Debug.Log(FloortoInt);

        float Pow = Mathf.Pow(8, 2);
        Debug.Log(Pow);

        float SQRT = Mathf.Sqrt(16);
        Debug.Log(SQRT);

        float Clamp = Mathf.Clamp(hp, 0, 200);
        Debug.Log(Clamp);

        //Lerp = mathF.lerp
        //Vector 2 or 3 .lerp 
    }
}

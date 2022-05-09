using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coloor : MonoBehaviour
{
    float[] Colorip;
    public jsonController jsee;
    public Color32 myColor;

    public SpriteRenderer myRenderer;

    private void Start()
    {
        myRenderer = gameObject.GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        if(jsee.numbers.Length != 0)
        {
            Colorip = new float[jsee.numbers.Length];
            for (int i = 0; i < jsee.numbers.Length; i++)
            {
                Colorip[i] = float.Parse(jsee.numbers[i]);
            }
            myColor = new Color(Colorip[0] / 255, Colorip[1] / 255, Colorip[2] / 255, Colorip[3] / 255);
            myRenderer.color = myColor;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMoveScript : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    public Sprite[] sprites;
    public float framesPerSecond;
    private int state;

    // Start is called before the first frame update
    void Start()
    {
      //  spriteRenderer = this.GetComponent<SpriteRenderer>();
     //   state = 0;
    }

    // Update is called once per frame
    void Update()
    {
     //   int index = (int)(Time.timeSinceLevelLoad * framesPerSecond);
     //   index = index % sprites.Length;
      //  spriteRenderer.sprite = sprites[index];

    }
}

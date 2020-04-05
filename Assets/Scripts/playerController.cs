using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    public Sprite[] sprites;
    public float framesPerSecond;
    public float moveSpeed;
    private Vector3 moveDirection;
    private int state;

    // Start is called before the first frame update
    void Start()
    {
        moveDirection = Vector3.right;
        spriteRenderer = this.GetComponent<SpriteRenderer>();
        state = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (state == 1)
        {
            int index = (int)(Time.timeSinceLevelLoad * framesPerSecond);
            index = index % sprites.Length;
            spriteRenderer.sprite = sprites[index];
        }

        if (hinput.gamepad[0].leftStick.position.magnitude > .1f)
        {
            if (state == 1)
            {
                transform.position += hinput.gamepad[0].leftStick.worldPositionCamera * moveSpeed * Time.deltaTime; float angle = Mathf.Atan2(hinput.gamepad[0].leftStick.worldPositionCamera.y, hinput.gamepad[0].leftStick.worldPositionCamera.x) * Mathf.Rad2Deg;
                transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
            }
            else if (state == 0)
            {
                state = 1;
            }
        }
        else
        {
            state = 0;
        }
    }
}

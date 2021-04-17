using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteCycle : MonoBehaviour
{
    public Sprite[] sprites;
    public int currSpriteIndex = 0;
    private SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = sprites[currSpriteIndex];
    }

    void Update()
    {
        if (Input.GetButtonDown("Jump") && currSpriteIndex < sprites.Length)
        {   
            currSpriteIndex++;
            spriteRenderer.sprite = sprites[currSpriteIndex];
        }
    }
}

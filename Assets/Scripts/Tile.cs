using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    bool isFilled;
    SpriteRenderer SpriteRendererRef;

    public bool IsFilled { get => isFilled; set => isFilled = value; }


    // Start is called before the first frame update
    void Start()
    {
        SpriteRendererRef = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void FillTile (bool status=true)
    {
        if (status)
        {
            SetTileColor(new Color (0.75f,0.4f,0.4f));
            isFilled = true;
        } else
        {
            SetTileColor(Color.black);
            isFilled = false;
        }
    }

    private void OnMouseUp()
    {
        if (isFilled)
            FillTile(false);
        else
            FillTile();
    }

    void SetTileColor (Color inColor)
    {
        SpriteRendererRef.color = inColor;
    }
}

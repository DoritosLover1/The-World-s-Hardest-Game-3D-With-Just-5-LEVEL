using UnityEngine;

public class CheckerboardTexture : MonoBehaviour
{
    public int textureSize = 512;
    public int checkerSize = 32;

    void Start()
    {
        Texture2D texture = new Texture2D(textureSize, textureSize);
        
        for (int y = 0; y < textureSize; y++)
        {
            for (int x = 0; x < textureSize; x++)
            {
                bool isBlack = ((x / checkerSize) % 2 == (y / checkerSize) % 2);
                texture.SetPixel(x, y, isBlack ? Color.black : Color.white);
            }
        }
        
        texture.Apply();
        GetComponent<Renderer>().material.mainTexture = texture;
    }
}

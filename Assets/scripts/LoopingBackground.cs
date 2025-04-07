using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public float backgroundSpeed;
    public Renderer backgroundRenderer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    // Update is called once per frame
    void Update()
    {
        backgroundRenderer.material.mainTextureOffset += new Vector2(backgroundSpeed*Time.deltaTime,0f);
    }
}

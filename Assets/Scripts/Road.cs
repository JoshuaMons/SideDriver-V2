using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
      private MeshRenderer meshRenderer;

    private void Awake()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }

    private void Update()
    {
        float speed = GameManager.Instance.gameSpeed / transform.localScale.x;
        meshRenderer.material.mainTextureOffset += speed * Time.deltaTime * Vector2.right;
    }
}

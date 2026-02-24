using UnityEngine;

public class SimpleAfterImage : MonoBehaviour
{
    public MeshFilter sourceMesh;
    public Material afterImageMaterial;
    public float lifeTime = 0.3f;
    public float interval = 0.05f;

    float timer;

    void Start()
    {
        // ©“®æ“¾iİ’è–Y‚ê‘Îôj
        if (sourceMesh == null)
            sourceMesh = GetComponent<MeshFilter>();
    }

    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= interval)
        {
            timer = 0;
            CreateAfterImage();
        }
    }

    void CreateAfterImage()
    {
        GameObject ghost = new GameObject("AfterImage");
        ghost.transform.position = transform.position;
        ghost.transform.rotation = transform.rotation;
        ghost.transform.localScale = transform.localScale;

        MeshFilter mf = ghost.AddComponent<MeshFilter>();
        mf.mesh = sourceMesh.mesh;

        MeshRenderer mr = ghost.AddComponent<MeshRenderer>();
        mr.material = new Material(afterImageMaterial);

        ghost.AddComponent<AfterImageFade>().lifeTime = lifeTime;
    }
}

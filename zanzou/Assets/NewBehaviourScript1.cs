using UnityEngine;

public class AfterImageFade : MonoBehaviour
{
    public float lifeTime = 0.3f;
    float timer = 0f;
    Material mat;

    void Start()
    {
        mat = GetComponent<MeshRenderer>().material;
    }

    void Update()
    {
        timer += Time.deltaTime;
        float alpha = 1f - (timer / lifeTime);

        Color c = mat.color;
        c.a = alpha;
        mat.color = c;

        if (timer >= lifeTime)
            Destroy(gameObject);
    }
}

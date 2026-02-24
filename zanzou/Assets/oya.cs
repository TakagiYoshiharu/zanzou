using UnityEngine;

public class oya : MonoBehaviour
{
    public float speed = 1f;   // 往復の速さ
    public float angle = 180f; // 回転角度
    public Vector3 pivotOffset = new Vector3(0, 2, 0); // 回転軸のずらし量

    float lastRot = 0f;
    Vector3 pivot; // 固定する pivot

    void Start()
    {
        // 最初の位置から pivot を決定（固定）
        pivot = transform.position + pivotOffset;
    }

    void Update()
    {
        // 0〜1 を往復する値
        float t = Mathf.PingPong(Time.time * speed, 1f);

        // -angle 〜 +angle を往復
        float rot = Mathf.Lerp(-angle, angle, t);

        // 差分だけ回転
        float delta = rot - lastRot;
        lastRot = rot;

        // pivot を中心に回転（pivot は固定）
        transform.RotateAround(pivot, Vector3.up, delta);
    }
}

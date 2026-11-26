
using UnityEngine;

public class Bird : MonoBehaviour
{
    Transform BirdTransform;
    float cx, cz;
    public float speed;
    bool fall = false;

    [SerializeField]
    private Animator wings;

    void Start()
    {
        cx = this.transform.position.x;
        cz = this.transform.position.z;
        BirdTransform = this.transform;
    }

    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch t = Input.GetTouch(0);

            if (t.phase == TouchPhase.Began)
            {
                speed = 0.15f;
                fall = false;
            }
        }

        if (speed > 0 && !fall)
        {
            wings.SetBool("Wings_up", false);
            BirdTransform.position = new Vector3(cx, BirdTransform.position.y + speed, cz);
            speed -= 0.004f;

            if (speed <= 0)
            {
                fall = true;
                speed = 0.003f;
            }
        }

        if (fall)
        {
            wings.SetBool("Wings_up", true);
            BirdTransform.position = new Vector3(cx, BirdTransform.position.y - speed, cz);
            speed += 0.003f;
        }
    }
}

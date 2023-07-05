using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 8;
    private Rigidbody rigid = default;
    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody>();
        rigid.velocity = transform.forward * speed;

        Destroy(gameObject, 3.0f);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("Ãæµ¹?");

            PlayerControl playerControler = other.GetComponent<PlayerControl>();

            if(playerControler != null)
            {
                playerControler.Die();
            }
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}

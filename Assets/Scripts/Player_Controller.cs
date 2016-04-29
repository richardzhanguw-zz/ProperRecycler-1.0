using UnityEngine;
using UnityEngine.SceneManagement;
public class Player_Controller : MonoBehaviour
{

    public Vector2 jumpForce = new Vector2(0, 300);

    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            GetComponent<Rigidbody2D>().velocity = Vector2.zero;
            GetComponent<Rigidbody2D>().AddForce(jumpForce);
        }

        Vector2 screenPosition = Camera.main.WorldToScreenPoint(transform.position);
        if (screenPosition.y > Screen.height || screenPosition.y < 0)
        {
            SceneManager.LoadScene(0);
        }
    }

    // Die by collision
    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.name == "newspaper")
        {
            Destroy(other.gameObject);
        } else if (other.gameObject.name== "shoe")
        {
            SceneManager.LoadScene(0);

        }
        else if (other.gameObject.name == "sodacan")
        {
            Destroy(other.gameObject);

        }
    }

}
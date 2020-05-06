using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Alien : MonoBehaviour
{
    public static Alien instance;
    float horizontal;
    public Rigidbody2D AlienRigid;
    private Vector2 moveVelocity;

    void Start (){
        if (instance == null)
        {
            instance = this;
        }
  }


    void FixedUpdate(){
        if(Application.platform == RuntimePlatform.Android){
           // Переміщення героя при нахилі телефона
            horizontal = Input.acceleration.x;
        }
            // Переміщення героя на клавіатурі 
        else {
            horizontal = Input.GetAxisRaw("Horizontal");
        }



        // Поворот модельки героя при нахилі телфефона вліво то впрво
        if (Input.acceleration.x < 0)
        {
            gameObject.GetComponent<SpriteRenderer>().flipX = true;
        }
        if (Input.acceleration.x > 0)
        {
            gameObject.GetComponent<SpriteRenderer>().flipX = false;
        }


        // Поворот модельки героя при натисканні на клавіатурі стрілок вліво то впрво
        if (Input.GetAxisRaw("Horizontal") < 0)
        {
            gameObject.GetComponent<SpriteRenderer>().flipX = true;
        }
        if (Input.GetAxisRaw("Horizontal") > 0)
        {
            gameObject.GetComponent<SpriteRenderer>().flipX = false;
        }

        AlienRigid.velocity = new Vector2(Input.acceleration.x * 10f, AlienRigid.velocity.y);
        AlienRigid.velocity = new Vector2(Input.GetAxisRaw("Horizontal") * 10f, AlienRigid.velocity.y);
    }

    public void OnCollisionEnter2D(Collision2D collision)       // зіткнення объекта
    {
        if (collision.collider.name == "DeadZone")              // якщо герой зыткнувся з обєктом з іменеи "DeadZone"
        {
            SceneManager.LoadScene(0);                          // то рівень перезагружаться
        }
    }
}
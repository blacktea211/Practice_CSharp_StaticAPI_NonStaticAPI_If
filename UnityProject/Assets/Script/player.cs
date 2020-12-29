using UnityEngine;

public class player : MonoBehaviour
{
    [Header("血量")]
    public float hp = 100f;
    [Header("攻擊")]
    public float atk;
    [Header("音源")]
    public AudioSource source;
    [Header("音效")]
    public AudioClip sound;
    [Header("喪屍")]
    public zombie zombie;

    public float damage;

    public void Attack()
    {

        if (Input.GetKeyDown(KeyCode.A))
        {
            atk = Random.Range(0f, 50f);
        }
      }



    public void Damage()
    {
        atk =- damage;
        hp = 100 - atk;
         print("<Color.red >+喪屍受到的傷害" + zombie.damage);

        
        if (zombie.hp <= 0)
        {
            Destroy(GetComponent<zombie>());
            print("<Color.red>+喪屍已死亡");
        }




    }


    void Start()
    {
            
    }

    
    void Update()
    {
        Attack();
    }
}

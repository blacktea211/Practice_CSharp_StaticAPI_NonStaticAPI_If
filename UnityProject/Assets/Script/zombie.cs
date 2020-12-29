using UnityEngine;

public class zombie : MonoBehaviour
{
    [Header("血量")]
    public float hp = 100f;
    [Header("攻擊")]
    public float atk;
    [Header("音源")]
    public AudioSource source;
    [Header("音效")]
    public AudioClip sound;
    [Header("玩家")]
    public player player;

    public float damage;


    public void Attack()
    {

        if (Input.GetKeyDown(KeyCode.B))
        {
            atk = Random.Range(0f, 50f);
        }

    }


    public void Damage()
    {
        atk =- damage;

        print("<Color.red >+角色受到的傷害" + player.damage);

        if (player.hp <= 0)
        {
            Destroy(GetComponent<player>());
            print("<Color.red>+角色已死亡");
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
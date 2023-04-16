using UnityEngine;
using UnityEngine.UIElements;

public class NpcAI : MonoBehaviour
{

    [SerializeField] private int npcRange = 3;
    [SerializeField] private GameObject player;
    [SerializeField] private float npcSpeed = 1f;
    private BoxCollider bc;
    private bool sawPlayer = false;
    private void Awake()
    {
        bc =  gameObject.GetComponent<BoxCollider>();
    }

    private void Start()
    {
        bc.size = new Vector3 (npcRange, 0, npcRange);
    }

    private void Update()
    {
        Vector3 playerPos = player.transform.position;
        if (!sawPlayer) 
        { 
            //gameObject.transform.position = new Vector3 gameObject.transform.position
        }
        if(sawPlayer)
        {
            //PlayerMovement.ReducePlayerHealth(5);
            gameObject.transform.position = Vector3.Lerp(gameObject.transform.position, playerPos, npcSpeed * Time.deltaTime);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            gameObject.GetComponent<Collider>().isTrigger = false;
            bc.size = new Vector3(0f, 0f, 0f);
            sawPlayer = true;
        }
    }
}

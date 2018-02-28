using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCController : MonoBehaviour
{

    Character[] npc;
    GameObject[] pgo;

    public Sprite npc_sprite;

    public Character[] Character
    {
        get
        {
            return npc;
        }

        set
        {
            npc = value;
        }
    }

    // Use this for initialization
    void Start()
    {
        pgo = new GameObject[2];
        npc = new Character[2];
        npc[0] = new Character(3, 3);
        npc[1] = new Character(4, 3);

        for (int i = 0; i < npc.Length; i++)
        {

            npc[i].Interactable = true;


            pgo[i] = new GameObject();

            pgo[i].AddComponent<SpriteRenderer>();
            pgo[i].GetComponent<SpriteRenderer>().sprite = npc_sprite;
            pgo[i].GetComponent<SpriteRenderer>().sortingOrder = 11;
            npc[i].Talk = "Hello from NPC" + i;

            pgo[i].tag = "NPC";
            Debug.Log("NPC:" + npc[i].ToString());
        }
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < npc.Length; i++)
        {
            if (npc[i] != null)
            {
                pointf pos = npc[i].getPosition();
                pgo[i].transform.position = new Vector3(pos.X, pos.Y, 0);
                pgo[i].name = "NPC"+i;
                //Debug.Log("Displaying NPC: "+i+" Pos:"+pos.X+":"+pos.Y);
            }
        }
    }

    public void moveNPC()
    {
        for (int i = 0; i < npc.Length; i++)
        {
			npc[i].moveCharacter(Time.deltaTime);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainGame : MonoBehaviour
{
    public string PokemonIndex1;
    public string PokemonIndex2;
    
    public GameObject pk1Obj;
    public GameObject pk2Obj;
    
    public InbattlePokemon inbattle1;
    public InbattlePokemon inbattle2;

    public Player player1;
    public Player player2;
    // Start is called before the first frame update
    void Start()
    {
        IV iv = new IV();
        EV ev = new EV(252,252,0,0,6,0);
        Pokemon pk1=new Pokemon(PokemonIndex1, iv, ev);
        Pokemon pk2=new Pokemon(PokemonIndex2, iv, ev);
        Debug.Log(pk1.name);
        Debug.Log(pk1.iv.HP);
        Debug.Log(pk1.baseStat.HP);
        
        inbattle1 = new InbattlePokemon(pk1);
        Debug.Log(inbattle1.stat.HP);
        inbattle2 = new InbattlePokemon(pk2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

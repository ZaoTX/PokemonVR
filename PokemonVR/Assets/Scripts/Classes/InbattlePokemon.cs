using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InbattlePokemon {
    public Pokemon pokemon;
    public Stat stat;//all stats of the pokemon calculate in start 
              
    public float accuracy;
    public float evasion;//»Ø±ÜÂÊ
    public int level = 50;
    //calculation rule: https://bulbapedia.bulbagarden.net/wiki/Stat#HP  
    //In Generation III onward
    public InbattlePokemon(Pokemon pokemon) {
        this.pokemon = pokemon;
        //setup in battle stat
        stat = new Stat(pokemon.baseStat.HP, pokemon.baseStat.PA, 
            pokemon.baseStat.PD, pokemon.baseStat.SA, pokemon.baseStat.SD, 
            pokemon.baseStat.Speed);
        setupStats();
        accuracy = 1;
        evasion = 0;

    }
    public void setupStats() {
        calculateHP();
        calculatePA();
        calculatePD();
        calculateSA();
        calculateSD();
        calculateSpeed();
        calculateNature();
    }
    private void calculateHP()
    {
        int hp = (int)Mathf.Floor((2 * pokemon.baseStat.HP + pokemon.iv.HP+Mathf.Floor(pokemon.ev.HP/4))*level/100)+level + 10;
        stat.HP = hp;
         
    }

    private void calculatePA()
    {
        int pa = (int)Mathf.Floor(2*pokemon.baseStat.PA+pokemon.iv.PA+Mathf.Floor(pokemon.ev.PA/4)*level/100)+5;
        
        stat.PA = pa;
         
    }
    private void calculatePD()
    {
        int pd = (int)Mathf.Floor(2 * pokemon.baseStat.PD + pokemon.iv.PD + Mathf.Floor(pokemon.ev.PD / 4) * level / 100) + 5;
        
        stat.PD = pd;
         
    }
    private void calculateSA()
    {
        int sa = (int)Mathf.Floor(2 * pokemon.baseStat.SA + pokemon.iv.SA + Mathf.Floor(pokemon.ev.SA / 4) * level / 100) + 5;
        
        stat.SA = sa;
         
    }
    private void calculateSD()
    {
        int sd = (int)Mathf.Floor(2 * pokemon.baseStat.SD + pokemon.iv.SD + Mathf.Floor(pokemon.ev.SD / 4) * level / 100) + 5;
        
        stat.SD = sd;
         
    }
    private void calculateSpeed()
    {
        int speed = (int)Mathf.Floor(2 * pokemon.baseStat.Speed + pokemon.iv.Speed + Mathf.Floor(pokemon.ev.Speed / 4) * level / 100) + 5;
   
        stat.Speed = speed;
    }
    private void calculateNature() 
    {
        
        if (pokemon.nature == "Lonely") {
            int PA = (int) Mathf.Floor(stat.PA * 1.1f);
            int PD = (int)Mathf.Floor(stat.PD * 0.9f);
            stat.PA = PA;
            stat.PD = PD;
        }
        else if (pokemon.nature == "Adamant") {
            int PA = (int)Mathf.Floor(stat.PA * 1.1f);
            int SA = (int)Mathf.Floor(stat.SA * 0.9f);
            stat.PA = PA;
            stat.SA = SA;
        }
        else if (pokemon.nature == "Naughty")
        {
            int PA = (int)Mathf.Floor(stat.PA * 1.1f);
            int SD = (int)Mathf.Floor(stat.SD * 0.9f);
            stat.PA = PA;
            stat.SD = SD;
        }
        else if (pokemon.nature == "Brave")
        {
            int PA = (int)Mathf.Floor(stat.PA * 1.1f);
            int Speed = (int)Mathf.Floor(stat.Speed * 0.9f);
            stat.PA = PA;
            stat.Speed = Speed;
        }
        else if (pokemon.nature == "Bold")
        {
            int PD = (int)Mathf.Floor(stat.PD * 1.1f);
            int PA = (int)Mathf.Floor(stat.PA * 0.9f);
            stat.PA = PA;
            stat.PD = PD;
        }
        else if (pokemon.nature == "Impish")
        {
            int PD = (int)Mathf.Floor(stat.PD * 1.1f);
            int SA = (int)Mathf.Floor(stat.SA * 0.9f);
            stat.SA = SA;
            stat.PD = PD;
        }
        else if (pokemon.nature == "Lax")
        {
            int PD = (int)Mathf.Floor(stat.PD * 1.1f);
            int SD = (int)Mathf.Floor(stat.SD * 0.9f);
            stat.PD = PD;
            stat.SD = SD;
        }
        else if (pokemon.nature == "Relaxed")
        {
            int PD = (int)Mathf.Floor(stat.PD * 1.1f);
            int Speed = (int)Mathf.Floor(stat.Speed * 0.9f);
            stat.PD = PD;
            stat.Speed = Speed;
        }
        else if (pokemon.nature == "Modest")
        {
            int SA = (int)Mathf.Floor(stat.SA * 1.1f);
            int PA = (int)Mathf.Floor(stat.PA * 0.9f);
            stat.PA = PA;
            stat.SA = SA;
        }
        else if (pokemon.nature == "Mild")
        {
            int SA = (int)Mathf.Floor(stat.SA * 1.1f);
            int PD = (int)Mathf.Floor(stat.PD * 0.9f);
            stat.SA = SA;
            stat.PD = PD;
        }
        else if (pokemon.nature == "Rash")
        {
            int SA = (int)Mathf.Floor(stat.SA * 1.1f);
            int SD = (int)Mathf.Floor(stat.SD * 0.9f);
            stat.SA = SA;
            stat.SD = SD;
        }
        else if (pokemon.nature == "Quiet")
        {
            int SA = (int)Mathf.Floor(stat.SA * 1.1f);
            int Speed = (int)Mathf.Floor(stat.Speed * 0.9f);
            stat.SA = SA;
            stat.Speed = Speed;
        }
        else if (pokemon.nature == "Calm")
        {
            int SD = (int)Mathf.Floor(stat.SD * 1.1f);
            int PA = (int)Mathf.Floor(stat.PA * 0.9f);
            stat.PA = PA;
            stat.SD = SD;
        }
        else if (pokemon.nature == "Gentle")
        {
            int SD = (int)Mathf.Floor(stat.SD * 1.1f);
            int PD = (int)Mathf.Floor(stat.PD * 0.9f);
            stat.SD = SD;
            stat.PD = PD;
        }
        else if (pokemon.nature == "Careful")
        {
            int SD = (int)Mathf.Floor(stat.SD * 1.1f);
            int SA = (int)Mathf.Floor(stat.SA * 0.9f);
            stat.SA = SA;
            stat.SD = SD;
        }
        else if (pokemon.nature == "Sassy")
        {
            int SD = (int)Mathf.Floor(stat.SD * 1.1f);
            int Speed = (int)Mathf.Floor(stat.Speed * 0.9f);
            stat.SD = SD;
            stat.Speed = Speed;
        }
        else if (pokemon.nature == "Timid")
        {
            int Speed = (int)Mathf.Floor(stat.Speed * 1.1f);
            int PA = (int)Mathf.Floor(stat.PA * 0.9f);
            stat.PA = PA;
            stat.Speed = Speed;
        }
        else if (pokemon.nature == "Hasty")
        {
            int Speed = (int)Mathf.Floor(stat.Speed * 1.1f);
            int PD = (int)Mathf.Floor(stat.PD * 0.9f);
            stat.Speed = Speed;
            stat.PD = PD;
        }
        else if (pokemon.nature == "Jolly")
        {
            int Speed = (int)Mathf.Floor(stat.Speed * 1.1f);
            int SA = (int)Mathf.Floor(stat.SA * 0.9f);
            stat.SA = SA;
            stat.Speed = Speed;
        }
        else if (pokemon.nature == "Naive")
        {
            int Speed = (int)Mathf.Floor(stat.Speed * 1.1f);
            int SD = (int)Mathf.Floor(stat.SD * 0.9f);
            stat.SD = SD;
            stat.Speed = Speed;
        }


    }
}

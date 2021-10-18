using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EV {

    public int HP;
    public int PA; //physical attack
    public int PD; //physical defense
    public int SA; //special attack
    public int SD; //special defense
    public int Speed;
    public EV()
    {
        this.HP = 0;
        this.PA = 0;
        this.PD = 0;
        this.SA = 0;
        this.SD = 0;
        this.Speed = 0;
    }
    public EV(int HP, int PA, int PD, int SA, int SD, int Speed)
    {
        this.HP = HP;
        this.PA = PA;
        this.PD = PD;
        this.SA = SA;
        this.SD = SD;
        this.Speed = Speed;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IV
{

    public int HP;
    public int PA; //physical attack
    public int PD; //physical defense
    public int SA; //special attack
    public int SD; //special defense
    public int Speed;
    public IV() {
        this.HP = 31;
        this.PA = 31;
        this.PD = 31;
        this.SA = 31;
        this.SD = 31;
        this.Speed = 31;
    }
    public IV(int HP, int PA, int PD, int SA, int SD, int Speed)
    {
        this.HP = HP;
        this.PA = PA;
        this.PD = PD;
        this.SA = SA;
        this.SD = SD;
        this.Speed = Speed;
    }
}

using System.Collections;
using System.Collections.Generic;

//In battle stat of the pokemon
public class Stat {
    public int HP;
    public int PA; //physical attack
    public int PD; //physical defense
    public int SA; //special attack
    public int SD; //special defense
    public int Speed;
    public Stat(int HP,int PA,int PD,int SA,int SD,int Speed)
    {
        HP = HP;
        PA = PA;
        PD = PD;
        SA = SA;
        SD = SD;
        Speed = Speed;
    }
}

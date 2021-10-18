using System;
public class Pokemon {
    
    public IV iv; //天赋
    public EV ev; //努力
    public baseStat baseStat=new baseStat();//种族
    public string nature; //性格

    public int Ability; //1,2,3 3为隐藏特性
    public string[] type= new string[2]; //属性
    public Move[] moves= new Move[4]; //技能
    public string holdItem; //道具
    public bool isLegendary = false;
    public bool isMythical = false;

    public string name; //pokemon名
    public string index; //图鉴id
    public Pokemon(string index, IV iv , EV ev) {
        //read base stats of this pokemon
        this.index = index;
        this.iv = iv;
        this.ev = ev;
        int numIndex = Convert.ToInt32(index);
        string sourceName = "Assets/Resources/enumsPokemon.txt";
        string[] lines = System.IO.File.ReadAllLines(sourceName);
        string line = lines[23 + numIndex];

        string[] info = line.Split('|','}');
        int HP = Convert.ToInt32(info[3]);
        int PA = Convert.ToInt32(info[4]);
        int PD = Convert.ToInt32(info[5]);
        int SA = Convert.ToInt32(info[6]);
        int SD = Convert.ToInt32(info[7]);
        int Speed = Convert.ToInt32(info[8]);

        this.name = info[2];
        this.baseStat.HP = HP;
        this.baseStat.PA = PA;
        this.baseStat.SA = SA;
        this.baseStat.PD = PD;
        this.baseStat.SD = SD;
        this.baseStat.Speed = Speed;
    }
}

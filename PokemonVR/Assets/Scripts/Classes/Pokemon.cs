using System;
public class Pokemon {
    
    public IV iv; //�츳
    public EV ev; //Ŭ��
    public baseStat baseStat=new baseStat();//����
    public string nature; //�Ը�

    public int Ability; //1,2,3 3Ϊ��������
    public string[] type= new string[2]; //����
    public Move[] moves= new Move[4]; //����
    public string holdItem; //����
    public bool isLegendary = false;
    public bool isMythical = false;

    public string name; //pokemon��
    public string index; //ͼ��id
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

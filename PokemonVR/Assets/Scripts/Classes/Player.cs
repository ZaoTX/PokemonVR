

public class Player 
{
    public Pokemon pk1;
    public Pokemon pk2;
    public Pokemon pk3;
    public Pokemon pk4;
    public Pokemon pk5;
    public Pokemon pk6;
    Player() {
        IV iv = new IV(31, 31, 31, 31, 31, 31);
        EV ev_PA = new EV(6, 252, 0, 0, 0, 252);
        EV ev_SA = new EV(6, 0, 0, 252, 0, 252);
        //����������
        pk1 = new Pokemon("003",iv,ev_SA);//��
        pk2 = new Pokemon("006", iv, ev_SA);//��
        pk3 = new Pokemon("009", iv, ev_SA);//ˮ
        //������
        pk4 = new Pokemon("144", iv, ev_SA);//��
        pk5 = new Pokemon("145", iv, ev_SA);//��
        pk6 = new Pokemon("146", iv, ev_SA);//��
    }
    Player(Pokemon pk1, Pokemon pk2, Pokemon pk3, Pokemon pk4, Pokemon pk5, Pokemon pk6) {

        pk1 = pk1;
        pk2 = pk2;
        pk3 = pk3;
        
        pk4 = pk4; 
        pk5 = pk5; 
        pk6 = pk6; 
    }
}

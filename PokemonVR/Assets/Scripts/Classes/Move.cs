public class Move {

    public int damage;
    public bool isOneHit;//��ɱ
    public int PP;
    public string type;
    public float accuracy;
    public bool isAlwaysHit;//����
    public int target;//Ŀ�����
    public string name;//������
    public int damageType;//1 for ad 0 for ap
    public float criticalRate;//������
    public Move() {
        damage = 0;
        isOneHit = false;
        PP = 0;
        type = "Dark";
        accuracy = 0;
        isAlwaysHit = false;
        target = 1;
        name = "Default";
        damageType = 1;
        criticalRate = 0;
    }
}
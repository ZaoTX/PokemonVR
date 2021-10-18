public class Move {

    public int damage;
    public bool isOneHit;//必杀
    public int PP;
    public string type;
    public float accuracy;
    public bool isAlwaysHit;//必中
    public int target;//目标个数
    public string name;//技能名
    public int damageType;//1 for ad 0 for ap
    public float criticalRate;//暴击率
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
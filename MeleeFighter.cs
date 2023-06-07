public class MeleeFighter : Enemy
{
    public MeleeFighter (string name) : base(name)
    {
        Health = 120;

        Attack punchAttack = new Attack("Sword Thrust", 20);
        Attack kickAttack = new Attack("Sparta Kick", 15);
        Attack tackleAttack = new Attack("Tackle", 25);

        AttackList.Add(punchAttack);
        AttackList.Add(kickAttack);
        AttackList.Add(tackleAttack);
    }

    public void Rage(Enemy target)
    {
        Random random= new Random();
        int idx = random.Next(AttackList.Count);
        Attack randomAttack = AttackList[idx];
        int dmgWithRage = randomAttack.Damage + 10;
        PerformAttack(target, new Attack(randomAttack.Name, dmgWithRage));
    }
}
public class MagicCaster : Enemy
{
    public MagicCaster (string name) : base(name)
    {
        Health = 80;

        Attack fireAttack = new Attack("Fireball", 25);
        Attack lightingAttack = new Attack("Lighting Surge", 20);
        Attack meleeAttack = new Attack("Bonk", 10);

        AttackList.Add(fireAttack);
        AttackList.Add(lightingAttack);
        AttackList.Add(meleeAttack);
    }

    public void Heal(Enemy target)
    {
        target.Health += 40;
        Console.WriteLine($"{Name} uses healing words. {target.Name} is going to buy {Name} a coffee as payment.");
    }
}
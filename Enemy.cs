public class Enemy
{
    public string Name { get; }
    public int Health { get; set; }
    public List<Attack> AttackList { get; }

    public Enemy(string name)
    {
        Name = name;
        Health = 100;
        AttackList = new List<Attack>();
    }

    protected void ReduceHealth(int amount)
    {
        Health -= amount;
        if (Health < 0)
        {
            Health = 0;
        }
    }

    public virtual void PerformAttack(Enemy target, Attack chosenAttack)
    {
        target.ReduceHealth(chosenAttack.Damage);
        Console.WriteLine($"{Name} attacks {target.Name} with {chosenAttack.Name}, it deals {chosenAttack.Damage} damage and now {target.Name} has {target.Health} left!");
    }


    public void RandomAtk()
    {
        Random random = new Random();
        int idx = random.Next(AttackList.Count);
        Attack attack = AttackList[idx];
        Console.WriteLine($"{Name} attacks with {attack.Name} and it does {attack.Damage} damage to your health.");
    }
}
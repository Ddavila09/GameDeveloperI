public class Enemy
{
    public string Name { get; }
    public int Health { get; set; }
    public List<Attack> AttackList { get; }

    public Enemy (string name)
    {
        Name = name;
        Health = 100;
        AttackList = new List<Attack>();
    }

    public void RandomAtk()
    {
        Random random = new Random();
        int idx = random.Next(AttackList.Count);
        Attack attack = AttackList[idx];
        Console.WriteLine($"{Name} attacks with {attack.Name} and it does {attack.Damage} damage to your health.");
    }
}
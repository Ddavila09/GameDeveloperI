public class RangedFighter : Enemy
{
    
    public int Distance { get; protected set;}
    
    public RangedFighter (string name) : base(name)
    {
        Health = 100;
        Distance = 5;

        Attack shootAttack = new Attack("Bow Shot", 20);
        Attack throwAttack = new Attack("Knife Throw", 15);
        Attack instulAttack = new Attack("Insult", 25);

        AttackList.Add(shootAttack);
        AttackList.Add(throwAttack);
        AttackList.Add(instulAttack);
    }

    public void Dash()
    {
        Distance = 20;
        Console.WriteLine($"{Name} dashes away!");
    }

    public override void PerformAttack(Enemy target, Attack chosenAttack)
    {
        if (Distance >= 10)
        {
        base.PerformAttack(target, chosenAttack);
        }
        else 
        {
            Console.WriteLine($"{Name} tries to attack, but it's too close to target.");
        }
    }
}
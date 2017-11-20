string declareWinner(Fighter* fighter1, Fighter* fighter2, std::string firstAttacker)
{
 // Number of blows each fighter can survive:
 int f1 = (fighter1->getHealth() - 1) / fighter2->getDamagePerAttack();
 int f2 = (fighter2->getHealth() - 1) / fighter1->getDamagePerAttack();
 
 return f1 > f2 ? fighter1->getName()
      : f1 < f2 ? fighter2->getName()
      :           firstAttacker;
}

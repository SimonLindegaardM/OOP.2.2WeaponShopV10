namespace WeaponShopV10
{
    /// <summary>
    /// This class represents a Axe. An Axe is 
    /// considered to be a weapon.
    /// </summary>
    public class Axe : Weapon
    {
        public const int InitialAxeMinDamage = 20;
        public const int InitialAxeMaxDamage = 50;

        #region Constructor
        public Axe(string description) 
            : base(description, InitialAxeMinDamage, InitialAxeMaxDamage)
        {
        } 
        #endregion
        public int DamageFromAxe()
        {
            int DealDamage =base.CalculateDamage();
            base.MinDamage -= 3;
            base.MaxDamage -= 3;
            if(base.MinDamage <0)
            {
                base.MinDamage = 0;
            }
            if(base.MaxDamage <1)
            {
                base.MaxDamage = 1;
            }
            
            return DealDamage;
        }
        public void Sharpen()
        {
            base.MinDamage=InitialAxeMinDamage;
            base.MaxDamage=InitialAxeMaxDamage;
        }
    }
}
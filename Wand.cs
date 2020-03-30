namespace WeaponShopV10
{
    /// <summary>
    /// This class represents a Wand. A Wand is 
    /// considered to be a weapon.
    /// </summary>
    public class Wand : Weapon
    {
        public const int InitialWandMinDamage = 10;
        public const int InitialWandMaxDamage = 30;
        private bool _IsEnchanted;

        #region Constructor
        public Wand(string description) 
            : base(description, InitialWandMinDamage, InitialWandMaxDamage)
        {
            _IsEnchanted = false;
        } 
        #endregion
        public bool IsEnchanted
        {
            get { return _IsEnchanted;}
            set { _IsEnchanted = value;}   
        }
        public int DamageFromWand()
        {
            if(_IsEnchanted)
            {
                return base.CalculateDamage() * 2;
            }
            return base.CalculateDamage();
        }
    }
}
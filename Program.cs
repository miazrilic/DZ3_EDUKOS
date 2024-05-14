namespace DZ3_EDUKOS
{
    internal class Program
    {
        static void Main(string[] args)

        {
            
            ICharacterFactory fireCharacterFactory = new FireCharacterFactory();
            fireCharacterFactory.CreateWizard().DealMagicDamage();
            fireCharacterFactory.CreateGoblin().DealTrueDamage();

            ICharacterFactory waterCharacterFactory = new WaterCharacterFactory();
            waterCharacterFactory.CreateWizard().DealMagicDamage();
            waterCharacterFactory.CreateGoblin().DealTrueDamage();


            
        }
            
    }

}
    

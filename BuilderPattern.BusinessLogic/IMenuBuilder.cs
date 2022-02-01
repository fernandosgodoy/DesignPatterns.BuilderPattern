using BuilderPattern.BusinessLogic.Domain;

namespace BuilderPattern.BusinessLogic
{
    /// <summary>
    /// This interface isn't in the GoF example.
    /// But to create a common contract and according to
    /// SOLID principles, I created it.
    /// </summary>
    public interface IMenuBuilder
    {
        void BuildOrderMainMenu(int comboNumber);
        void BuildAdditional(int additionalOption, int quantity);
        void BuildPackage(bool delivery, bool ketchup, string specialThing);

        Menu Get();

    }
}

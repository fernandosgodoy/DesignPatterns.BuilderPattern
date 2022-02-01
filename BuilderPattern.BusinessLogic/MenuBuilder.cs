using BuilderPattern.BusinessLogic.Domain;

namespace BuilderPattern.BusinessLogic
{

    /// <summary>
    /// The concrete builder class.
    /// </summary>
    public class MenuBuilder
        : IMenuBuilder
    {

        private Menu _menu;

        public void BuildAdditional(int additionalOption, int quantity)
        {
            this._menu.Additional.Add(new MenuAdditional()
            {
                AdditionalItem = additionalOption,
                Quantity = quantity
            });
        }

        public void BuildOrderMainMenu(int comboNumber)
        {
            this._menu.ComboNumber = comboNumber;
        }

        public void BuildPackage(bool delivery, bool ketchup, string specialThing)
        {
            this._menu.IsDelivery = delivery;
            this._menu.NeedsKetchup = ketchup;
            this._menu.Message = specialThing;
        }

        public Menu Get()
        {
            Menu result = this._menu;
            this.Reset();
            return result;
        }

        public void Reset()
        {
            this._menu = new Menu();
        }
    }
}

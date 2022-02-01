using System.Collections.Generic;

namespace BuilderPatternConsoleApp.FastFoodOrderBuild
{
    public class MenuDirector
    {

        private IMenuBuilder _builder;

        public MenuBuilder Builder 
        { 
            set { this._builder = value; } 
        }

        public MenuDirector()
        {
            this._builder = new MenuBuilder();
        }

        public void BuildBigMacMenuDeskWithdraw()
        {
            this._builder.BuildOrderMainMenu((int)ComboMenuType.BigMac);
            this._builder.BuildAdditional((int)AdditionalType.Fries, 1);
            this._builder.BuildAdditional((int)AdditionalType.CocaCola, 1);
            this._builder.BuildPackage(false, true, string.Empty);
        }

        public void BuildBigTastyMenuDeskWithdraw()
        {
            this._builder.BuildOrderMainMenu((int)ComboMenuType.BigTasty);
            this._builder.BuildAdditional((int)AdditionalType.Fries, 1);
            this._builder.BuildAdditional((int)AdditionalType.CocaCola, 1);
            this._builder.BuildPackage(false, true, string.Empty);
        }

        public void BuildPersonalizedMenu(ComboMenuType comboMenu,
            List<MenuAdditional> additionalItems,
            bool isDelivery,
            bool wannaKetchup,
            string specialRequest)
        {
            this._builder.BuildOrderMainMenu((int)comboMenu);

            foreach (var item in additionalItems)
            {
                this._builder.BuildAdditional(item.AdditionalItem, item.Quantity);
            }

            this._builder.BuildPackage(false, true, string.Empty);
        }

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace State.Menu {
    public class LogoMenu : _MenuState {
        //Specific for this state
        public override void InitState(MenuController menuController) {
            base.InitState(menuController);

            state = MenuController.MenuState.Logo;
        }
    }
}

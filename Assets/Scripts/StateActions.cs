using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts
{
    public interface StateActions
    {
        public void OnJumpAction();

        public void OnMoveAction();

        public void OnDuckAction();

        public void OnAttackAction();

        public void OnDeathAction();
    }
}

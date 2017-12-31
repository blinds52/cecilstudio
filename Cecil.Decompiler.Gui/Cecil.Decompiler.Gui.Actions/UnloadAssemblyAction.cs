using System;
using Cecil.Decompiler.Gui.Services;

namespace Cecil.Decompiler.Gui.Actions
{
    internal class UnloadAssemblyAction : BaseAction
    {
        #region IAction
        public override string Name
        {
            get { return ActionNames.UnloadAssembly.ToString(); }
        }

        public override void Execute()
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}

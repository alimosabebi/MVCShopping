using System.Web.Mvc;

namespace BasicScaffolder
{
    public class StaticController: Controller
    {
        protected override void HandleUnknownAction(string actionName)
        {
            View(actionName).ExecuteResult(ControllerContext);
        }
    }
}
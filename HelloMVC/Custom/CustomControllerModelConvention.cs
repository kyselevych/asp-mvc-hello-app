using Microsoft.AspNetCore.Mvc.ApplicationModels;
using HelloMVC.Helpers;

namespace HelloMVC.Custom
{
    public class CustomControllerModelConvention : IControllerModelConvention
    {
        public void Apply(ControllerModel controller)
        {
            string controllerName = Tools.GetControllerName(controller.ControllerName);
            //string reversedControllerName = Tools.GetReversedString(controllerName);

            controller.ControllerName = controllerName;

            /*
            var firstSelector = controller.Selectors[0];

            if (firstSelector.AttributeRouteModel == null)
                firstSelector.AttributeRouteModel = new AttributeRouteModel();

            firstSelector.AttributeRouteModel.Template = $"{reversedControllerName}/[action]";
            */
        }
    }


}

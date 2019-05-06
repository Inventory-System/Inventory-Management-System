using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Castle.Windsor;
using Castle.Windsor.Installer;

namespace DependencyInjection
{
    //public class WindsorController : Controller
    //{
    //    private readonly IKernel _kernel;

    //    public WindsorControllerFactory(IKernel kernel)
    //    {
    //        _kernel = kernel;
    //    }

    //    public override void ReleaseController(IController controller)
    //    {
    //        _kernel.ReleaseComponent(controller);
    //    }

    //    protected override IController GetControllerInstance(RequestContext requestContext, Type controllerType)
    //    {
    //        if (controllerType == null)
    //        {
    //            throw new HttpException(404, string.Format("The controller for path '{0}' could not be found.", requestContext.HttpContext.Request.Path));
    //        }

    //        return (IController)_kernel.Resolve(controllerType);
    //    }
    //}
}

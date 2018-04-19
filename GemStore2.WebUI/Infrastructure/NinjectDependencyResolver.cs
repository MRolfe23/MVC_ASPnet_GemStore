using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ninject;
using Moq;

namespace GemStore.WebUI.Infrastructure
{
    public class NinjectDependencyResolver : IDependencyResolver
    {
        private IKernel mykernel;

        public NinjectDependencyResolver(IKernel kernelParam)
        {
            mykernel = kernelParam;
            AddBindings();
        }

        public object GetService(Type myserviceType)
        {
            return mykernel.TryGet(myserviceType);
        }

        public IEnumerable<object> GetServices(Type myserviceType)
        {
            return mykernel.GetAll(myserviceType);
        }

        private void AddBindings()
        {
            /*
                // we need to put bindings here
                //This are moq (mock) implementation of IProductsRepository
                Mock<IProductsRepository> myMock = new Mock<IProductsRepository>();
                myMock.Setup(m => m.Products).Returns(new List<Product>{
                    new Product {Name = "FOOTBALL", Price = 25 }
                });
                mykernel.Bind<IProductsRepository>().ToConstant(myMock.Object);
            */
           // mykernel.Bind<IProductsRepository>().To<EntityFrameWorkProductRepository>();
        }
    }
}
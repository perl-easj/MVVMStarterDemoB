using Data.InMemory.Interfaces;
using Extensions.Model.Implementation;
using MVVMStarterDemoB.Configuration.App;

namespace MVVMStarterDemoB.Models.Base
{
    public abstract class CatalogAppBase<TDomainData, TViewData, TPersistentData> : RestApiPersistableCatalog<TDomainData, TViewData, TPersistentData>
        where TViewData : class, IStorable, ICopyable, new() 
        where TDomainData : class, IStorable 
        where TPersistentData : IStorable
    {
        protected CatalogAppBase(string apiID) : base(AppConfig.ServerURL, apiID)
        {
        }
    }
}
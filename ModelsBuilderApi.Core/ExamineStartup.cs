using System;
using Examine;
using Umbraco.Core;
using Umbraco.Core.Logging;
using Umbraco.Web;

namespace ModelsBuilderApi.Core
{
    public class ExamineStartup : ApplicationEventHandler
    {
        public static string FullTextField = "fullTextField";

        #region Overrides of ApplicationEventHandler

        protected override void ApplicationStarted(UmbracoApplicationBase umbracoApplication,
            ApplicationContext applicationContext)
        {
            base.ApplicationInitialized(umbracoApplication, applicationContext);

            var umbracoHelper = new UmbracoHelper(UmbracoContext.Current);
            ExamineManager.Instance.IndexProviderCollection["ProductsIndexer"].GatheringNodeData += (sender, e) =>
                GatheringNodeData(e, applicationContext, umbracoHelper);

        }

        private void GatheringNodeData(IndexingNodeDataEventArgs nodeData, ApplicationContext context,
            UmbracoHelper helper)
        {
            try
            {

                if (nodeData.IndexType.Equals("media", StringComparison.InvariantCultureIgnoreCase)) return;
                if (nodeData.Fields == null) return;

                var pageId = nodeData.NodeId;

                var typedPage = new Products(helper.TypedContent(pageId));

                if (typedPage.HasValue("featuredProducts"))
                {
                    //This is null after line executes
                    var featuredProducts = typedPage.FeaturedProducts;
                    //Yet this works
                    foreach (var featuredProduct in typedPage.GetPropertyValue<Udi[]>("featuredProducts"))
                    {
                        var typedCategory = new Product(helper.TypedContent(featuredProduct as GuidUdi));

                    }


                }

            }
            catch (Exception ex)
            {
                LogHelper.Error(GetType(), $"Error indexing - [{nodeData.NodeId}]", ex);
            }

        }

        #endregion

    }
}

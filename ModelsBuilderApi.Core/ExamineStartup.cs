using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Examine;
using Umbraco.Core;
using Umbraco.Core.Logging;
using Umbraco.Web;

namespace ModelsBuilderApi.Core
{
    public class ExamineStartup : ApplicationEventHandler
    {
        public static string FullTextField = "fullTextField";
        private readonly string[] ignorePropertyAliasList = {"ncContentTypeAlias", "icon", "key", "icContentTypeAlias"};

        private readonly string[] ignoreFullProperyAliasList =
        {
            "ncContentTypeAlias",
            "icon", "id", "level", "key",
            "icContentTypeAlias", "name",
            "author", "isPublished",
            "creatorName", "creatorID", "createDate", "basicSeo", "robotSettings",
            "parentID", "nodeTypeAlias", "path", "nodeName", "nodeType", "sortOrder",
            "template", "updateDate", "urlName", "writerID", "writerName"
        };

        #region Overrides of ApplicationEventHandler

        protected override void ApplicationStarted(UmbracoApplicationBase umbracoApplication,
            ApplicationContext applicationContext)
        {
            base.ApplicationInitialized(umbracoApplication, applicationContext);

            var umbracoHelper = new UmbracoHelper(UmbracoContext.Current);
            ExamineManager.Instance.IndexProviderCollection["ProductsIndexer"].GatheringNodeData += (sender, e) =>
                NewsGatheringNodeData(e, applicationContext, umbracoHelper);

        }

        private void NewsGatheringNodeData(IndexingNodeDataEventArgs nodeData, ApplicationContext context,
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
                    var categoriesFriendly = new StringBuilder();
                    var featuredProducts = typedPage.FeaturedProducts;
                    foreach (var featuredProduct in typedPage.GetPropertyValue<Udi[]>("featuredProducts"))
                    {
                        var typedCategory = new Product(helper.TypedContent(featuredProduct as GuidUdi));

                    }


                }

            }
            catch (Exception ex)
            {
                LogHelper.Error(GetType(), $"Error indexing news article - [{nodeData.NodeId}]", ex);
            }

        }

        #endregion

    }
}

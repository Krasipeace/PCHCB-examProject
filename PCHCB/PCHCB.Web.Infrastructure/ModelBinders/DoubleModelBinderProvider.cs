namespace PCHCB.Web.Infrastructure.ModelBinders
{
    using Microsoft.AspNetCore.Mvc.ModelBinding;

    public class DoubleModelBinderProvider : IModelBinderProvider
    {
        /// <summary>
        /// Returns an instance of the DoubleModelBinder class if the model type is double or double?, 
        /// otherwise returns null. This method is used to provide a custom model binder for double and double?.
        /// </summary>
        /// <param name="context"></param>
        /// <returns>DoubleModelBinder</returns>
        /// <exception cref="ArgumentNullException">context</exception>
        public IModelBinder? GetBinder(ModelBinderProviderContext context)
        {
            if (context == null)
            {
                throw new ArgumentNullException(nameof(context));
            }

            if (context.Metadata.ModelType == typeof(Double) || 
                context.Metadata.ModelType == typeof(Double?))
            {
                return new DoubleModelBinder();
            }

            return null;
        }
    }
}

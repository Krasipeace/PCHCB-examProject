namespace PCHCB.Web.Infrastructure.ModelBinders
{
    using Microsoft.AspNetCore.Mvc.ModelBinding;

    public class DecimalModelBinderProvider : IModelBinderProvider
    {
        /// <summary>
        /// Returns an instance of the DecimalModelBinder class if the model type is decimal or decimal?, 
        /// otherwise returns null. This method is used to provide a custom model binder for decimal and decimal?.
        /// </summary>
        /// <param name="context"></param>
        /// <returns>DecimalModelBinder</returns>
        /// <exception cref="ArgumentNullException">context</exception>
        public IModelBinder GetBinder(ModelBinderProviderContext context)
        {
            if (context == null)
            {
                throw new ArgumentNullException(nameof(context));
            }

            if (context.Metadata.ModelType == typeof(decimal) || 
                context.Metadata.ModelType == typeof(decimal?))
            {
                return new DecimalModelBinder();
            }

            return null!;
        }
    }
}

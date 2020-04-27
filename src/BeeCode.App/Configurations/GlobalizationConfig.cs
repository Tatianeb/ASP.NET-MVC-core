using System.Collections.Generic;
using System.Globalization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Localization;

namespace BeeCode.App.Configurations
{
    public static class GlobalizationConfig
    {
        public static IApplicationBuilder UseGlobalizationConfig(this IApplicationBuilder app)
        {
            var defaltCulture = new CultureInfo("pt-BR");
            var localizationOptions = new RequestLocalizationOptions
            {
                DefaultRequestCulture = new RequestCulture(defaltCulture),
                SupportedCultures = new List<CultureInfo> { defaltCulture },
                SupportedUICultures = new List<CultureInfo> { defaltCulture }
            };

            app.UseRequestLocalization(localizationOptions);

            return app;
        }

    }
}
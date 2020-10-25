import { ApplicationInsights } from '@microsoft/applicationinsights-web'

document.onload = function() {
    const appInsights = new ApplicationInsights({
        config: {
            instrumentationKey: 'c7c4e755-698d-4c0f-91eb-f74d61103422'
            /* ...Other Configuration Options... */
        }
    });
    appInsights.loadAppInsights();
    appInsights.trackPageView(); // Manually call trackPageView to establish the current user/session/pageview

    appInsights.trackTrace({ message: "Default page is loaded" });
}

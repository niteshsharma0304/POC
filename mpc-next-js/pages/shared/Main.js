
import { getPortalSettings } from "../../helpers/CommonUtils";

var globalObj = {};
globalObj.portalSettings = getPortalSettings();

export default function Main(props) {
    const renderMobileTags = () => {
        if (props.isMobile) {
            return (
                <>
                    <meta name="viewport" content="width=device-width, initial-scale=1.0, maximum-scale=1.0, user-scalable=0" />
                </>
            );
        }
        else
            return null;
    }
    return (
        <>
            <head>
                <title>{globalObj.portalSettings.pageTitle}</title>
                <meta charset="utf-8" />
                <meta httpEquiv="X-UA-Compatible" content="IE=edge,chrome=1" />
                <meta name="robots" content="noindex, nofollow" />
                <link rel="icon" href="/favicon.ico" />
                {renderMobileTags()}
            </head>
            <body>
                <img src={globalObj.portalSettings.logoPath} className="logo" />
                Hello Main
                {props.isMobile && <div id="mobile-view">Mobile View</div>}
            </body>
        </>


    );
}
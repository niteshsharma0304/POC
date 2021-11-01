
import Head from 'next/head';

export default function Main(props) {
    const renderHeadScripts = () =>{
        console.log("----here---------", (props.featuresList && props.featuresList.length));
        if(props.featuresList){
            return(
                <script type="text/javascript">
                    window.RDL = {JSON.stringify(props)}
                </script>
            );
        } 
        return null;
    }
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
            <Head>
                <title>{props.pageTitle}</title>
                <meta charset="utf-8" />
                <meta httpEquiv="X-UA-Compatible" content="IE=edge,chrome=1" />
                <meta name="robots" content="noindex, nofollow" />
                <link rel="icon" href="/favicon.ico" />
                {renderMobileTags()}
                {renderHeadScripts()}
            </Head>
            <>
                <img src={props.logoPath} className="logo" />
                Hello Main
                {props.isMobile && <div id="mobile-view">Mobile View</div>}
            </>
        </>
    );    
}

export async function getStaticProps() {
    const isSkipCache = process.env.settings.portalSettings.isSkipCache;
    const portalCD = process.env.settings.portalSettings.portalCD;
    let apiUrl = process.env.settings.common.apiUrl;
    const skipCacheQS = isSkipCache? "?skipCache=true": "";
    apiUrl = apiUrl + "config/features/" + portalCD + skipCacheQS;
    const res = await fetch(apiUrl);
    const featuresList = await res.json();
    return {
      props: {featuresList}, // will be passed to the page component as props
    }
  }
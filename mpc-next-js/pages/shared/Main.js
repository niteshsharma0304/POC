
import Head from 'next/head';

export default function Main(props) {
    //console.log("----------->", props.featuresList );
    const renderHeadScripts = () =>{
        return(
            <script type="text/javascript">
                window.RDL = {JSON.stringify(props)}
            </script>
        );
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

// export async function getStaticProps(props) {
    // const skipCacheQS = props.isSkipCache? "?skipCache=true": "";
    // console.log("------------props->", props);
    // const apiUrl = props.apiUrl + "config/features/" + props.portalCD + skipCacheQS;
    // const res = await fetch(apiUrl);
    // const featuresList = await res.json();
    // return {
    //   props: {featuresList}, // will be passed to the page component as props
    // }
//   }
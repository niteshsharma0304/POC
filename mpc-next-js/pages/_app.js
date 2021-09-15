import '../styles/globals.css'

function MyApp({ Component, pageProps }) {
  let portalSettings = {
    ...process.env.settings.common,
    ...process.env.settings.portalSettings
  };
  let props = {
    ...pageProps, 
    ...portalSettings
  };
  return <Component  {...props}/>
}

export default MyApp

function getPortal(){
    return "myperfectcoverletter.com";
}

export function getPortalSettings(){
    let settings = process.env.settings;
    let portal = getPortal();
    let portalSettings = settings[portal];
    return {...settings.common, ...portalSettings};
}
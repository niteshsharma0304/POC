var portalConfigPath, portalConfig, portal = process.env.npm_config_portal;
portalConfigPath = "./portal-config/" + portal + "/config.json";
portalConfig = require(portalConfigPath);

var settings = {
  common: {
    apiUrl: "https://api-qa-embedded-builder."+portalConfig.requestingDomain+"/api/v1/"
  }
};

settings.portalSettings = portalConfig;

// console.log("---------------------------------------");
// console.log(process.env.npm_config_portal);
// console.log(process.env.npm_config_env);
// console.log(settings);
// console.log("---------------------------------------");

module.exports = {
  env: {
    settings: settings
  }
};
